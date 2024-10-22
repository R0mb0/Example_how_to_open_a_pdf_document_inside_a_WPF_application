using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Fields
        private string PDFpath = null;
        private string HTMLpath = null;
        /*Filter array*/
        string[] stringsToRemove = new string[4];

        /*----BUILDER----*/
        public Form()
        {
            InitializeComponent();

            //Hide loading gif
            this.loading.Hide();

            //Prepare filter strin array
            /*Prepare strings to check*/
            stringsToRemove[0] = "<div style=\"position:absolute; top:50px;\"><a name=\"1\">Page";
            stringsToRemove[1] = "<div style=\"position:absolute; top:0px;\">Page:";
            stringsToRemove[2] = "<br></span></div><div style=\"position:absolute; top:0px;\">Page:";
            stringsToRemove[3] = "<span style=\"font-family: Utopia-Regular; font-size:10px\">1";
        }

        /*----PRIVATE METHODS----*/
        /*Change element on a string*/
        private string ChangeString(string original, string find, string replace)
        {
            StringBuilder builder = new StringBuilder(original);
            builder.Replace(find, replace);
            return builder.ToString();
        }

        //Check if a string starts with the strings to check
        private bool stringStartsWith(string stringtoCheck, string[] stringsToChecks)
        {
            foreach (var item in stringsToChecks)
            {
                if (stringtoCheck.StartsWith(item) || stringtoCheck.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }

        //Clear document with useless lines
        private string RemoveLineFromFile(string path, string[] stringstoRemove)
        {
            return string.Join("", File.ReadLines(path).Where(line => !stringStartsWith(line, stringstoRemove)));
        }

        /*----OPEN BUTTON----*/
        private void BOpen_Click(object sender, EventArgs e)
        {
            //Show loading gif
            this.loading.Show();

            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize OpenFileDialog to open pdf files.
            openFile1.DefaultExt = "*.pdf";
            openFile1.Filter = "PDF Files|*.pdf";

            // Determine whether the user selected a file from the OpenFileDialog. 
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                this.PDFpath = openFile1.FileName;
            }

            if (this.PDFpath != null)
            {
                try
                {
                    //Convert pdf to html
                    this.HTMLpath = ChangeString(this.PDFpath, ".pdf", ".html");
                    PdfToHtmlNet.Converter converter = new PdfToHtmlNet.Converter();
                    converter.ConvertToFile(this.PDFpath, this.HTMLpath);

                    this.TextBox.LoadFile(new MemoryStream(Encoding.UTF8.GetBytes((MarkupConverter.HtmlToRtfConverter.ConvertHtmlToRtf(RemoveLineFromFile(this.HTMLpath, stringsToRemove))))), RichTextBoxStreamType.RichText);

                    /*Delete html temp file*/
                    File.Delete(this.HTMLpath);
                }
                catch 
                {
                    MessageBox.Show("Error during file processing");
                }
            }

            //Show loading gif
            this.loading.Hide();
        }

        /*----CLEAR BUTTON----*/
        private void BClear_Click(object sender, EventArgs e)
        {
            this.TextBox.Clear();
        }
    }
}

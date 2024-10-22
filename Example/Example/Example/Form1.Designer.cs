namespace Example
{
    partial class Form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.BOpen = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(689, 530);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // BOpen
            // 
            this.BOpen.Location = new System.Drawing.Point(718, 13);
            this.BOpen.Margin = new System.Windows.Forms.Padding(4);
            this.BOpen.Name = "BOpen";
            this.BOpen.Size = new System.Drawing.Size(112, 82);
            this.BOpen.TabIndex = 2;
            this.BOpen.Text = "Open";
            this.BOpen.UseVisualStyleBackColor = true;
            this.BOpen.Click += new System.EventHandler(this.BOpen_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(718, 121);
            this.BClear.Margin = new System.Windows.Forms.Padding(4);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(112, 82);
            this.BClear.TabIndex = 3;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // loading
            // 
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(122, 121);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(438, 285);
            this.loading.TabIndex = 11;
            this.loading.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(847, 554);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BOpen);
            this.Controls.Add(this.TextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form";
            this.Text = "Example";
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button BOpen;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.PictureBox loading;
    }
}


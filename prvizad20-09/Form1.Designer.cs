namespace prvizad20_09
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.textBoxRezultati = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(139, 48);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(160, 23);
            this.buttonOtvori.TabIndex = 0;
            this.buttonOtvori.Text = "Otvorite MessageBox";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            this.buttonOtvori.Click += new System.EventHandler(this.ButtonOtvori_Click);
            // 
            // textBoxRezultati
            // 
            this.textBoxRezultati.Location = new System.Drawing.Point(111, 112);
            this.textBoxRezultati.Multiline = true;
            this.textBoxRezultati.Name = "textBoxRezultati";
            this.textBoxRezultati.Size = new System.Drawing.Size(224, 115);
            this.textBoxRezultati.TabIndex = 1;
            this.textBoxRezultati.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 288);
            this.Controls.Add(this.textBoxRezultati);
            this.Controls.Add(this.buttonOtvori);
            this.Name = "Form1";
            this.Text = "Upotreba DialogResult enumeracije ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtvori;
        private System.Windows.Forms.TextBox textBoxRezultati;
    }
}


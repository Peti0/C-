namespace _18._2_igazitas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.igazitas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // igazitas
            // 
            this.igazitas.AutoSize = true;
            this.igazitas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.igazitas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.igazitas.Location = new System.Drawing.Point(101, 186);
            this.igazitas.Name = "igazitas";
            this.igazitas.Size = new System.Drawing.Size(635, 30);
            this.igazitas.TabIndex = 0;
            this.igazitas.Text = "Ha a felirat adott területére kattint, akkor  oda igazitom  a szöveget";
            this.igazitas.Click += new System.EventHandler(this.igazitas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.igazitas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label igazitas;
        private Label label;
        private Label irany;
    }
}
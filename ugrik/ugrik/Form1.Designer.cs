namespace ugrik
{
    partial class Formugras
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
            this.btnBalrafel = new System.Windows.Forms.Button();
            this.btnjobbrafel = new System.Windows.Forms.Button();
            this.btnBalrale = new System.Windows.Forms.Button();
            this.btnJobbrale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalrafel
            // 
            this.btnBalrafel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBalrafel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBalrafel.Location = new System.Drawing.Point(201, 78);
            this.btnBalrafel.Name = "btnBalrafel";
            this.btnBalrafel.Size = new System.Drawing.Size(120, 43);
            this.btnBalrafel.TabIndex = 0;
            this.btnBalrafel.Text = "Balra fel";
            this.btnBalrafel.UseVisualStyleBackColor = false;
            this.btnBalrafel.Click += new System.EventHandler(this.btnBalrafel_Click);
            // 
            // btnjobbrafel
            // 
            this.btnjobbrafel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnjobbrafel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnjobbrafel.Location = new System.Drawing.Point(474, 78);
            this.btnjobbrafel.Name = "btnjobbrafel";
            this.btnjobbrafel.Size = new System.Drawing.Size(117, 43);
            this.btnjobbrafel.TabIndex = 1;
            this.btnjobbrafel.Text = "Jobbra fel";
            this.btnjobbrafel.UseVisualStyleBackColor = false;
            this.btnjobbrafel.Click += new System.EventHandler(this.btnjobbrafel_Click);
            // 
            // btnBalrale
            // 
            this.btnBalrale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBalrale.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBalrale.Location = new System.Drawing.Point(201, 263);
            this.btnBalrale.Name = "btnBalrale";
            this.btnBalrale.Size = new System.Drawing.Size(120, 45);
            this.btnBalrale.TabIndex = 2;
            this.btnBalrale.Text = "Balra le";
            this.btnBalrale.UseVisualStyleBackColor = false;
            this.btnBalrale.Click += new System.EventHandler(this.btnBalrale_Click);
            // 
            // btnJobbrale
            // 
            this.btnJobbrale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnJobbrale.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJobbrale.Location = new System.Drawing.Point(474, 263);
            this.btnJobbrale.Name = "btnJobbrale";
            this.btnJobbrale.Size = new System.Drawing.Size(117, 45);
            this.btnJobbrale.TabIndex = 3;
            this.btnJobbrale.Text = "Jobbra le";
            this.btnJobbrale.UseVisualStyleBackColor = false;
            this.btnJobbrale.Click += new System.EventHandler(this.btnJobbrale_Click);
            // 
            // Formugras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJobbrale);
            this.Controls.Add(this.btnBalrale);
            this.Controls.Add(this.btnjobbrafel);
            this.Controls.Add(this.btnBalrafel);
            this.Name = "Formugras";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBalrafel;
        private Button btnjobbrafel;
        private Button btnBalrale;
        private Button btnJobbrale;
    }
}
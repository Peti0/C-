namespace _18._4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.felnöv = new System.Windows.Forms.Button();
            this.felcsökken = new System.Windows.Forms.Button();
            this.lenöv = new System.Windows.Forms.Button();
            this.lecsökken = new System.Windows.Forms.Button();
            this.TelF = new System.Windows.Forms.Button();
            this.Fel = new System.Windows.Forms.Button();
            this.Kozepre = new System.Windows.Forms.Button();
            this.Le = new System.Windows.Forms.Button();
            this.TelL = new System.Windows.Forms.Button();
            this.Bal = new System.Windows.Forms.Button();
            this.TelB = new System.Windows.Forms.Button();
            this.Jobb = new System.Windows.Forms.Button();
            this.TelJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Méret:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(195, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Átlátszóság:";
            // 
            // felnöv
            // 
            this.felnöv.Location = new System.Drawing.Point(311, 53);
            this.felnöv.Name = "felnöv";
            this.felnöv.Size = new System.Drawing.Size(96, 28);
            this.felnöv.TabIndex = 2;
            this.felnöv.Text = "Növekszik";
            this.felnöv.UseVisualStyleBackColor = true;

            // 
            // felcsökken
            // 
            this.felcsökken.Location = new System.Drawing.Point(477, 52);
            this.felcsökken.Name = "felcsökken";
            this.felcsökken.Size = new System.Drawing.Size(96, 30);
            this.felcsökken.TabIndex = 3;
            this.felcsökken.Text = "Csökken";
            this.felcsökken.UseVisualStyleBackColor = true;
            this.felcsökken.Click += new System.EventHandler(this.felcsökken_Click);
            // 
            // lenöv
            // 
            this.lenöv.Location = new System.Drawing.Point(332, 362);
            this.lenöv.Name = "lenöv";
            this.lenöv.Size = new System.Drawing.Size(96, 28);
            this.lenöv.TabIndex = 4;
            this.lenöv.Text = "Növekszik";
            this.lenöv.UseVisualStyleBackColor = true;
            // 
            // lecsökken
            // 
            this.lecsökken.Location = new System.Drawing.Point(489, 360);
            this.lecsökken.Name = "lecsökken";
            this.lecsökken.Size = new System.Drawing.Size(96, 30);
            this.lecsökken.TabIndex = 5;
            this.lecsökken.Text = "Csökken";
            this.lecsökken.UseVisualStyleBackColor = true;
            this.lecsökken.Click += new System.EventHandler(this.lecsökken_Click);
            // 
            // TelF
            // 
            this.TelF.Location = new System.Drawing.Point(371, 113);
            this.TelF.Name = "TelF";
            this.TelF.Size = new System.Drawing.Size(102, 33);
            this.TelF.TabIndex = 6;
            this.TelF.Text = "Teljesen";
            this.TelF.UseVisualStyleBackColor = true;
            this.TelF.Click += new System.EventHandler(this.TelF_Click);
            // 
            // Fel
            // 
            this.Fel.Location = new System.Drawing.Point(371, 161);
            this.Fel.Name = "Fel";
            this.Fel.Size = new System.Drawing.Size(102, 33);
            this.Fel.TabIndex = 7;
            this.Fel.Text = "Fel";
            this.Fel.UseVisualStyleBackColor = true;
            this.Fel.Click += new System.EventHandler(this.Fel_Click);
            // 
            // Kozepre
            // 
            this.Kozepre.Location = new System.Drawing.Point(371, 212);
            this.Kozepre.Name = "Kozepre";
            this.Kozepre.Size = new System.Drawing.Size(102, 33);
            this.Kozepre.TabIndex = 8;
            this.Kozepre.Text = "Középre";
            this.Kozepre.UseVisualStyleBackColor = true;
            this.Kozepre.Click += new System.EventHandler(this.Kozepre_Click);
            // 
            // Le
            // 
            this.Le.Location = new System.Drawing.Point(371, 260);
            this.Le.Name = "Le";
            this.Le.Size = new System.Drawing.Size(102, 33);
            this.Le.TabIndex = 9;
            this.Le.Text = "Le";
            this.Le.UseVisualStyleBackColor = true;
            this.Le.Click += new System.EventHandler(this.Le_Click);
            // 
            // TelL
            // 
            this.TelL.Location = new System.Drawing.Point(371, 311);
            this.TelL.Name = "TelL";
            this.TelL.Size = new System.Drawing.Size(102, 33);
            this.TelL.TabIndex = 10;
            this.TelL.Text = "Teljesen";
            this.TelL.UseVisualStyleBackColor = true;
            this.TelL.Click += new System.EventHandler(this.TelL_Click);
            // 
            // Bal
            // 
            this.Bal.Location = new System.Drawing.Point(249, 212);
            this.Bal.Name = "Bal";
            this.Bal.Size = new System.Drawing.Size(102, 33);
            this.Bal.TabIndex = 11;
            this.Bal.Text = "Balra";
            this.Bal.UseVisualStyleBackColor = true;
            this.Bal.Click += new System.EventHandler(this.Bal_Click);
            // 
            // TelB
            // 
            this.TelB.Location = new System.Drawing.Point(130, 212);
            this.TelB.Name = "TelB";
            this.TelB.Size = new System.Drawing.Size(102, 33);
            this.TelB.TabIndex = 12;
            this.TelB.Text = "Teljesen";
            this.TelB.UseVisualStyleBackColor = true;
            this.TelB.Click += new System.EventHandler(this.TelB_Click);
            // 
            // Jobb
            // 
            this.Jobb.Location = new System.Drawing.Point(489, 212);
            this.Jobb.Name = "Jobb";
            this.Jobb.Size = new System.Drawing.Size(102, 33);
            this.Jobb.TabIndex = 13;
            this.Jobb.Text = "Jobbra";
            this.Jobb.UseVisualStyleBackColor = true;
            // 
            // TelJ
            // 
            this.TelJ.Location = new System.Drawing.Point(612, 212);
            this.TelJ.Name = "TelJ";
            this.TelJ.Size = new System.Drawing.Size(102, 33);
            this.TelJ.TabIndex = 14;
            this.TelJ.Text = "Teljesen";
            this.TelJ.UseVisualStyleBackColor = true;
            this.TelJ.Click += new System.EventHandler(this.TelJ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TelJ);
            this.Controls.Add(this.Jobb);
            this.Controls.Add(this.TelB);
            this.Controls.Add(this.Bal);
            this.Controls.Add(this.TelL);
            this.Controls.Add(this.Le);
            this.Controls.Add(this.Kozepre);
            this.Controls.Add(this.Fel);
            this.Controls.Add(this.TelF);
            this.Controls.Add(this.lecsökken);
            this.Controls.Add(this.lenöv);
            this.Controls.Add(this.felcsökken);
            this.Controls.Add(this.felnöv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";

            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button felnöv;
        private Button felcsökken;
        private Button lenöv;
        private Button lecsökken;
        private Button TelF;
        private Button Fel;
        private Button Kozepre;
        private Button Le;
        private Button TelL;
        private Button Bal;
        private Button TelB;
        private Button Jobb;
        private Button TelJ;
    }
}
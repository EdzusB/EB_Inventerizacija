namespace EB_inventerizacija
{
    partial class Form3
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
            this.Vards_Text = new System.Windows.Forms.TextBox();
            this.Uzvards_Text = new System.Windows.Forms.TextBox();
            this.Lietotajvards_Text = new System.Windows.Forms.TextBox();
            this.Parole_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registreties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vards_Text
            // 
            this.Vards_Text.Location = new System.Drawing.Point(544, 120);
            this.Vards_Text.Name = "Vards_Text";
            this.Vards_Text.Size = new System.Drawing.Size(100, 20);
            this.Vards_Text.TabIndex = 0;
            // 
            // Uzvards_Text
            // 
            this.Uzvards_Text.Location = new System.Drawing.Point(544, 147);
            this.Uzvards_Text.Name = "Uzvards_Text";
            this.Uzvards_Text.Size = new System.Drawing.Size(100, 20);
            this.Uzvards_Text.TabIndex = 1;
            // 
            // Lietotajvards_Text
            // 
            this.Lietotajvards_Text.Location = new System.Drawing.Point(544, 174);
            this.Lietotajvards_Text.Name = "Lietotajvards_Text";
            this.Lietotajvards_Text.Size = new System.Drawing.Size(100, 20);
            this.Lietotajvards_Text.TabIndex = 2;
            // 
            // Parole_Text
            // 
            this.Parole_Text.Location = new System.Drawing.Point(544, 201);
            this.Parole_Text.Name = "Parole_Text";
            this.Parole_Text.Size = new System.Drawing.Size(100, 20);
            this.Parole_Text.TabIndex = 3;
            this.Parole_Text.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vārds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uzvārds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lietotājvārds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parole";
            // 
            // registreties
            // 
            this.registreties.Location = new System.Drawing.Point(544, 248);
            this.registreties.Name = "registreties";
            this.registreties.Size = new System.Drawing.Size(75, 23);
            this.registreties.TabIndex = 8;
            this.registreties.Text = "Reģistrēties";
            this.registreties.UseVisualStyleBackColor = true;
            this.registreties.Click += new System.EventHandler(this.registreties_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registreties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parole_Text);
            this.Controls.Add(this.Lietotajvards_Text);
            this.Controls.Add(this.Uzvards_Text);
            this.Controls.Add(this.Vards_Text);
            this.Name = "Form3";
            this.Text = "Reģistrēšanās";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vards_Text;
        private System.Windows.Forms.TextBox Uzvards_Text;
        private System.Windows.Forms.TextBox Lietotajvards_Text;
        private System.Windows.Forms.TextBox Parole_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registreties;
    }
}
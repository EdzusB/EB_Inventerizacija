namespace EB_inventerizacija
{
    partial class Form2
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
            this.lietotajvards_Text = new System.Windows.Forms.TextBox();
            this.parole_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ieiet_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lietotajvards_Text
            // 
            this.lietotajvards_Text.Location = new System.Drawing.Point(517, 114);
            this.lietotajvards_Text.Name = "lietotajvards_Text";
            this.lietotajvards_Text.Size = new System.Drawing.Size(100, 20);
            this.lietotajvards_Text.TabIndex = 0;
            // 
            // parole_Text
            // 
            this.parole_Text.Location = new System.Drawing.Point(517, 141);
            this.parole_Text.Name = "parole_Text";
            this.parole_Text.Size = new System.Drawing.Size(100, 20);
            this.parole_Text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lietotājvārds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ieiet_button
            // 
            this.ieiet_button.Location = new System.Drawing.Point(527, 206);
            this.ieiet_button.Name = "ieiet_button";
            this.ieiet_button.Size = new System.Drawing.Size(75, 23);
            this.ieiet_button.TabIndex = 3;
            this.ieiet_button.Text = "Ieiet";
            this.ieiet_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parole";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ieiet_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parole_Text);
            this.Controls.Add(this.lietotajvards_Text);
            this.Name = "Form2";
            this.Text = "Pierakstīšanās";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lietotajvards_Text;
        private System.Windows.Forms.TextBox parole_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ieiet_button;
        private System.Windows.Forms.Label label2;
    }
}
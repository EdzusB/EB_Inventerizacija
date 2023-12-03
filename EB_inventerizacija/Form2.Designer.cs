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
            this.lietotajvards_Text.Location = new System.Drawing.Point(689, 140);
            this.lietotajvards_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lietotajvards_Text.Name = "lietotajvards_Text";
            this.lietotajvards_Text.Size = new System.Drawing.Size(132, 22);
            this.lietotajvards_Text.TabIndex = 0;
            // 
            // parole_Text
            // 
            this.parole_Text.Location = new System.Drawing.Point(689, 174);
            this.parole_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parole_Text.Name = "parole_Text";
            this.parole_Text.Size = new System.Drawing.Size(132, 22);
            this.parole_Text.TabIndex = 1;
            this.parole_Text.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lietotājvārds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ieiet_button
            // 
            this.ieiet_button.Location = new System.Drawing.Point(703, 254);
            this.ieiet_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ieiet_button.Name = "ieiet_button";
            this.ieiet_button.Size = new System.Drawing.Size(100, 28);
            this.ieiet_button.TabIndex = 3;
            this.ieiet_button.Text = "Ieiet";
            this.ieiet_button.UseVisualStyleBackColor = true;
            this.ieiet_button.Click += new System.EventHandler(this.ieiet_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parole";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ieiet_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parole_Text);
            this.Controls.Add(this.lietotajvards_Text);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
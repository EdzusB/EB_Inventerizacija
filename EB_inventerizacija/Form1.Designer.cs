namespace EB_inventerizacija
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
            this.pierakstisanas_button = new System.Windows.Forms.Button();
            this.registresanas_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pierakstisanas_button
            // 
            this.pierakstisanas_button.Location = new System.Drawing.Point(659, 81);
            this.pierakstisanas_button.Name = "pierakstisanas_button";
            this.pierakstisanas_button.Size = new System.Drawing.Size(87, 23);
            this.pierakstisanas_button.TabIndex = 0;
            this.pierakstisanas_button.Text = "Pierakstīties";
            this.pierakstisanas_button.UseVisualStyleBackColor = true;
            this.pierakstisanas_button.Click += new System.EventHandler(this.pierakstisanas_button_Click);
            // 
            // registresanas_button
            // 
            this.registresanas_button.Location = new System.Drawing.Point(659, 110);
            this.registresanas_button.Name = "registresanas_button";
            this.registresanas_button.Size = new System.Drawing.Size(87, 23);
            this.registresanas_button.TabIndex = 1;
            this.registresanas_button.Text = "Reģistrēties";
            this.registresanas_button.UseVisualStyleBackColor = true;
            this.registresanas_button.Click += new System.EventHandler(this.registresanas_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registresanas_button);
            this.Controls.Add(this.pierakstisanas_button);
            this.Name = "Form1";
            this.Text = "Sākumlapa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pierakstisanas_button;
        private System.Windows.Forms.Button registresanas_button;
    }
}


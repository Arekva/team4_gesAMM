﻿namespace Mama
{
    partial class I_Saisie_Form
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
            this.cbMedocs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbMedocs
            // 
            this.cbMedocs.FormattingEnabled = true;
            this.cbMedocs.Location = new System.Drawing.Point(35, 45);
            this.cbMedocs.Name = "cbMedocs";
            this.cbMedocs.Size = new System.Drawing.Size(121, 21);
            this.cbMedocs.TabIndex = 0;
            // 
            // I_Saisie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMedocs);
            this.Name = "I_Saisie_Form";
            this.Text = "I_Saisie_Form";
            this.Load += new System.EventHandler(this.I_Saisie_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedocs;
    }
}
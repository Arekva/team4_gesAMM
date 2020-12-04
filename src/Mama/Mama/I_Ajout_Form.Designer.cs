namespace Mama
{
    partial class I_Ajout_Form
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
            this.cbFamille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDepotLegal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbFamille
            // 
            this.cbFamille.FormattingEnabled = true;
            this.cbFamille.Location = new System.Drawing.Point(482, 141);
            this.cbFamille.Name = "cbFamille";
            this.cbFamille.Size = new System.Drawing.Size(121, 24);
            this.cbFamille.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Famille ";
            // 
            // tbDepotLegal
            // 
            this.tbDepotLegal.Location = new System.Drawing.Point(229, 144);
            this.tbDepotLegal.Name = "tbDepotLegal";
            this.tbDepotLegal.Size = new System.Drawing.Size(100, 22);
            this.tbDepotLegal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Depot legal";
            // 
            // I_Ajout_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDepotLegal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFamille);
            this.Name = "I_Ajout_Form";
            this.Text = "I_Ajout_Form";
            this.Load += new System.EventHandler(this.I_Ajout_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDepotLegal;
        private System.Windows.Forms.Label label2;
    }
}
namespace Mama
{
    partial class C_NombreMedicaments_Form
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
            this.lvFamille = new System.Windows.Forms.ListView();
            this.CodeFamille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FamilleDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FamilleNbrMedicamentAutorise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFamille
            // 
            this.lvFamille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeFamille,
            this.FamilleDesignation,
            this.FamilleNbrMedicamentAutorise});
            this.lvFamille.Location = new System.Drawing.Point(47, 47);
            this.lvFamille.Name = "lvFamille";
            this.lvFamille.Size = new System.Drawing.Size(416, 494);
            this.lvFamille.TabIndex = 0;
            this.lvFamille.UseCompatibleStateImageBehavior = false;
            this.lvFamille.View = System.Windows.Forms.View.Details;
            // 
            // CodeFamille
            // 
            this.CodeFamille.Text = "Code";
            // 
            // FamilleDesignation
            // 
            this.FamilleDesignation.Text = "Designation";
            this.FamilleDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FamilleDesignation.Width = 100;
            // 
            // FamilleNbrMedicamentAutorise
            // 
            this.FamilleNbrMedicamentAutorise.Text = "Nombre mediacments autorisés";
            this.FamilleNbrMedicamentAutorise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FamilleNbrMedicamentAutorise.Width = 250;
            // 
            // C_NombreMedicaments_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 599);
            this.Controls.Add(this.lvFamille);
            this.Name = "C_NombreMedicaments_Form";
            this.Text = "C_NombreMedicaments_Form";
            this.Load += new System.EventHandler(this.C_NombreMedicaments_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFamille;
        private System.Windows.Forms.ColumnHeader CodeFamille;
        private System.Windows.Forms.ColumnHeader FamilleDesignation;
        private System.Windows.Forms.ColumnHeader FamilleNbrMedicamentAutorise;
    }
}
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
            this.tbFamilleSelection = new System.Windows.Forms.TextBox();
            this.lbFamilleSelectionnée = new System.Windows.Forms.Label();
            this.lvLesMedicaments = new System.Windows.Forms.ListView();
            this.MedicamentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btChercherMedicament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvFamille
            // 
            this.lvFamille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFamille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeFamille,
            this.FamilleDesignation,
            this.FamilleNbrMedicamentAutorise});
            this.lvFamille.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFamille.ForeColor = System.Drawing.Color.Navy;
            this.lvFamille.FullRowSelect = true;
            this.lvFamille.Location = new System.Drawing.Point(169, 174);
            this.lvFamille.Name = "lvFamille";
            this.lvFamille.Size = new System.Drawing.Size(1026, 616);
            this.lvFamille.TabIndex = 0;
            this.lvFamille.UseCompatibleStateImageBehavior = false;
            this.lvFamille.View = System.Windows.Forms.View.Details;
            this.lvFamille.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvFamille_ItemSelectionChanged);
            // 
            // CodeFamille
            // 
            this.CodeFamille.Text = "Code";
            // 
            // FamilleDesignation
            // 
            this.FamilleDesignation.Text = "Designation";
            this.FamilleDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FamilleDesignation.Width = 400;
            // 
            // FamilleNbrMedicamentAutorise
            // 
            this.FamilleNbrMedicamentAutorise.Text = "Nombre mediacments autorisés";
            this.FamilleNbrMedicamentAutorise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FamilleNbrMedicamentAutorise.Width = 250;
            // 
            // tbFamilleSelection
            // 
            this.tbFamilleSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.tbFamilleSelection.Location = new System.Drawing.Point(1315, 237);
            this.tbFamilleSelection.Name = "tbFamilleSelection";
            this.tbFamilleSelection.ReadOnly = true;
            this.tbFamilleSelection.Size = new System.Drawing.Size(166, 34);
            this.tbFamilleSelection.TabIndex = 1;
            this.tbFamilleSelection.Text = "Aucune";
            this.tbFamilleSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbFamilleSelectionnée
            // 
            this.lbFamilleSelectionnée.AutoSize = true;
            this.lbFamilleSelectionnée.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbFamilleSelectionnée.ForeColor = System.Drawing.Color.Navy;
            this.lbFamilleSelectionnée.Location = new System.Drawing.Point(1212, 176);
            this.lbFamilleSelectionnée.Name = "lbFamilleSelectionnée";
            this.lbFamilleSelectionnée.Size = new System.Drawing.Size(377, 36);
            this.lbFamilleSelectionnée.TabIndex = 2;
            this.lbFamilleSelectionnée.Text = "CodeFamille selectionnée :";
            // 
            // lvLesMedicaments
            // 
            this.lvLesMedicaments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLesMedicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MedicamentName});
            this.lvLesMedicaments.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lvLesMedicaments.ForeColor = System.Drawing.Color.Navy;
            this.lvLesMedicaments.FullRowSelect = true;
            this.lvLesMedicaments.Location = new System.Drawing.Point(1218, 374);
            this.lvLesMedicaments.Name = "lvLesMedicaments";
            this.lvLesMedicaments.Size = new System.Drawing.Size(336, 357);
            this.lvLesMedicaments.TabIndex = 3;
            this.lvLesMedicaments.UseCompatibleStateImageBehavior = false;
            this.lvLesMedicaments.View = System.Windows.Forms.View.Details;
            // 
            // MedicamentName
            // 
            this.MedicamentName.Text = "Nom médicament";
            this.MedicamentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MedicamentName.Width = 250;
            // 
            // btChercherMedicament
            // 
            this.btChercherMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btChercherMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChercherMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btChercherMedicament.ForeColor = System.Drawing.Color.White;
            this.btChercherMedicament.Location = new System.Drawing.Point(1283, 300);
            this.btChercherMedicament.Name = "btChercherMedicament";
            this.btChercherMedicament.Size = new System.Drawing.Size(222, 52);
            this.btChercherMedicament.TabIndex = 4;
            this.btChercherMedicament.Text = "Chercher :";
            this.btChercherMedicament.UseVisualStyleBackColor = false;
            this.btChercherMedicament.Click += new System.EventHandler(this.btChercherMedicament_Click);
            // 
            // C_NombreMedicaments_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1907, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.btChercherMedicament);
            this.Controls.Add(this.lvLesMedicaments);
            this.Controls.Add(this.lbFamilleSelectionnée);
            this.Controls.Add(this.tbFamilleSelection);
            this.Controls.Add(this.lvFamille);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "C_NombreMedicaments_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "C_NombreMedicaments_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.C_NombreMedicaments_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFamille;
        private System.Windows.Forms.ColumnHeader CodeFamille;
        private System.Windows.Forms.ColumnHeader FamilleDesignation;
        private System.Windows.Forms.ColumnHeader FamilleNbrMedicamentAutorise;
        private System.Windows.Forms.TextBox tbFamilleSelection;
        private System.Windows.Forms.Label lbFamilleSelectionnée;
        private System.Windows.Forms.ListView lvLesMedicaments;
        private System.Windows.Forms.ColumnHeader MedicamentName;
        private System.Windows.Forms.Button btChercherMedicament;
    }
}
﻿namespace Mama
{
    partial class C_MedicamentsEnCours_Form
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
            this.lvMedocs = new System.Windows.Forms.ListView();
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.famille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvWorkflow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvMedocs
            // 
            this.lvMedocs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom,
            this.famille});
            this.lvMedocs.HideSelection = false;
            this.lvMedocs.Location = new System.Drawing.Point(29, 44);
            this.lvMedocs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvMedocs.Name = "lvMedocs";
            this.lvMedocs.Size = new System.Drawing.Size(311, 292);
            this.lvMedocs.TabIndex = 0;
            this.lvMedocs.UseCompatibleStateImageBehavior = false;
            this.lvMedocs.View = System.Windows.Forms.View.Details;
            this.lvMedocs.SelectedIndexChanged += new System.EventHandler(this.lvMedocs_SelectedIndexChanged);
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 92;
            // 
            // famille
            // 
            this.famille.Text = "Famille";
            this.famille.Width = 138;
            // 
            // lvWorkflow
            // 
            this.lvWorkflow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvWorkflow.Enabled = false;
            this.lvWorkflow.HideSelection = false;
            this.lvWorkflow.Location = new System.Drawing.Point(485, 44);
            this.lvWorkflow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvWorkflow.Name = "lvWorkflow";
            this.lvWorkflow.Size = new System.Drawing.Size(564, 292);
            this.lvWorkflow.TabIndex = 1;
            this.lvWorkflow.UseCompatibleStateImageBehavior = false;
            this.lvWorkflow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° Etape";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libellé";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "État";
            this.columnHeader3.Width = 98;
            // 
            // C_MedicamentsEnCours_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.lvWorkflow);
            this.Controls.Add(this.lvMedocs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "C_MedicamentsEnCours_Form";
            this.Text = "C_MedicamentsEnCours_Form";
            this.Load += new System.EventHandler(this.C_MedicamentsEnCours_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMedocs;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader famille;
        private System.Windows.Forms.ListView lvWorkflow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
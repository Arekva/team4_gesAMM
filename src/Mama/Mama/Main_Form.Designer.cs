namespace Mama
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.concultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsEnCoursDeValidationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunNouveauMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concultationToolStripMenuItem,
            this.interactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // concultationToolStripMenuItem
            // 
            this.concultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem,
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem,
            this.médicamentsEnCoursDeValidationToolStripMenuItem});
            this.concultationToolStripMenuItem.Name = "concultationToolStripMenuItem";
            this.concultationToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.concultationToolStripMenuItem.Text = "Consultation";
            // 
            // workflowDesÉtapesDunMédicamentToolStripMenuItem
            // 
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem.Name = "workflowDesÉtapesDunMédicamentToolStripMenuItem";
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem.Text = "Workflow des étapes d\'un médicament";
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem.Click += new System.EventHandler(this.workflowDesÉtapesDunMédicamentToolStripMenuItem_Click);
            // 
            // nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem
            // 
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem.Name = "nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem";
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem.Text = "Nombre de médicaments autorisés par famille";
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem.Click += new System.EventHandler(this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem_Click);
            // 
            // médicamentsEnCoursDeValidationToolStripMenuItem
            // 
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Name = "médicamentsEnCoursDeValidationToolStripMenuItem";
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Text = "Médicaments en cours de validation ";
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Click += new System.EventHandler(this.médicamentsEnCoursDeValidationToolStripMenuItem_Click);
            // 
            // interactionToolStripMenuItem
            // 
            this.interactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem,
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem,
            this.ajoutDunNouveauMédicamentToolStripMenuItem});
            this.interactionToolStripMenuItem.Name = "interactionToolStripMenuItem";
            this.interactionToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.interactionToolStripMenuItem.Text = "Interaction";
            // 
            // saisieDeLaDécisionDuneÉtapeToolStripMenuItem
            // 
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem.Name = "saisieDeLaDécisionDuneÉtapeToolStripMenuItem";
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem.Text = "Saisie de la décision d\'une étape ";
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem.Click += new System.EventHandler(this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem_Click);
            // 
            // miseÀJourDesÉtapesNorméesToolStripMenuItem
            // 
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem.Name = "miseÀJourDesÉtapesNorméesToolStripMenuItem";
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem.Text = "Mise à jour des étapes normées";
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourDesÉtapesNorméesToolStripMenuItem_Click);
            // 
            // ajoutDunNouveauMédicamentToolStripMenuItem
            // 
            this.ajoutDunNouveauMédicamentToolStripMenuItem.Name = "ajoutDunNouveauMédicamentToolStripMenuItem";
            this.ajoutDunNouveauMédicamentToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.ajoutDunNouveauMédicamentToolStripMenuItem.Text = "Ajout d’un nouveau médicament";
            this.ajoutDunNouveauMédicamentToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunNouveauMédicamentToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main_Form";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem concultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workflowDesÉtapesDunMédicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsEnCoursDeValidationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieDeLaDécisionDuneÉtapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourDesÉtapesNorméesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunNouveauMédicamentToolStripMenuItem;
    }
}
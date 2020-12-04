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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.concultationToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.concultationToolStripMenuItem.Text = "Concultation";
            // 
            // workflowDesÉtapesDunMédicamentToolStripMenuItem
            // 
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem.Name = "workflowDesÉtapesDunMédicamentToolStripMenuItem";
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem.Size = new System.Drawing.Size(400, 26);
            this.workflowDesÉtapesDunMédicamentToolStripMenuItem.Text = "Workflow des étapes d\'un médicament";
            // 
            // nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem
            // 
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem.Name = "nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem";
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem.Size = new System.Drawing.Size(400, 26);
            this.nombreDeMédicamentsAutorisésParFamilleToolStripMenuItem.Text = "Nombre de médicaments autorisés par famille";
            // 
            // médicamentsEnCoursDeValidationToolStripMenuItem
            // 
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Name = "médicamentsEnCoursDeValidationToolStripMenuItem";
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Size = new System.Drawing.Size(400, 26);
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
            this.interactionToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.interactionToolStripMenuItem.Text = "Interaction";
            // 
            // saisieDeLaDécisionDuneÉtapeToolStripMenuItem
            // 
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem.Name = "saisieDeLaDécisionDuneÉtapeToolStripMenuItem";
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.saisieDeLaDécisionDuneÉtapeToolStripMenuItem.Text = "Saisie de la décision d\'une étape ";
            // 
            // miseÀJourDesÉtapesNorméesToolStripMenuItem
            // 
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem.Name = "miseÀJourDesÉtapesNorméesToolStripMenuItem";
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.miseÀJourDesÉtapesNorméesToolStripMenuItem.Text = "Mise à jour des étapes normées";
            // 
            // ajoutDunNouveauMédicamentToolStripMenuItem
            // 
            this.ajoutDunNouveauMédicamentToolStripMenuItem.Name = "ajoutDunNouveauMédicamentToolStripMenuItem";
            this.ajoutDunNouveauMédicamentToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.ajoutDunNouveauMédicamentToolStripMenuItem.Text = "Ajout d’un nouveau médicament";
            this.ajoutDunNouveauMédicamentToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunNouveauMédicamentToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main";
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
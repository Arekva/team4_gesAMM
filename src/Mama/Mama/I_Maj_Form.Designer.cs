namespace Mama
{
    partial class I_Maj_Form
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
            this.lvEtape = new System.Windows.Forms.ListView();
            this.NumEtape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LibelleEtape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateNormeEtaê = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NormeEtape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbDateNorme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.btEnregistrerNorme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEtape
            // 
            this.lvEtape.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumEtape,
            this.LibelleEtape,
            this.DateNormeEtaê,
            this.NormeEtape});
            this.lvEtape.FullRowSelect = true;
            this.lvEtape.Location = new System.Drawing.Point(64, 45);
            this.lvEtape.Name = "lvEtape";
            this.lvEtape.Size = new System.Drawing.Size(426, 494);
            this.lvEtape.TabIndex = 1;
            this.lvEtape.UseCompatibleStateImageBehavior = false;
            this.lvEtape.View = System.Windows.Forms.View.Details;
            this.lvEtape.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvEtape_ItemSelectionChanged);
            // 
            // NumEtape
            // 
            this.NumEtape.Text = "N°";
            // 
            // LibelleEtape
            // 
            this.LibelleEtape.Text = "Libelle";
            this.LibelleEtape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LibelleEtape.Width = 125;
            // 
            // DateNormeEtaê
            // 
            this.DateNormeEtaê.Text = "DateNorme";
            this.DateNormeEtaê.Width = 116;
            // 
            // NormeEtape
            // 
            this.NormeEtape.Text = "Norme";
            this.NormeEtape.Width = 111;
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Location = new System.Drawing.Point(542, 133);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.Size = new System.Drawing.Size(150, 22);
            this.tbDateNorme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date Norme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Norme :";
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(542, 241);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.Size = new System.Drawing.Size(150, 22);
            this.tbNorme.TabIndex = 4;
            // 
            // btEnregistrerNorme
            // 
            this.btEnregistrerNorme.Location = new System.Drawing.Point(542, 356);
            this.btEnregistrerNorme.Name = "btEnregistrerNorme";
            this.btEnregistrerNorme.Size = new System.Drawing.Size(150, 30);
            this.btEnregistrerNorme.TabIndex = 6;
            this.btEnregistrerNorme.Text = "Enregistrer";
            this.btEnregistrerNorme.UseVisualStyleBackColor = true;
            // 
            // I_Maj_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 668);
            this.Controls.Add(this.btEnregistrerNorme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNorme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDateNorme);
            this.Controls.Add(this.lvEtape);
            this.Name = "I_Maj_Form";
            this.Text = "I_Maj_Form";
            this.Load += new System.EventHandler(this.I_Maj_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEtape;
        private System.Windows.Forms.ColumnHeader NumEtape;
        private System.Windows.Forms.ColumnHeader LibelleEtape;
        private System.Windows.Forms.ColumnHeader DateNormeEtaê;
        private System.Windows.Forms.ColumnHeader NormeEtape;
        private System.Windows.Forms.TextBox tbDateNorme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNorme;
        private System.Windows.Forms.Button btEnregistrerNorme;
    }
}
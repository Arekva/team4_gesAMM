namespace Mama
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
            this.lvWorkFlow = new System.Windows.Forms.ListView();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libellé = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.normes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateNorme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbMedocs
            // 
            this.cbMedocs.FormattingEnabled = true;
            this.cbMedocs.Location = new System.Drawing.Point(24, 56);
            this.cbMedocs.Name = "cbMedocs";
            this.cbMedocs.Size = new System.Drawing.Size(121, 21);
            this.cbMedocs.TabIndex = 0;
            // 
            // lvWorkFlow
            // 
            this.lvWorkFlow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.Date,
            this.libellé,
            this.normes,
            this.DateNorme,
            this.columnHeader1});
            this.lvWorkFlow.HideSelection = false;
            this.lvWorkFlow.Location = new System.Drawing.Point(198, 12);
            this.lvWorkFlow.Name = "lvWorkFlow";
            this.lvWorkFlow.Size = new System.Drawing.Size(834, 315);
            this.lvWorkFlow.TabIndex = 1;
            this.lvWorkFlow.UseCompatibleStateImageBehavior = false;
            this.lvWorkFlow.View = System.Windows.Forms.View.Details;
            // 
            // Numero
            // 
            this.Numero.Text = "N°";
            this.Numero.Width = 28;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 77;
            // 
            // libellé
            // 
            this.libellé.Text = "Libellé";
            this.libellé.Width = 134;
            // 
            // normes
            // 
            this.normes.Text = "Norme";
            this.normes.Width = 116;
            // 
            // DateNorme
            // 
            this.DateNorme.Text = "Date de la norme";
            this.DateNorme.Width = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez choisir un médicament";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Decision";
            // 
            // I_Saisie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvWorkFlow);
            this.Controls.Add(this.cbMedocs);
            this.Name = "I_Saisie_Form";
            this.Text = "I_Saisie_Form";
            this.Load += new System.EventHandler(this.I_Saisie_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedocs;
        private System.Windows.Forms.ListView lvWorkFlow;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader libellé;
        private System.Windows.Forms.ColumnHeader normes;
        private System.Windows.Forms.ColumnHeader DateNorme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
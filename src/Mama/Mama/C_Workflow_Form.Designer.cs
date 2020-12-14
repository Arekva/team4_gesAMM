namespace Mama
{
    partial class C_Workflow_Form
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
            this.lvWF = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbMedocs
            // 
            this.cbMedocs.FormattingEnabled = true;
            this.cbMedocs.Location = new System.Drawing.Point(12, 12);
            this.cbMedocs.Name = "cbMedocs";
            this.cbMedocs.Size = new System.Drawing.Size(121, 21);
            this.cbMedocs.TabIndex = 0;
            this.cbMedocs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lvWF
            // 
            this.lvWF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvWF.HideSelection = false;
            this.lvWF.Location = new System.Drawing.Point(226, 12);
            this.lvWF.Name = "lvWF";
            this.lvWF.Size = new System.Drawing.Size(542, 261);
            this.lvWF.TabIndex = 1;
            this.lvWF.UseCompatibleStateImageBehavior = false;
            this.lvWF.View = System.Windows.Forms.View.Details;
            this.lvWF.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            this.columnHeader1.Width = 27;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libellé";
            this.columnHeader2.Width = 247;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date Décision";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Norme";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date Norme";
            this.columnHeader5.Width = 113;
            // 
            // C_Workflow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvWF);
            this.Controls.Add(this.cbMedocs);
            this.Name = "C_Workflow_Form";
            this.Text = "C_Workflow_Form";
            this.Load += new System.EventHandler(this.C_Workflow_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedocs;
        private System.Windows.Forms.ListView lvWF;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
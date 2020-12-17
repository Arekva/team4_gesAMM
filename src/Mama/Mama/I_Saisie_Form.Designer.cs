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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btValider = new System.Windows.Forms.Button();
            this.btRefuser = new System.Windows.Forms.Button();
            this.aaa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAMM = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAMM)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMedocs
            // 
            this.cbMedocs.FormattingEnabled = true;
            this.cbMedocs.Location = new System.Drawing.Point(32, 69);
            this.cbMedocs.Margin = new System.Windows.Forms.Padding(4);
            this.cbMedocs.Name = "cbMedocs";
            this.cbMedocs.Size = new System.Drawing.Size(160, 24);
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
            this.lvWorkFlow.Location = new System.Drawing.Point(264, 15);
            this.lvWorkFlow.Margin = new System.Windows.Forms.Padding(4);
            this.lvWorkFlow.Name = "lvWorkFlow";
            this.lvWorkFlow.Size = new System.Drawing.Size(1148, 387);
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Decision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez choisir un médicament";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(449, 482);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(784, 479);
            this.btValider.Margin = new System.Windows.Forms.Padding(4);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(123, 37);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btRefuser
            // 
            this.btRefuser.Location = new System.Drawing.Point(931, 479);
            this.btRefuser.Margin = new System.Windows.Forms.Padding(4);
            this.btRefuser.Name = "btRefuser";
            this.btRefuser.Size = new System.Drawing.Size(121, 37);
            this.btRefuser.TabIndex = 5;
            this.btRefuser.Text = "Refuser";
            this.btRefuser.UseVisualStyleBackColor = true;
            this.btRefuser.Click += new System.EventHandler(this.btRefuser_Click);
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(672, 427);
            this.aaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(176, 17);
            this.aaa.TabIndex = 6;
            this.aaa.Text = "Valider la derniere étape ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date de la finition de l\'etape";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero AMM :";
            // 
            // nudAMM
            // 
            this.nudAMM.Location = new System.Drawing.Point(784, 539);
            this.nudAMM.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAMM.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAMM.Name = "nudAMM";
            this.nudAMM.Size = new System.Drawing.Size(138, 22);
            this.nudAMM.TabIndex = 9;
            this.nudAMM.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // I_Saisie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAMM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.btRefuser);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvWorkFlow);
            this.Controls.Add(this.cbMedocs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "I_Saisie_Form";
            this.Text = "I_Saisie_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.I_Saisie_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAMM)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btRefuser;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAMM;
        private System.Windows.Forms.Label label4;
    }
}
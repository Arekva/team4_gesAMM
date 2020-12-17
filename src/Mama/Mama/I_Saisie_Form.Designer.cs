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
            ((System.ComponentModel.ISupportInitialize)(this.nudAMM)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMedocs
            // 
            this.cbMedocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedocs.FormattingEnabled = true;
            this.cbMedocs.Location = new System.Drawing.Point(43, 69);
            this.cbMedocs.Name = "cbMedocs";
            this.cbMedocs.Size = new System.Drawing.Size(121, 28);
            this.cbMedocs.TabIndex = 0;
            // 
            // lvWorkFlow
            // 
            this.lvWorkFlow.BackColor = System.Drawing.Color.White;
            this.lvWorkFlow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWorkFlow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.Date,
            this.libellé,
            this.normes,
            this.DateNorme,
            this.columnHeader1});
            this.lvWorkFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvWorkFlow.HideSelection = false;
            this.lvWorkFlow.Location = new System.Drawing.Point(277, 11);
            this.lvWorkFlow.Name = "lvWorkFlow";
            this.lvWorkFlow.Size = new System.Drawing.Size(861, 210);
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
            this.DateNorme.Width = 134;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Decision";
            this.columnHeader1.Width = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez choisir un médicament";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(277, 262);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(251, 26);
            this.dtpDate.TabIndex = 3;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btValider.Location = new System.Drawing.Point(591, 282);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(92, 30);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btRefuser
            // 
            this.btRefuser.BackColor = System.Drawing.Color.IndianRed;
            this.btRefuser.Location = new System.Drawing.Point(701, 282);
            this.btRefuser.Name = "btRefuser";
            this.btRefuser.Size = new System.Drawing.Size(91, 30);
            this.btRefuser.TabIndex = 5;
            this.btRefuser.Text = "Refuser";
            this.btRefuser.UseVisualStyleBackColor = false;
            this.btRefuser.Click += new System.EventHandler(this.btRefuser_Click);
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.aaa.Location = new System.Drawing.Point(579, 240);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(231, 24);
            this.aaa.TabIndex = 6;
            this.aaa.Text = "Valider la derniere étape ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date de la finition de l\'etape";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero AMM :";
            // 
            // nudAMM
            // 
            this.nudAMM.BackColor = System.Drawing.Color.White;
            this.nudAMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAMM.Location = new System.Drawing.Point(382, 302);
            this.nudAMM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.nudAMM.Size = new System.Drawing.Size(104, 26);
            this.nudAMM.TabIndex = 9;
            this.nudAMM.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // I_Saisie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 474);
            this.ControlBox = false;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "I_Saisie_Form";
            this.Text = "Gestion des workflow";
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
    }
}
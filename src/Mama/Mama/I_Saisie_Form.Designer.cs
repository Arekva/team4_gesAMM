﻿namespace Mama
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
            this.lbTest = new System.Windows.Forms.ListBox();
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Decision";
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
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(337, 392);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(588, 389);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(92, 30);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btRefuser
            // 
            this.btRefuser.Location = new System.Drawing.Point(698, 389);
            this.btRefuser.Name = "btRefuser";
            this.btRefuser.Size = new System.Drawing.Size(91, 30);
            this.btRefuser.TabIndex = 5;
            this.btRefuser.Text = "Refuser";
            this.btRefuser.UseVisualStyleBackColor = true;
            this.btRefuser.Click += new System.EventHandler(this.btRefuser_Click);
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(504, 347);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(130, 13);
            this.aaa.TabIndex = 6;
            this.aaa.Text = "Valider la derniere étape ?";
            // 
            // lbTest
            // 
            this.lbTest.FormattingEnabled = true;
            this.lbTest.Location = new System.Drawing.Point(1063, 63);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(218, 264);
            this.lbTest.TabIndex = 7;
            // 
            // I_Saisie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 450);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.btRefuser);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.dtpDate);
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
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btRefuser;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.ListBox lbTest;
    }
}
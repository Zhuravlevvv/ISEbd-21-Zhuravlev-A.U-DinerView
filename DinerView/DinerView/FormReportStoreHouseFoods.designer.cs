﻿
namespace DinerView
{
    partial class FormReportStoreHouseFoods
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
            this.dataGridViewReportStoreHouseFoods = new System.Windows.Forms.DataGridView();
            this.Secure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportStoreHouseFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportStoreHouseFoods
            // 
            this.dataGridViewReportStoreHouseFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportStoreHouseFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Secure,
            this.Component,
            this.Count});
            this.dataGridViewReportStoreHouseFoods.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewReportStoreHouseFoods.Name = "dataGridViewReportStoreHouseFoods";
            this.dataGridViewReportStoreHouseFoods.Size = new System.Drawing.Size(507, 389);
            this.dataGridViewReportStoreHouseFoods.TabIndex = 3;
            // 
            // Secure
            // 
            this.Secure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Secure.HeaderText = "Склад";
            this.Secure.Name = "Secure";
            // 
            // Component
            // 
            this.Component.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Component.HeaderText = "Компонент";
            this.Component.Name = "Component";
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // buttonSaveToExcel
            // 
            this.buttonSaveToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveToExcel.Location = new System.Drawing.Point(12, 12);
            this.buttonSaveToExcel.Name = "buttonSaveToExcel";
            this.buttonSaveToExcel.Size = new System.Drawing.Size(139, 27);
            this.buttonSaveToExcel.TabIndex = 2;
            this.buttonSaveToExcel.Text = "Сохранить в эксель";
            this.buttonSaveToExcel.UseVisualStyleBackColor = true;
            this.buttonSaveToExcel.Click += new System.EventHandler(this.buttonSaveToExcel_Click);
            // 
            // FormReportStoreHouseComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 458);
            this.Controls.Add(this.dataGridViewReportStoreHouseFoods);
            this.Controls.Add(this.buttonSaveToExcel);
            this.Name = "FormReportStoreHouseComponents";
            this.Text = "Отчёт по складам";
            this.Load += new System.EventHandler(this.FormReportStoreHouseComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportStoreHouseFoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReportStoreHouseFoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Button buttonSaveToExcel;
    }
}
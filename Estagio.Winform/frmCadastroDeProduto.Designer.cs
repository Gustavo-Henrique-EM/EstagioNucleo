﻿namespace Estagio.Winform
{
    partial class frmCadastroDeProduto
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
            this.components = new System.ComponentModel.Container();
            this.bsProdutos = new System.Windows.Forms.BindingSource(this.components);
            this.currentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(643, 329);
            // 
            // currentDataGridViewTextBoxColumn
            // 
            this.currentDataGridViewTextBoxColumn.DataPropertyName = "Current";
            this.currentDataGridViewTextBoxColumn.HeaderText = "Current";
            this.currentDataGridViewTextBoxColumn.Name = "currentDataGridViewTextBoxColumn";
            this.currentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentDataGridViewTextBoxColumn1
            // 
            this.currentDataGridViewTextBoxColumn1.DataPropertyName = "Current";
            this.currentDataGridViewTextBoxColumn1.HeaderText = "Current";
            this.currentDataGridViewTextBoxColumn1.Name = "currentDataGridViewTextBoxColumn1";
            this.currentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // currentDataGridViewTextBoxColumn2
            // 
            this.currentDataGridViewTextBoxColumn2.DataPropertyName = "Current";
            this.currentDataGridViewTextBoxColumn2.HeaderText = "Current";
            this.currentDataGridViewTextBoxColumn2.Name = "currentDataGridViewTextBoxColumn2";
            this.currentDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmCadastroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Name = "frmCadastroDeProduto";
            this.Text = "frmCadastroDeProduto";
            this.Load += new System.EventHandler(this.frmCadastroDeProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDataGridViewTextBoxColumn2;
    }
}
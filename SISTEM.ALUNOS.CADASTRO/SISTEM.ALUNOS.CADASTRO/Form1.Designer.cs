﻿namespace CORUJA
{
    partial class Form1
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
            this.controleDeFiltroDePesquisa1 = new CONTROLES.ControleDeFiltroDePesquisa();
            this.SuspendLayout();
            // 
            // controleDeFiltroDePesquisa1
            // 
            this.controleDeFiltroDePesquisa1.Location = new System.Drawing.Point(12, 73);
            this.controleDeFiltroDePesquisa1.Name = "controleDeFiltroDePesquisa1";
            this.controleDeFiltroDePesquisa1.Size = new System.Drawing.Size(419, 118);
            this.controleDeFiltroDePesquisa1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.controleDeFiltroDePesquisa1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.controleDeFiltroDePesquisa1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONTROLES.ControleDeFiltroDePesquisa controleDeFiltroDePesquisa1;
    }
}
﻿namespace Ecology_2
{
    partial class Init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            this.label1 = new System.Windows.Forms.Label();
            this.loles = new System.Windows.Forms.TextBox();
            this.initok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество загрязняющих веществ для источника:";
            // 
            // loles
            // 
            this.loles.Location = new System.Drawing.Point(111, 92);
            this.loles.Name = "loles";
            this.loles.Size = new System.Drawing.Size(100, 20);
            this.loles.TabIndex = 1;
            // 
            // initok
            // 
            this.initok.Location = new System.Drawing.Point(122, 118);
            this.initok.Name = "initok";
            this.initok.Size = new System.Drawing.Size(75, 23);
            this.initok.TabIndex = 2;
            this.initok.Text = "ОК";
            this.initok.UseVisualStyleBackColor = true;
            this.initok.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 220);
            this.Controls.Add(this.initok);
            this.Controls.Add(this.loles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет загрязнений";
            this.Load += new System.EventHandler(this.Init_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loles;
        private System.Windows.Forms.Button initok;
    }
}
namespace Ecology_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ansxmax = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.Label();
            this.ansvmax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Jsum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.help = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(315, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Начать новый расчет для источника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Xmax";
            // 
            // ansxmax
            // 
            this.ansxmax.Location = new System.Drawing.Point(333, 236);
            this.ansxmax.Name = "ansxmax";
            this.ansxmax.ReadOnly = true;
            this.ansxmax.Size = new System.Drawing.Size(150, 20);
            this.ansxmax.TabIndex = 24;
            this.ansxmax.TabStop = false;
            this.ansxmax.TextChanged += new System.EventHandler(this.Ansxmax_TextChanged);
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Location = new System.Drawing.Point(294, 269);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(33, 13);
            this.tt.TabIndex = 25;
            this.tt.Text = "Vmax";
            // 
            // ansvmax
            // 
            this.ansvmax.Location = new System.Drawing.Point(333, 266);
            this.ansvmax.Name = "ansvmax";
            this.ansvmax.ReadOnly = true;
            this.ansvmax.Size = new System.Drawing.Size(150, 20);
            this.ansvmax.TabIndex = 26;
            this.ansvmax.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(77, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(250, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Суммарный индекс загрязнения по веществам";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // Jsum
            // 
            this.Jsum.Location = new System.Drawing.Point(333, 210);
            this.Jsum.Name = "Jsum";
            this.Jsum.ReadOnly = true;
            this.Jsum.Size = new System.Drawing.Size(150, 20);
            this.Jsum.TabIndex = 34;
            this.Jsum.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 35;
            this.button2.TabStop = false;
            this.button2.Text = "О программе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.TabStop = false;
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(182, 409);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 41;
            this.help.TabStop = false;
            this.help.Text = "Помощь";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.Help_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(215, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(386, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "\"Расчет загрязнений атмосферы выбросами промышленных источников\"";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(330, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Практическая работа номер 2: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Вывод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Температурная характеристика источника";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Посмотреть расширенный вывод";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.help);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Jsum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ansvmax);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.ansxmax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет загрязнений атмосферы выбросами промышленных источников";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ansxmax;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.TextBox ansvmax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Jsum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}


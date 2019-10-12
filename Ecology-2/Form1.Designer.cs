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
            this.PDK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Temp_subs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Temp_env = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VV1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.TextBox();
            this.A1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.H1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.M1 = new System.Windows.Forms.TextBox();
            this.anscmax1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ansxmax = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.Label();
            this.ansvmax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.anscmax2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.J1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.J2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Jsum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.MMM2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PDK2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.help = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(624, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Новый расчет для источника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PDK
            // 
            this.PDK.Location = new System.Drawing.Point(182, 64);
            this.PDK.Name = "PDK";
            this.PDK.Size = new System.Drawing.Size(100, 20);
            this.PDK.TabIndex = 3;
            this.PDK.TextChanged += new System.EventHandler(this.PDK_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ПДК первого вещества:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите одно";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(182, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Газ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(182, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Твердое вещество";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Температура выброса, ℃";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Temp_subs
            // 
            this.Temp_subs.Location = new System.Drawing.Point(182, 122);
            this.Temp_subs.Name = "Temp_subs";
            this.Temp_subs.Size = new System.Drawing.Size(100, 20);
            this.Temp_subs.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Температура воздуха, ℃";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Temp_env
            // 
            this.Temp_env.Location = new System.Drawing.Point(182, 204);
            this.Temp_env.Name = "Temp_env";
            this.Temp_env.Size = new System.Drawing.Size(100, 20);
            this.Temp_env.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "V1, м^3/с";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // VV1
            // 
            this.VV1.Location = new System.Drawing.Point(182, 236);
            this.VV1.Name = "VV1";
            this.VV1.Size = new System.Drawing.Size(100, 20);
            this.VV1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "D, м";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(35, 303);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(87, 13);
            this.A.TabIndex = 14;
            this.A.Text = "Коэффициент A";
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(182, 266);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(100, 20);
            this.D1.TabIndex = 10;
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(182, 296);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 20);
            this.A1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "H, м";
            // 
            // H1
            // 
            this.H1.Location = new System.Drawing.Point(182, 325);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(100, 20);
            this.H1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "M первого вещества, г/c";
            // 
            // M1
            // 
            this.M1.Location = new System.Drawing.Point(182, 150);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(100, 20);
            this.M1.TabIndex = 6;
            // 
            // anscmax1
            // 
            this.anscmax1.Location = new System.Drawing.Point(638, 206);
            this.anscmax1.Name = "anscmax1";
            this.anscmax1.ReadOnly = true;
            this.anscmax1.Size = new System.Drawing.Size(150, 20);
            this.anscmax1.TabIndex = 21;
            this.anscmax1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(590, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cmax-1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(599, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Xmax";
            // 
            // ansxmax
            // 
            this.ansxmax.Location = new System.Drawing.Point(638, 266);
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
            this.tt.Location = new System.Drawing.Point(599, 299);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(33, 13);
            this.tt.TabIndex = 25;
            this.tt.Text = "Vmax";
            // 
            // ansvmax
            // 
            this.ansvmax.Location = new System.Drawing.Point(638, 296);
            this.ansvmax.Name = "ansvmax";
            this.ansvmax.ReadOnly = true;
            this.ansvmax.Size = new System.Drawing.Size(150, 20);
            this.ansvmax.TabIndex = 26;
            this.ansvmax.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cmax-2";
            // 
            // anscmax2
            // 
            this.anscmax2.Location = new System.Drawing.Point(638, 236);
            this.anscmax2.Name = "anscmax2";
            this.anscmax2.ReadOnly = true;
            this.anscmax2.Size = new System.Drawing.Size(150, 20);
            this.anscmax2.TabIndex = 28;
            this.anscmax2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(360, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Индекс загрязнения атмофсеры первого вещества";
            // 
            // J1
            // 
            this.J1.Location = new System.Drawing.Point(638, 323);
            this.J1.Name = "J1";
            this.J1.ReadOnly = true;
            this.J1.Size = new System.Drawing.Size(150, 20);
            this.J1.TabIndex = 30;
            this.J1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Индекс загрязнения атмосферы второго вещества";
            // 
            // J2
            // 
            this.J2.Location = new System.Drawing.Point(638, 350);
            this.J2.Name = "J2";
            this.J2.ReadOnly = true;
            this.J2.Size = new System.Drawing.Size(150, 20);
            this.J2.TabIndex = 32;
            this.J2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(487, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Сумма по двум веществам";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // Jsum
            // 
            this.Jsum.Location = new System.Drawing.Point(638, 377);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "М второго вещества, г/с";
            // 
            // MMM2
            // 
            this.MMM2.Location = new System.Drawing.Point(182, 176);
            this.MMM2.Name = "MMM2";
            this.MMM2.Size = new System.Drawing.Size(100, 20);
            this.MMM2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ПДК второго вещества:";
            // 
            // PDK2
            // 
            this.PDK2.Location = new System.Drawing.Point(182, 92);
            this.PDK2.Name = "PDK2";
            this.PDK2.Size = new System.Drawing.Size(100, 20);
            this.PDK2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 172);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Сброс всех значений";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(402, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(386, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "\"Расчет загрязнений атмосферы выбросами промышленных источников\"";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(517, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Практическая работа номер 2: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.help);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PDK2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MMM2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Jsum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.J2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.J1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.anscmax2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ansvmax);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.ansxmax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.anscmax1);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.H1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VV1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Temp_env);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Temp_subs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PDK);
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
        private System.Windows.Forms.TextBox PDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Temp_subs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Temp_env;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VV1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.TextBox D1;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox H1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox M1;
        private System.Windows.Forms.TextBox anscmax1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ansxmax;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.TextBox ansvmax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox anscmax2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox J1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox J2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Jsum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MMM2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PDK2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}


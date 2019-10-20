using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;



namespace Ecology_2
{
   
    public partial class Form1 : Form
    {
        public static string GTEMP;
        public static double GXmax, GVmax;
        public static double GJJSUM;
        public static double[] JJS = new double[Init.n];
        public static double[] gcmaxes = new double[Init.n];
        public static double[] PDKS = new double[Init.n];
        public static double[] MS = new double[Init.n];
        public static int ii = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double deltaT_1 = unchang.deltaT;
            double V1 = unchang.VV;
            const double pi = 3.14;
            double D = unchang.DD;
            double ff_1, fe_1, num_1, numsh_1, vo_1;
            double H = unchang.HH;
            double n = 0;
            double A = unchang.AA;
            double F_1 = unchang.FF;



            for (; ii < Init.n; ii++)
            {
                CalcForm cacl = new CalcForm(ii);
                cacl.ShowDialog();
            }


            vo_1 = V1 / (pi * D * D / 4);

            ff_1 = 1000 * (vo_1 * vo_1 * D) / (H * H * deltaT_1);
            num_1 = 0.65 * Math.Pow(V1 * deltaT_1 / H, (double)1 / 3);
            numsh_1 = 1.3 * ((vo_1 * D) / H);
            fe_1 = 800 * Math.Pow(numsh_1, 3);
            if (ff_1 < 100)
            {
                if (num_1 >= 2)
                {
                    n = 1;
                }
                else if (num_1 < 0.5)
                {
                    n = 4.4 * num_1;
                }
                else if (num_1 < 2 && num_1 >= 0.5)
                {
                    n = (0.532 * num_1 * num_1) - (2.13 * num_1) + 3.13;
                }
            }
            else if (ff_1 >= 100)
            {
                if (numsh_1 >= 2)
                {
                    n = 1;
                }
                else if (numsh_1 < 0.5)
                {
                    n = 4.4 * numsh_1;
                }
                else if (numsh_1 < 2 && numsh_1 >= 0.5)
                {
                    n = (0.532 * numsh_1 * numsh_1) - (2.13 * numsh_1) + 3.13;
                }
            }
            double[] cmaxs = new double[PDKS.Length];
            double cmax;
            for (int i = 0; i < PDKS.Length; i++)
            {
                cmax = 0;
                if ((ff_1 >= 100 || (deltaT_1 > 0 && deltaT_1 < 0.5)) && numsh_1 >= 0.5)
                {
                    double k = (double)D / (8 * V1);
                    cmax = ((double)(A * MS[i] * F_1 * n) / Math.Pow(H, (double)4 / 3)) * k;

                }
                else
                {
                    double m = 0;
                    if (ff_1 < 100)
                    {
                        m = (double)1 / (0.67 + 0.1 * Math.Sqrt(ff_1) + 0.34 * Math.Pow(ff_1, (double)1 / 3));
                    }
                    else if (ff_1 >= 100)
                    {
                        m = (double)1.47 / (Math.Pow(ff_1, (double)1 / 3));
                    }
                    else if (fe_1 < ff_1 && ff_1 < 100)
                    {
                        m = (double)1 / (0.67 + 0.1 * Math.Sqrt(fe_1) + 0.34 * Math.Pow(fe_1, (double)1 / 3));
                    }
                    cmax = (double)(A * MS[i] * F_1 * m * n) / (H * H * Math.Pow((V1 * deltaT_1), (double)1 / 3));
                }
                cmaxs[i] = cmax;
            }
                //vmax + xmax calc
                double dd = 0;
                if (ff_1 < 100)
                {
                    if (num_1 <= 0.5)
                    {
                        dd = 2.48 * (1 + 0.28 * Math.Pow(fe_1, (double)1 / 3));
                    }
                    else if (0.5 < num_1 && num_1 <= 2)
                    {
                        dd = 4.95 * num_1 * (1 + 0.28 * Math.Pow(ff_1, (double)1 / 3));
                    }
                    else if (num_1 > 2)
                    {
                        dd = 7 * Math.Sqrt(num_1) * (1 + 0.28 * Math.Pow(ff_1, (double)1 / 3));
                    }
                }
                else if (ff_1 >= 100)
                {
                    if (numsh_1 <= 0.5)
                    {
                        dd = 5.7;
                    }
                    else if (0.5 < numsh_1 && numsh_1 <= 2)
                    {
                        dd = 11.4 * numsh_1;
                    }
                    else if (numsh_1 > 2)
                    {
                        dd = 16 * Math.Sqrt(numsh_1);
                    }
                }
                double xmax = (((5 - F_1) / 4) * (dd * H));
                double vmax = 0;
                if (ff_1 < 100)
                {
                    if (num_1 <= 0.5)
                    {
                        vmax = 0.5;
                    }
                    else if (0.5 < num_1 && num_1 <= 2)
                    {
                        vmax = num_1;
                    }
                    else if (num_1 > 2)
                    {
                        vmax = num_1 * (1 + 0.12 * Math.Sqrt(ff_1));
                    }
                }
                else if (ff_1 >= 100)
                {
                    if (numsh_1 <= 0.5)
                    {
                        vmax = 0.5;
                    }
                    else if (0.5 < numsh_1 && numsh_1 <= 2)
                    {
                        vmax = numsh_1;
                    }
                    else if (numsh_1 > 2)
                    {
                        vmax = 2.2 * numsh_1;
                    }
                }
            double JJ;
            double[] JJJS = new double[Init.n];
            double JJSUM = 0;
                for (int i = 0; i < PDKS.Length; i++)
            {
                JJ = cmaxs[i] / PDKS[i];
                JJJS[i] = JJ;
                JJSUM += JJ;
            }
            JJS = JJJS;
            vmax = Math.Round(vmax, 3, MidpointRounding.AwayFromZero);
            xmax = Math.Round(xmax, 3, MidpointRounding.AwayFromZero);
            JJSUM = Math.Round(JJSUM, 3, MidpointRounding.AwayFromZero);
            ansvmax.Text = vmax.ToString();
            ansxmax.Text = xmax.ToString();
            Jsum.Text = JJSUM.ToString();
            if (deltaT_1 <= 0)
            {
                textBox1.Text = "Холодный";
                GTEMP = "Холодный";

            }
            else
            {
                textBox1.Text = "Горячий";
                GTEMP = "Горячий";
            }
            gcmaxes = cmaxs;
            GJJSUM = JJSUM;
            GVmax = vmax;
            GXmax = xmax;
            

        }


        

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
            /*
            String typmes = "Проверьте, что значение введено с использованием ',', а не '.' (За помощью обращайтесь в раздел помощь)";
            double PDK_1 = 0;
            double F_1 = 0;
            double temp_subs_1 = 0;
            double temp_env_1 = 0;
            double V1 = 0;
            double D = 0;
            double H = 0;
            double A = 0;
            double M = 0;
            double PDK_2 = 0;
            double M_2 = 0;
            double cmax,cmax2, deltaT_1, ff_1, fe_1, num_1, numsh_1, vo_1;
            bool[] ifready = new bool[11];
            const double pi = 3.14;
            F_1 = 0;
            double dd = 0;
            double n = 0;
            try 
            {
                PDK_1 = double.Parse(PDK.Text);
                ifready[1] = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в ПДК первого вещества. " + typmes);
                ifready[1] = false;
            }
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                
                F_1 = 1;
                ifready[0] = true;
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
               
                F_1 = 2;
                ifready[0] = true;
            }
            else
            {
                MessageBox.Show("Необходимо отметить либо газ либо твердое вещество");
                F_1 = 0;
                ifready[0] = false;
            }
            try
            {
                temp_subs_1 = double.Parse(Temp_subs.Text);
                ifready[2] = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в температуре выброса. " + typmes);
                ifready[2] = false;
            }

            try
            {
                temp_env_1 = double.Parse(Temp_env.Text);
                ifready[3] = true;
            } catch(Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в температуре воздуха. " + typmes);
                ifready[3] = false;
            }

            try
            {
                V1 = double.Parse(VV1.Text);
                ifready[4] = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в V1. " + typmes);
                ifready[4] = false;
            }
            try
            {
                D = double.Parse(D1.Text);
                ifready[5] = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в D. " + typmes);
                ifready[5] = false;
            }
            try
            {
                A = double.Parse(A1.Text);
                ifready[6] = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в A. " + typmes);
                ifready[6] = false;
            }
            try
            {
                H = double.Parse(H1.Text);
                ifready[7] = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в H. " + typmes);
                ifready[7] = false;
            }
            try
            {
                M = double.Parse(M1.Text);
                ifready[8] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в M первого вещества. " + typmes);
                ifready[8] = false;
            }
            try
            {
                PDK_2 = double.Parse(PDK2.Text);
                ifready[9] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в ПДК второго вещества. " + typmes);
                ifready[9] = false;
            }
            try
            {
                M_2 = double.Parse(MMM2.Text);
                ifready[10] = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в M второго вещества. " + typmes);
                ifready[10] = false;
            } 
            deltaT_1 = temp_subs_1 - temp_env_1;
            vo_1 = V1 / (pi*D*D/4);

            ff_1 = 1000 * (vo_1 * vo_1 * D) / (H * H * deltaT_1);
            num_1 = 0.65 * Math.Pow(V1 * deltaT_1/H, (double)1/3);
            numsh_1 = 1.3 * ((vo_1 * D) / H);
            fe_1 = 800 * Math.Pow(numsh_1, 3);
            if (ff_1 < 100)
            {
                if (num_1 >= 2)
                {
                    n = 1;
                }
                else if (num_1 < 0.5)
                {
                    n = 4.4 * num_1;
                }
                else if (num_1 < 2 && num_1 >= 0.5)
                {
                    n = (0.532 * num_1 * num_1) - (2.13 * num_1) + 3.13;
                }
            } else if (ff_1 >= 100)
            {
                if (numsh_1 >= 2)
                {
                    n = 1;
                }
                else if (numsh_1 < 0.5)
                {
                    n = 4.4 * numsh_1;
                }
                else if (numsh_1 < 2 && numsh_1 >= 0.5)
                {
                    n = (0.532 * numsh_1 * numsh_1) - (2.13 * numsh_1) + 3.13;
                }
            }
            //cmax calculation

            if ((ff_1 >= 100 || (deltaT_1 > 0 && deltaT_1 < 0.5)) && numsh_1 >= 0.5)
            {
                double k =  (double) D / (8 * V1);
                cmax = ((double)(A * M * F_1 * n) / Math.Pow(H, (double)4 / 3)) * k;
                cmax2 = ((double) (A * M_2 * F_1 * n) / Math.Pow(H, (double)4 / 3)) * k;
            }
            else
            {
                double m = 0;
                if (ff_1 < 100)
                {
                    m = (double)1 / (0.67 + 0.1 * Math.Sqrt(ff_1) + 0.34 * Math.Pow(ff_1, (double)1 / 3));
                }
                else if (ff_1 >= 100)
                {
                    m = (double)1.47 / (Math.Pow(ff_1, (double)1 / 3));
                }
                else if (fe_1 < ff_1 && ff_1 < 100)
                {
                    m = (double)1 / (0.67 + 0.1 * Math.Sqrt(fe_1) + 0.34 * Math.Pow(fe_1, (double)1 / 3));
                }
                cmax = (double)(A * M * F_1 * m * n) / (H * H * Math.Pow((V1 * deltaT_1), (double)1 / 3));
                cmax2 = (double)(A * M_2 * F_1 * m * n) / (H * H * Math.Pow((V1 * deltaT_1), (double)1 / 3));
            }
            
            //vmax and xmax calculation
            if (ff_1 < 100)
            {
                if (num_1 <= 0.5)
                {
                    dd = 2.48 * (1 + 0.28 * Math.Pow(fe_1, (double)1 / 3));
                } else if (0.5 < num_1 && num_1 <= 2)
                {
                    dd = 4.95 * num_1 * (1 + 0.28 * Math.Pow(ff_1,(double) 1 / 3));
                } else if (num_1 > 2)
                {
                    dd = 7 * Math.Sqrt(num_1) * (1 + 0.28 * Math.Pow(ff_1, (double)1 / 3));
                }
            } else if (ff_1 >= 100)
            {
                if (numsh_1 <= 0.5)
                {
                    dd = 5.7;
                } else if (0.5 < numsh_1 && numsh_1 <= 2)
                {
                    dd = 11.4 * numsh_1;
                } else if (numsh_1 > 2)
                {
                    dd = 16 * Math.Sqrt(numsh_1);
                }
            }
            double xmax = (((5 - F_1) / 4) * (dd * H));
            double vmax = 0;
            if (ff_1 < 100)
            {
                if (num_1 <= 0.5)
                {
                    vmax = 0.5;
                } else if (0.5 < num_1 && num_1 <= 2)
                {
                    vmax = num_1;
                } else if (num_1 > 2)
                {
                    vmax = num_1 * (1 + 0.12 * Math.Sqrt(ff_1));
                }
            } else if (ff_1 >= 100)
            {
                if (numsh_1 <= 0.5)
                {
                    vmax = 0.5;
                } else if (0.5 < numsh_1 && numsh_1 <= 2)
                {
                    vmax = numsh_1;
                } else if (numsh_1 > 2)
                {
                    vmax = 2.2 * numsh_1;
                }
            }
            
            double JJ1, JJ2, JJSUM;
            JJ1 = cmax / PDK_1;
            JJ2 = cmax2 / PDK_2;
            JJSUM = JJ1 + JJ2;
            bool ifallgood = true;
            for (int i = 0; i < ifready.Length; i++)
            {
                if (ifready[i] == false)
                {
                    ifallgood = false;
                }
            }
            if (ifallgood) { 
            ansvmax.Text = vmax.ToString();
            ansxmax.Text = xmax.ToString();
            anscmax1.Text = cmax.ToString();
            anscmax2.Text = cmax2.ToString();
            J1.Text = JJ1.ToString();
            J2.Text = JJ2.ToString();
            Jsum.Text = JJSUM.ToString();
            if (deltaT_1 <= 0)
            {
                textBox1.Text = "Холодный";

            }
            else
            {
                textBox1.Text = "Горячий";
            }
            }
            */

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void PDK_TextChanged(object sender, EventArgs e)
        {
            
        }
            private void Ansxmax_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            About about = new About();
            var dialogResult = about.ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            var dialogResult = help.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string texttowr = "";
            for (int i = 0; i < Init.n; i++)
            {
                texttowr += "Cmax " + (i + 1) + ": " + gcmaxes[i] + ", " + "Индекс загрязнения атмосферы " + (i+1) + " вещества: " + JJS[i] + Environment.NewLine;
            }
            string path = Application.StartupPath + "/full_contamination_info.txt";
            texttowr += "Суммарный индекс загрязнений: " + GJJSUM + Environment.NewLine;
            texttowr += "Xmax: " + GXmax + Environment.NewLine;
            texttowr += "Vmax: " + GVmax + Environment.NewLine;
            texttowr += "Температурная характеристика источника: " + GTEMP + Environment.NewLine;



            File.WriteAllText(path, texttowr);
            Process.Start("notepad.exe", "full_contamination_info.txt");

        }
    }
}

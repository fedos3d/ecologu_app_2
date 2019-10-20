using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecology_2
{
    public partial class unchang : Form
    {
        public static double deltaT, VV, DD,HH, AA, FF;

        private void Button2_Click(object sender, EventArgs e)
        {
            About about = new About();
            var dialogResult = about.ShowDialog();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            var dialogResult = help.ShowDialog();
        }

        public unchang()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String typmes = "Проверьте, что значение введено с использованием ',', а не '.' (За помощью обращайтесь в раздел помощь)";

            double deltaT_1;
            double F_1 = 0;
            double temp_subs_1 = 0;
            double temp_env_1 = 0;
            double V1 = 0;
            double D = 0;
            double H = 0;
            double A = 0;
            
            bool[] ifready = new bool[7];
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
                ifready[1] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в температуре выброса. " + typmes);
                ifready[1] = false;
            }

            try
            {
                temp_env_1 = double.Parse(Temp_env.Text);
                ifready[2] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в температуре воздуха. " + typmes);
                ifready[2] = false;
            }

            try
            {
                V1 = double.Parse(VV1.Text);
                ifready[3] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в V1. " + typmes);
                ifready[3] = false;
            }
            try
            {
                D = double.Parse(D1.Text);
                ifready[4] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в D. " + typmes);
                ifready[4] = false;
            }
            try
            {
                A = double.Parse(A1.Text);
                ifready[5] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в A. " + typmes);
                ifready[5] = false;
            }
            try
            {
                H = double.Parse(H1.Text);
                ifready[6] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в H. " + typmes);
                ifready[6] = false;
            }
            bool ifallgood = true;
            for (int i = 0; i < ifready.Length; i++)
            {
                if (ifready[i] == false)
                {
                    ifallgood = false;
                }
            }
            deltaT_1 = temp_subs_1 - temp_env_1;
            unchang.deltaT = deltaT_1;
            unchang.AA = A;
            unchang.DD = D;
            unchang.HH = H;
            unchang.FF = F_1;
            unchang.VV = V1;
            if (ifallgood) {
                Form1 from1 = new Form1();
                this.Hide();
                from1.ShowDialog();

                this.Close();
            } 
        }
    }
}

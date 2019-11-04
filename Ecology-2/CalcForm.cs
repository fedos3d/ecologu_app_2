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
    public partial class CalcForm : Form
    {
        int n;
        public CalcForm(int n)
        {
            InitializeComponent();
            int toshow = n + 1;
            textBox3.Text = toshow.ToString();
            this.n = n;
            if (n == Init.n - 1)
            {
                button4.Text = "Заверишить подсчет";
            }
        }

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

        private void Button4_Click(object sender, EventArgs e)
        {
            String typmes = "Проверьте, что значение введено с использованием ',', а не '.' (За помощью обращайтесь в раздел помощь)";
            double M = 0;
            double PDK = 0;
            bool ifPDK = false;
            bool ifM = false;
            bool readytogo = true;
            
            if (string.IsNullOrWhiteSpace(CurPDK.Text))
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    int m = comboBox1.SelectedIndex;
                    if (m == 0)
                    {
                        PDK = 0.04;
                    }
                    else if (m == 1)
                    {
                        PDK = 0.05;
                    }
                    else if (m == 2)
                    {
                        PDK = 3;
                    }
                    else if (m == 3)
                    {
                        PDK = 0.005;
                    }
                    else if (m == 4)
                    {
                        PDK = 0.06;
                    }
                    else if (m == 5)
                    {
                        PDK = 0.15;
                    }
                    readytogo = true;
                    ifPDK = true;
                } else
                {
                    readytogo = false;
                    ifPDK = false;
                    MessageBox.Show("Вы не выбрали ПДК!");
                }
                
            } else 
            {
                try
                {
                    PDK = double.Parse(CurPDK.Text);
                    ifPDK = true;
                    readytogo = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Вы ввели что-то неправильное в ПДК вещества. " + typmes);
                    ifPDK = false;
                    readytogo = false;
                }
            } 
            
            try
            {
                M = double.Parse(CurM.Text);
                ifM = true;
            } catch (Exception ex)
            {
                MessageBox.Show("Вы ввели что-то неправильное в M вещества. " + typmes);
                ifM = false;
            }
            if (ifPDK && ifM && readytogo)
            {
                Form1.PDKS[n] = PDK;
                Form1.MS[n] = M;
                this.Close();
            }
        }
    }
}

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
    public partial class Init : Form
    {   

        public static int n = 0;
        public Init()
        {
            InitializeComponent();
        }

        private void Init_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int nn = 0;
            bool gtg = false;
            try
            {
                nn = int.Parse(loles.Text);
            } catch(Exception ex)
            {
                MessageBox.Show("Ошибочка");
            }
            if (nn < 1)
            {
                MessageBox.Show("Нельзя ввести число меньше 1");
            }
            else
            {
                gtg = true;

            }
            if (gtg)
            {
                Init.n = nn;
                
                unchang kek = new unchang();
                this.Hide();
                kek.ShowDialog();
                
                this.Close();
            }
        }
    }
}

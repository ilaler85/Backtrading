using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Back
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int ris1 = 1, ris2 = 1;
        public bool check(int v1, int v2)
        {
            bool ook = false;
            do
            {
                if ((Math.Abs(v1 - v2) % ris1 == 1) || (Math.Abs(v1 - v2) % ris2 == 1))
                {
                    ook = true;
                }
                else
                {
                    if ((v1 + v2 == 99 || (v1 + v2) % ris1 == 1 || (v1 + v2) % ris2 == 1)&&(v1+v2<=100))
                    {
                        ook = true;
                    }
                    else
                    {
                        v2 += ris2;
                    }
                }
            } while (v2 > 100 && (!ook));
            if (v1 != 100 && !ook)
            {
                if (v1 + ris1 > 100)
                {
                    ook = check(100, 0);
                }
                else
                {
                    ook = check( v1 + ris1, 0);
                }
            }
            return ook;
        }

        public bool proverka(string tmp, ref int a)
        {
            return int.TryParse(tmp, out a);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(proverka(riska.Text,ref ris1)&& proverka(riska2.Text, ref ris2))
            {
                if (check(ris1, 0))
                {
                    MessageBox.Show("Можно перелить 1 мл в 3 пробирку");
                }
                else
                {
                    MessageBox.Show("Нельзя перелить 1 мл в 3 пробирку");
                }
            }
            else
            {
                MessageBox.Show("У вас беды с целыми числами");
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("29. Задача о пробирках. Даны три пробирки объемом 100 мл. Две из них имеют шкалу рисок. Уровни рисок указываются пользователем. Из начального состояния { 100мл, 0мл, 0мл} (в первой пробирке 100мл, а две другие пусты) определить, возможен ли переход путем переливания жидкости из одной пробирки в другую в состояние { _, _, 1мл} (в пробирках с рисками— произвольное количество миллилитров, а в пробирке без рисок— 1мл).");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

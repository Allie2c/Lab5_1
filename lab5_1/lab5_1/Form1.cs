using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_1
{
    public partial class Form1 : Form
    {
        private int totalOrderAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int tsuivan, shul, buuz, huushuur, tsuivan_hagas, shul_hagas;
        int salad1, salad2, salad3;

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton_tsuivan.Checked || checkBox_shul.Checked || checkBox_shulahagas.Checked || checkBox_buuz.Checked || checkBox_huushuur.Checked|| checkBox_salad1.Checked || checkBox_salad2.Checked || checkBox_salad3.Checked)
            {
                tsuivan = 5000;
                shul_hagas = 2750;
                shul = 5500;
                buuz = 1500;
                huushuur = 1600;

                salad1 = 1000;
                salad2 = 2000;
                salad3 = 3000;

                int une;
                une = tsuivan + shul + buuz;
                String une1 = une.ToString();
                unetxt.Text = une1;
                une = huushuur + shul + buuz;
                String une2 = une.ToString();
                unetxt.Text = une2;
                une = shul_hagas + tsuivan + buuz;
                String une3 = une.ToString();
                unetxt.Text = une3;

            }
            
            if (radioButton_tsuivanhagas.Checked || checkBox_shul.Checked || checkBox_shulahagas.Checked || checkBox_buuz.Checked || checkBox_huushuur.Checked || checkBox_salad1.Checked || checkBox_salad2.Checked || checkBox_salad3.Checked)
            {
                tsuivan_hagas = 5000;
                shul = 5500;
                buuz = 1500;
                huushuur = 1600;

                salad1 = 1000;
                salad2 = 2000;
                salad3 = 3000;

            }

        }
    }
}

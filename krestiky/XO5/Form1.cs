using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO5
{
    public partial class Form1 : Form
    {
        double player = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    label1.Text = "Текущий ход: Игрок 2";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    label1.Text = "Текущий ход: Игрок 1";
                    break;

            }
            Win();


        }
        private void button_10Click(object sender, EventArgs e)
        {


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Visible = false;
            button10.Enabled = false;
            label1.Text = "Текущий ход: Игрок 1";
            
        }
        private void button_11Click(object sender, EventArgs e)
        {
            player = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Visible = true;
            button10.Enabled = true;

            button1.Text="";
            button2.Text="";
            button3.Text="";
            button4.Text="";
            button5.Text="";
            button6.Text="";
            button7.Text="";
            button8.Text="";
            button9.Text="";

        }

        void Win()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text!="")
                MessageBox.Show("Победа");
            if (button4.Text == button5.Text && button5.Text == button6.Text&& button4.Text!="")
                MessageBox.Show("Победа");
            if (button7.Text == button8.Text && button8.Text == button9.Text&& button7.Text!="")
                MessageBox.Show("Победа");
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
                MessageBox.Show("Победа");
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
                MessageBox.Show("Победа");
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
                MessageBox.Show("Победа");
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
                MessageBox.Show("Победа");
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
                MessageBox.Show("Победа");
        }
    }
}

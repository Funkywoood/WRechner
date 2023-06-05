using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Währungsumrechner
{
    public partial class Form1 : Form
    {
        public Form2 f2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double currency;

            if (radioButton1.Checked)
                try
                {
                    {
                        currency = Convert.ToDouble(textBox1.Text);
                        currency = currency * 1.02;
                        label2.Text = Math.Round(currency, 2) + " Euro";  //begrenzt auf 2 Nachkomma-Stellen
                        //label2.Text = Convert.ToString(currency) + " Euro";
                        label3.Text = " CHF";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "  Hahahaha!!");
                }

            else if (radioButton2.Checked)
            {
                currency = Convert.ToDouble(textBox1.Text);
                currency = currency * 1.12;
                label2.Text = Math.Round(currency, 2) + " USD";
                //label2.Text = Convert.ToString(currency) + " BRL";
                label3.Text = " CHF";
            }



            else if (radioButton3.Checked)
            {
                currency = Convert.ToDouble(textBox1.Text);
                currency = currency * 5.51;
                label2.Text = Math.Round(currency, 0) + " BRL";
                //label2.Text = Convert.ToString(currency) + " BRL";
                label3.Text = " CHF";
            }

            else if (radioButton4.Checked)
            {
                currency = Convert.ToDouble(textBox1.Text);
                currency = currency * 0.000037;
                label2.Text = Math.Round(currency, 6) + " BTC";
                //label2.Text = Convert.ToString(currency) + " BTC";
                label3.Text = " CHF";
            }
            else if (radioButton5.Checked)
            {
                currency = Convert.ToDouble(textBox1.Text);
                currency = currency / 1.02;
                label2.Text = Math.Round(currency, 2) + " CHF";
                //label2.Text = Convert.ToString(currency) + " CHF";
                label3.Text = " Euro";
            }
            else if (radioButton6.Checked)
            {
                currency = Convert.ToDouble(textBox1.Text);
                currency = currency / 1.12;
                label2.Text = Math.Round(currency, 2) + " CHF";
                //label2.Text = Convert.ToString(currency) + " CHF";
                label3.Text = " USD";
            }
            else if (radioButton7.Checked)
            {
                currency = Convert.ToDouble(textBox1.Text);
                currency = currency / 5.51;
                label2.Text = Math.Round(currency, 0) + " CHF";
                //label2.Text = Convert.ToString(currency) + " CHF";
                label3.Text = " BRL";
            }
            else if (radioButton8.Checked)
            {
                currency = Convert.ToDouble(textBox1.Text);
                currency = currency / 0.000037;
                label2.Text = Math.Round(currency, 0) + " CHF";
                //label2.Text = Convert.ToString(currency) + " CHF";
                label3.Text = " BTC";
            }


           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f2.Show();
        }
    }

}


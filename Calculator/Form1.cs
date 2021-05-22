using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ifscreenClear;
        private int _First, _Second, _sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhabalar hoşgeldiniz", "Copyright © Ayrz");
        }





        private void sayi2_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "2";
            }
            else
            {
                ekran.Text += "2";
            }
        }

        private void sayi4_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "4";
            }
            else
            {
                ekran.Text += "4";
            }
        }

        private void sayi5_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "5";
            }
            else
            {
                ekran.Text += "5";
            }
        }

        private void sayi8_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "8";
            }
            else
            {
                ekran.Text += "8";
            }
        }

        private void sayi6_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "6";
            }
            else
            {
                ekran.Text += "6";
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sayi1_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "1";
            }
            else
            {
                ekran.Text += "1";
            }
        }

        private void temizle_Click(object sender, EventArgs e)
        {

            ekran.Text = "0";


        }

        private void sayi3_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "3";
            }
            else
            {
                ekran.Text += "3";
            }
        }

        private void sayi7_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "7";
            }
            else
            {
                ekran.Text += "7";
            }


        }

        private void sayi0_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "0";
            }
            else
            {
                ekran.Text += "0";
            }


        }

        private void sayi9_Click(object sender, EventArgs e)
        {
            if (_ifscreenClear)
            {
                ekran.Text = "";
                _ifscreenClear = false;
            }

            if (ekran.Text == "0")
            {
                ekran.Text = "9";
            }
            else
            {
                ekran.Text += "9";
            }


        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ifscreenClear = true;
            _First = Convert.ToInt32(ekran.Text);
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ifscreenClear = true;
            _First = Convert.ToInt32(ekran.Text);
        }

        private void sonuc_Click(object sender, EventArgs e)
        {
            _Second = Convert.ToInt32(ekran.Text);

            switch (_islem)
            {
                case '+':
                    _sonuc = _First + _Second;
                    break;
                case '-':
                    _sonuc = _First - _Second;
                    break;
                case '*':
                    _sonuc = _First * _Second;
                    break;
                case '/':
                    _sonuc = _First / _Second;
                    break;
                default:
                    _sonuc = 0;
                    break;
            }

            ekran.Text = Convert.ToString(_sonuc);
        }

       

        private void bolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ifscreenClear = true;
            _First = Convert.ToInt32(ekran.Text);
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ifscreenClear = true;
            _First = Convert.ToInt32(ekran.Text);
        }

   
        private void remove_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToDouble(ekran.Text) > 0)
            {
                ekran.Text = ekran.Text.Remove(ekran.Text.Length - 1, 1);
                if (ekran.Text.Length == 0)
                {
                    ekran.Text = "0";
                }
            }
        }

        
    }
}

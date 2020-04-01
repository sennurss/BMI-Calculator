using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoyKiloIndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {

            try
            {

            

            double boy = Convert.ToDouble(textBoxBoy.Text);
            int kilo = Convert.ToInt32(textBoxKilo.Text);
            double oran = kilo / (boy / 100 * boy / 100);
            labelDeger.Text = Convert.ToString(oran);


                if (oran <= 15)
                {
                    labelSonuc.Text = "Aşırı Düzeyde Zayıfsınız";
                }

                

                else if (oran <= 18.5)
                {
                    labelSonuc.Text = "Hafif Düzeyde Zayıfsınız";
                }

                else if (oran <= 25)
                {
                    labelSonuc.Text = "Normalsiniz";
                }

                else if (oran <= 30)
                {
                    labelSonuc.Text = "Fazla Kilolusunuz";
                }

                else if (oran <= 35)
                {
                    labelSonuc.Text = "Birinci Derece Obesiniz";
                }

                else if (oran <= 40)
                {
                    labelSonuc.Text = "İkinci Derece Obesiniz";
                }

               else if (oran > 40)
                {
                    labelSonuc.Text = "Üçüncü Derece Obesiniz";
                }

                
            }

            

            catch (Exception)
            {

               MessageBox.Show("Lütfen kutulara sayısal değer giriniz");
            }

            

        }
    }
}

/****************************************************************************           
			Name:...HONEST ALBERT TEMU.........                         
                          
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ödev3
{
    public partial class Form1 : Form
    {
        int adet1;
        int adet2;
        int adet3;
        int adet4;

        double amount1;
        double amount2;
        double amount3;
        double amount4;

        public Form1()
        {
            InitializeComponent();

            Random StokAdedi = new Random();

            adet1 = StokAdedi.Next(1, 100);
            label16.Text =adet1.ToString();

            adet2 = StokAdedi.Next(1, 100);
            label15.Text = adet2.ToString();

            adet3 = StokAdedi.Next(1, 100);
            label19.Text = adet3.ToString();

            adet4 = StokAdedi.Next(1, 100);
            label20.Text = adet4.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // retrieve user input
            int tvNo = Convert.ToInt32(tvSayisi.Value);
            int buzdolabiNo = Convert.ToInt32(buzdolabiSayisi.Value);
            int telefonNo = Convert.ToInt32(telefonSayisi.Value);
            int pcNo = Convert.ToInt32(pcSayisi.Value);

            //adds retrieved values to the listbox
            adetKutusu.Items.Add(tvNo);
            adetKutusu.Items.Add(buzdolabiNo);
            adetKutusu.Items.Add(pcNo);
            adetKutusu.Items.Add(telefonNo);

            //assigns items names on the lisbox
            urunKutusu.Items.Add("Led Tv");
            urunKutusu.Items.Add("Buzdolabı");
            urunKutusu.Items.Add("Bilgisayar");
            urunKutusu.Items.Add("Cep telefonu");

            //declare variables to store user input

            if (tvNo<1)
            {
                amount1 = 0;
            }
            else
             amount1 = tvNo * (4000+(4000 *(0.18)));

            if (buzdolabiNo < 1)
            {
                amount2 = 0;
            }
            else
             amount2 = buzdolabiNo * (3500+(3500 * (0.05)));

            if (pcNo < 1)
            {
                amount3 = 0;
            }
            else
              amount3 = pcNo * (6000 +(6000 * (0.15)));

            if (telefonNo < 1)
            {
                amount4= 0;
            }
            else
             amount4 = telefonNo * (2500 +(2500 * (0.20)));


            //assigns values obtained in a lisbox
            fiyatKutusu.Items.Add(amount1);
            fiyatKutusu.Items.Add(amount2);
            fiyatKutusu.Items.Add(amount3);
            fiyatKutusu.Items.Add(amount4);

            label16.Text = (adet1 - tvNo).ToString();
            label15.Text = (adet2 - buzdolabiNo).ToString();
            label19.Text = (adet3 - pcNo).ToString();
            label20.Text = (adet4 - telefonNo).ToString();



            //calculate amount of the total amount after items are added on the listbox
            decimal toplam = 0;
            for (int i = 0; i < fiyatKutusu.Items.Count; i++)
            {
                toplam += Convert.ToDecimal(fiyatKutusu.Items[i]);
            }
             label26.Text=Convert.ToString(toplam);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //resets the number of items selected to 0
            tvSayisi.Text = "0";
            pcSayisi.Text = "0";
            buzdolabiSayisi.Text = "0";
            telefonSayisi.Text = "0";

            //clears all the selected values to 0
            adetKutusu.Items.Clear();
            urunKutusu.Items.Clear();
            fiyatKutusu.Items.Clear();

        }

       
    }
    
}

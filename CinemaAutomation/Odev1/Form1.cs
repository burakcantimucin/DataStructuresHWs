using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 60; i >= 1; i--)
                LinkedList.InsertFirst(0);
        }

        LinkedList LinkedList = new LinkedList();
        int[] DoluKoltuklar = new int[60];
        bool BiletAlindiMi = true;
        int SecilenBiletler = 0;

        private void btnSalonKoltuklariGuncelle_Click(object sender, EventArgs e)
        {
            int Sayac = 0;
            btnKoltuk1.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk2.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk3.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk4.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk5.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk6.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk7.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk8.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk9.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk10.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk11.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk12.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk13.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk14.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk15.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk16.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk17.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk18.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk19.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk20.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk21.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk22.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk23.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk24.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk25.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk26.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk27.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk28.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk29.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk30.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk31.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk32.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk33.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk34.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk35.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk36.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk37.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk38.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk39.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk40.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk41.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk42.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk43.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk44.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk45.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk46.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk47.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk48.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk49.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk50.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk51.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk52.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk53.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk54.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk55.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk56.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk57.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk58.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk59.BackColor = System.Drawing.Color.YellowGreen;
            btnKoltuk60.BackColor = System.Drawing.Color.YellowGreen;
            for (int i = 0; i < SecilenBiletler+1; i++)
            {
                if (DoluKoltuklar[i] == 1)
                    btnKoltuk1.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 2)
                    btnKoltuk2.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 3)
                    btnKoltuk3.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 4)
                    btnKoltuk4.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 5)
                    btnKoltuk5.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 6)
                    btnKoltuk6.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 7)
                    btnKoltuk7.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 8)
                    btnKoltuk8.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 9)
                    btnKoltuk9.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 10)
                    btnKoltuk10.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 11)
                    btnKoltuk11.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 12)
                    btnKoltuk12.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 13)
                    btnKoltuk13.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 14)
                    btnKoltuk14.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 15)
                    btnKoltuk15.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 16)
                    btnKoltuk16.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 17)
                    btnKoltuk17.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 18)
                    btnKoltuk18.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 19)
                    btnKoltuk19.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 20)
                    btnKoltuk20.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 21)
                    btnKoltuk21.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 22)
                    btnKoltuk22.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 23)
                    btnKoltuk23.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 24)
                    btnKoltuk24.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 25)
                    btnKoltuk25.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 26)
                    btnKoltuk26.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 27)
                    btnKoltuk27.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 28)
                    btnKoltuk28.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 29)
                    btnKoltuk29.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 30)
                    btnKoltuk30.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 31)
                    btnKoltuk31.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 32)
                    btnKoltuk32.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 33)
                    btnKoltuk33.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 34)
                    btnKoltuk34.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 35)
                    btnKoltuk35.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 36)
                    btnKoltuk36.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 37)
                    btnKoltuk37.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 38)
                    btnKoltuk38.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 39)
                    btnKoltuk39.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 40)
                    btnKoltuk40.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 41)
                    btnKoltuk41.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 42)
                    btnKoltuk42.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 43)
                    btnKoltuk43.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 44)
                    btnKoltuk44.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 45)
                    btnKoltuk45.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 46)
                    btnKoltuk46.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 47)
                    btnKoltuk47.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 48)
                    btnKoltuk48.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 49)
                    btnKoltuk49.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 50)
                    btnKoltuk50.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 51)
                    btnKoltuk51.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 52)
                    btnKoltuk52.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 53)
                    btnKoltuk53.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 54)
                    btnKoltuk54.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 55)
                    btnKoltuk55.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 56)
                    btnKoltuk56.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 57)
                    btnKoltuk57.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 58)
                    btnKoltuk58.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 59)
                    btnKoltuk59.BackColor = System.Drawing.Color.Red;
                if (DoluKoltuklar[i] == 60)
                    btnKoltuk60.BackColor = System.Drawing.Color.Red;
            }
            for (int i = 0; i < 60; i++)
            {
                if (DoluKoltuklar[i] == 1)
                    Sayac++;
                if (DoluKoltuklar[i] == 2)
                    Sayac++;
                if (DoluKoltuklar[i] == 3)
                    Sayac++;
                if (DoluKoltuklar[i] == 4)
                    Sayac++;
                if (DoluKoltuklar[i] == 5)
                    Sayac++;
                if (DoluKoltuklar[i] == 6)
                    Sayac++;
                if (DoluKoltuklar[i] == 7)
                    Sayac++;
                if (DoluKoltuklar[i] == 8)
                    Sayac++;
                if (DoluKoltuklar[i] == 9)
                    Sayac++;
                if (DoluKoltuklar[i] == 10)
                    Sayac++;
                if (DoluKoltuklar[i] == 11)
                    Sayac++;
                if (DoluKoltuklar[i] == 12)
                    Sayac++;
                if (DoluKoltuklar[i] == 13)
                    Sayac++;
                if (DoluKoltuklar[i] == 14)
                    Sayac++;
                if (DoluKoltuklar[i] == 15)
                    Sayac++;
                if (DoluKoltuklar[i] == 16)
                    Sayac++;
                if (DoluKoltuklar[i] == 17)
                    Sayac++;
                if (DoluKoltuklar[i] == 18)
                    Sayac++;
                if (DoluKoltuklar[i] == 19)
                    Sayac++;
                if (DoluKoltuklar[i] == 20)
                    Sayac++;
                if (DoluKoltuklar[i] == 21)
                    Sayac++;
                if (DoluKoltuklar[i] == 22)
                    Sayac++;
                if (DoluKoltuklar[i] == 23)
                    Sayac++;
                if (DoluKoltuklar[i] == 24)
                    Sayac++;
                if (DoluKoltuklar[i] == 25)
                    Sayac++;
                if (DoluKoltuklar[i] == 26)
                    Sayac++;
                if (DoluKoltuklar[i] == 27)
                    Sayac++;
                if (DoluKoltuklar[i] == 28)
                    Sayac++;
                if (DoluKoltuklar[i] == 29)
                    Sayac++;
                if (DoluKoltuklar[i] == 30)
                    Sayac++;
                if (DoluKoltuklar[i] == 31)
                    Sayac++;
                if (DoluKoltuklar[i] == 32)
                    Sayac++;
                if (DoluKoltuklar[i] == 33)
                    Sayac++;
                if (DoluKoltuklar[i] == 34)
                    Sayac++;
                if (DoluKoltuklar[i] == 35)
                    Sayac++;
                if (DoluKoltuklar[i] == 36)
                    Sayac++;
                if (DoluKoltuklar[i] == 37)
                    Sayac++;
                if (DoluKoltuklar[i] == 38)
                    Sayac++;
                if (DoluKoltuklar[i] == 39)
                    Sayac++;
                if (DoluKoltuklar[i] == 40)
                    Sayac++;
                if (DoluKoltuklar[i] == 41)
                    Sayac++;
                if (DoluKoltuklar[i] == 42)
                    Sayac++;
                if (DoluKoltuklar[i] == 43)
                    Sayac++;
                if (DoluKoltuklar[i] == 44)
                    Sayac++;
                if (DoluKoltuklar[i] == 45)
                    Sayac++;
                if (DoluKoltuklar[i] == 46)
                    Sayac++;
                if (DoluKoltuklar[i] == 47)
                    Sayac++;
                if (DoluKoltuklar[i] == 48)
                    Sayac++;
                if (DoluKoltuklar[i] == 49)
                    Sayac++;
                if (DoluKoltuklar[i] == 50)
                    Sayac++;
                if (DoluKoltuklar[i] == 51)
                    Sayac++;
                if (DoluKoltuklar[i] == 52)
                    Sayac++;
                if (DoluKoltuklar[i] == 53)
                    Sayac++;
                if (DoluKoltuklar[i] == 54)
                    Sayac++;
                if (DoluKoltuklar[i] == 55)
                    Sayac++;
                if (DoluKoltuklar[i] == 56)
                    Sayac++;
                if (DoluKoltuklar[i] == 57)
                    Sayac++;
                if (DoluKoltuklar[i] == 58)
                    Sayac++;
                if (DoluKoltuklar[i] == 59)
                    Sayac++;
                if (DoluKoltuklar[i] == 60)
                    Sayac++;
            }
            lblBosKoltukSayisi.Text = Convert.ToString(60 - Sayac);
            lblDoluKoltukSayisi.Text = Convert.ToString(Sayac);
        }

        private void btnSatinIslemiTamamla_Click(object sender, EventArgs e)
        {
            Seyirci Seyirci = new Seyirci();
            Seyirci.TCKimlikNo = Convert.ToDecimal(txtTCkimlikNo.Text);
            Seyirci.Ad = txtAd.Text;
            Seyirci.Soyad = txtSoyad.Text;
            Seyirci.KoltukNo = Convert.ToInt32(txtKoltukNo.Text);
            for (int i = 0; i < SecilenBiletler+1; i++)
            {
                if (DoluKoltuklar[i] == Seyirci.KoltukNo)
                {
                    MessageBox.Show("Bu koltuk daha önceden seçilmiştir.");
                    BiletAlindiMi = true;
                    break;
                }
                else
                {
                    BiletAlindiMi = false;
                }
            }
            if (BiletAlindiMi == false)
            {
                LinkedList.SeyirciEkle(Seyirci);
                LinkedList.DeletePos(Seyirci.KoltukNo);
                LinkedList.InsertPos(Seyirci.KoltukNo - 1, Seyirci);
                SecilenBiletler++;
                for (int j = 0; j < SecilenBiletler; j++)
                {
                    if ((SecilenBiletler - 1) == j)
                        DoluKoltuklar[SecilenBiletler - 1] = Seyirci.KoltukNo;
                }
            }
        }

        private void btnIptalIslemiTamamla_Click(object sender, EventArgs e)
        {
            int SecilmeyenKoltuk = 0; 
            for (int i = 0; i < SecilenBiletler + 1; i++)
            {
                if (DoluKoltuklar[i] == Convert.ToInt32(txtTCkimlikNo_Iptal.Text))
                {
                    BiletAlindiMi = false;
                    break;
                }
                else
                {
                    if (SecilmeyenKoltuk == SecilenBiletler)
                        MessageBox.Show("Bu koltuk daha önceden seçilmemiştir.");
                    BiletAlindiMi = true;
                    SecilmeyenKoltuk++;
                }
            }
            if (BiletAlindiMi == false)
            {
                LinkedList.DeletePos(Convert.ToInt32(txtTCkimlikNo_Iptal.Text));
                for (int i = 0; i < SecilenBiletler; i++)
                {
                    if (DoluKoltuklar[i] == Convert.ToInt32(txtTCkimlikNo_Iptal.Text))
                    {
                        for (int j = i; j < SecilenBiletler; j++)
                        {
                            DoluKoltuklar[i] = DoluKoltuklar[i + 1];
                        }
                        DoluKoltuklar[i + 1] = 0;
                    }
                }
                foreach (Seyirci item in LinkedList.Seyirciler)
                {
                    if (item.KoltukNo == Convert.ToInt32(txtTCkimlikNo_Iptal.Text))
                    {
                        LinkedList.SeyirciCikar(item);
                        break;
                    }
                }
                SecilenBiletler--;
            }
        }

        private void btnBiletSorgula_Click(object sender, EventArgs e)
        {
            String temp = LinkedList.GetElement(Convert.ToInt32(txtBiletSorgula.Text));
            MessageBox.Show("Müşteri Bilgileri" + Environment.NewLine + temp);
        }
    }
}

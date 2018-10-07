using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBankaIslemi_Click(object sender, EventArgs e)
        {
            DaireselKuyruk DaireselKuyruk = new DaireselKuyruk(20);
            DaireselKuyruk DaireselKuyruk2 = new DaireselKuyruk(20);
            OncelikliKuyruk OncelikliKuyruk = new OncelikliKuyruk(20);
            OncelikliKuyruk OncelikliKuyruk2 = new OncelikliKuyruk(20);
            OncelikliKuyruk tersOncelikliKuyruk = new OncelikliKuyruk(20);
            OncelikliKuyruk tersOncelikliKuyruk2 = new OncelikliKuyruk(20);
            Musteri Musteri = new Musteri();
            Musteri Musteri2 = new Musteri();
            Musteri Musteri3 = new Musteri();
            Musteri Musteri4 = new Musteri();
            Random Rastgele = new Random();
            int[] DaireselIslemTamamlamaSuresi = new int[20];
            int[] DaireselKuyruktaKalmaSuresi = new int[20];
            int[] OncelikliKuyruktaKalmaSuresi = new int[20];
            int[] OncelikliIslemTamamlamaSuresi = new int[20];
            int[] tersOncelikliKuyruktaKalmaSuresi = new int[20];
            int[] tersOncelikliIslemTamamlamaSuresi = new int[20];
            int DaireselBeklemeSuresi = 0, OncelikliBeklemeSuresi = 0;
            decimal DaireselBeklemeOrtalama = 0, OncelikliBeklemeOrtalama = 0;
            decimal IslemTamamlamaSuresiOrtalamasi = 0;
            for (int i = 0; i < 20; i++)
            {
                DaireselIslemTamamlamaSuresi[i] = Rastgele.Next(60, 600);
                DaireselBeklemeSuresi += DaireselIslemTamamlamaSuresi[i];
                OncelikliBeklemeSuresi += DaireselIslemTamamlamaSuresi[i];
                DaireselKuyruktaKalmaSuresi[i] = DaireselIslemTamamlamaSuresi[i];
                Musteri.IslemSuresi = DaireselBeklemeSuresi;
                Musteri.MusteriNo = i + 1;
                DaireselKuyruk.Insert(Musteri);
                Musteri2.IslemSuresi = DaireselIslemTamamlamaSuresi[i];
                Musteri2.MusteriNo = i + 1;
                DaireselKuyruk2.Insert(Musteri);
                Musteri3.IslemSuresi = DaireselIslemTamamlamaSuresi[i];
                Musteri3.MusteriNo = i + 1;
                OncelikliKuyruk.Insert(Musteri3);
                OncelikliKuyruk2.Insert(Musteri3);
                tersOncelikliKuyruk.Insert(Musteri3);
                tersOncelikliKuyruk2.Insert(Musteri3);
            }
            OncelikliBeklemeSuresi = 0;
            for (int i = 19; i > -1; i--)
            {
                OncelikliKuyruktaKalmaSuresi[i] = Convert.ToInt32(OncelikliKuyruk.Remove());
            }
            for (int i = 0; i < 20; i++)
            {
                int TersOncelikliKuyruk;
                TersOncelikliKuyruk = Convert.ToInt32(tersOncelikliKuyruk.Remove());
                tersOncelikliKuyruktaKalmaSuresi[i] += TersOncelikliKuyruk;
                tersOncelikliIslemTamamlamaSuresi[i] = Convert.ToInt32(tersOncelikliKuyruk2.Remove());
            }
            int ToplamOncelikliIslemTamamlama=0, OncelikliKuyruktaKalma;
            for (int i = 0; i < 20; i++)
            {
                OncelikliKuyruktaKalma = OncelikliKuyruktaKalmaSuresi[i];
                ToplamOncelikliIslemTamamlama += OncelikliKuyruktaKalma;
                OncelikliIslemTamamlamaSuresi[i] = ToplamOncelikliIslemTamamlama;
            }
            for (int i = 0; i < 20; i++)
            {
                OncelikliBeklemeSuresi += OncelikliKuyruktaKalmaSuresi[i];
                Musteri4.IslemSuresi = OncelikliBeklemeSuresi;
                Musteri4.MusteriNo = i + 1;
                OncelikliKuyruk.Insert(Musteri4);
            }
            MessageBox.Show("Dairesel Kuyruk Sonuçları");
            for (int i = 0; i < 20; i++)
            {
                DaireselIslemTamamlamaSuresi[i] = Convert.ToInt32(DaireselKuyruk.Remove());
                DaireselBeklemeSuresi = DaireselIslemTamamlamaSuresi[i];
                IslemTamamlamaSuresiOrtalamasi += DaireselIslemTamamlamaSuresi[i];
                MessageBox.Show(i+1 + ". müşterinin işlem tamamlanma süresi: " + DaireselBeklemeSuresi);
                DaireselBeklemeOrtalama = IslemTamamlamaSuresiOrtalamasi / 20;
                if (i == 19) MessageBox.Show("20 müşterinin ortalama işlem süresi: " + DaireselBeklemeOrtalama);
            }
            IslemTamamlamaSuresiOrtalamasi = 0;
            MessageBox.Show("Küçükten Büyüğe Sıralanmış Öncelikli Kuyruk Sonuçları");
            for (int i = 19; i > -1; i--)
            {
                OncelikliIslemTamamlamaSuresi[i] = Convert.ToInt32(OncelikliKuyruk2.Remove());
                IslemTamamlamaSuresiOrtalamasi += OncelikliIslemTamamlamaSuresi[i];
            }
            OncelikliBeklemeSuresi = 0;
            for (int i = 0; i < 20; i++)
            {
                OncelikliBeklemeSuresi += OncelikliIslemTamamlamaSuresi[i];
                MessageBox.Show(i + 1 + ". müşterinin işlem tamamlanma süresi: " + OncelikliBeklemeSuresi);
                OncelikliBeklemeOrtalama += OncelikliBeklemeSuresi;
                if (i == 19) MessageBox.Show("20 müşterinin ortalama işlem süresi: " + OncelikliBeklemeOrtalama / 20);
            }
            for (int i = 0; i < 20; i++)
            {
                double HerBirOncelikli, HerBirDairesel, Hesap, Verimlilik;
                HerBirOncelikli = Convert.ToDouble(OncelikliIslemTamamlamaSuresi[i]);
                HerBirDairesel = Convert.ToDouble(DaireselKuyruktaKalmaSuresi[i]);
                Hesap = HerBirOncelikli / HerBirDairesel;
                Verimlilik = (1 - Hesap) * 100;
                if (HerBirDairesel > HerBirOncelikli)
                    MessageBox.Show("Dairesel kuyruktaki " + (i + 1) + ". müşteri ile öncelikli kuyruktaki " + (i + 1) + ". müşteri arasındaki zaman farkı " + (HerBirDairesel - HerBirOncelikli) + Environment.NewLine +
                                    "Bu iki müşteri arasında kazançlı olan öncelikli kuyruktaki müşteridir.");
                else
                    MessageBox.Show("Dairesel kuyruktaki " + (i + 1) + ". müşteri ile öncelikli kuyruktaki " + (i + 1) + ". müşteri arasındaki zaman farkı " + (HerBirOncelikli - HerBirDairesel) + Environment.NewLine +
                                    "Bu iki müşteri arasında kazançlı olan dairesel kuyruktaki müşteridir.");
                if (i == 19)
                {
                    HerBirOncelikli = Convert.ToDouble(DaireselBeklemeOrtalama);
                    HerBirDairesel = Convert.ToDouble(OncelikliBeklemeOrtalama/20);
                    Hesap = HerBirDairesel / HerBirOncelikli;
                    Verimlilik = (1 - Hesap) * 100;
                    MessageBox.Show("Öncelikli ve dairesel kuyruktaki 20 müşteri ortalaması arasındaki zaman farkı " + (HerBirOncelikli - HerBirDairesel) + Environment.NewLine +
                                    "Verimlilik: %" + Verimlilik + Environment.NewLine +
                                    "Bu durumda küçükten büyüğe sıralı öncelikli kuyruğu kullanmak, dairesel kuyruğa göre daha kazançlıdır.");
                }
            }
            MessageBox.Show("Büyükten Küçüğe Sıralanmış Öncelikli Kuyruk Sonuçları");
            OncelikliBeklemeSuresi = 0;
            OncelikliBeklemeOrtalama = 0;
            for (int i = 0; i < 20; i++)
            {
                OncelikliBeklemeSuresi += tersOncelikliIslemTamamlamaSuresi[i];
                MessageBox.Show(i + 1 + ". müşterinin işlem tamamlanma süresi: " + OncelikliBeklemeSuresi);
                OncelikliBeklemeOrtalama += OncelikliBeklemeSuresi;
                if (i == 19) MessageBox.Show("20 müşterinin ortalama işlem süresi: " + OncelikliBeklemeOrtalama / 20);
            }
            for (int i = 0; i < 20; i++)
            {
                double HerBirTersOncelikli, HerBirDairesel, Hesap, Verimlilik;
                HerBirTersOncelikli = Convert.ToDouble(tersOncelikliIslemTamamlamaSuresi[i]);
                HerBirDairesel = Convert.ToDouble(DaireselKuyruktaKalmaSuresi[i]);
                Hesap = HerBirDairesel / HerBirTersOncelikli;
                Verimlilik = (1 - Hesap) * 100;
                if (HerBirDairesel > HerBirTersOncelikli)
                    MessageBox.Show("Dairesel kuyruktaki " + (i + 1) + ". müşteri ile öncelikli kuyruktaki " + (i + 1) + ". müşteri arasındaki zaman farkı " + (HerBirDairesel - HerBirTersOncelikli) + Environment.NewLine +
                                    "Bu iki müşteri arasında kazançlı olan öncelikli kuyruktaki müşteridir.");
                else
                    MessageBox.Show("Dairesel kuyruktaki " + (i + 1) + ". müşteri ile öncelikli kuyruktaki " + (i + 1) + ". müşteri arasındaki zaman farkı " + (HerBirTersOncelikli - HerBirDairesel) + Environment.NewLine +
                                    "Bu iki müşteri arasında kazançlı olan dairesel kuyruktaki müşteridir.");
                if (i == 19)
                {
                    HerBirTersOncelikli = Convert.ToDouble(DaireselBeklemeOrtalama);
                    HerBirDairesel = Convert.ToDouble(OncelikliBeklemeOrtalama / 20);
                    Hesap = HerBirTersOncelikli / HerBirDairesel;
                    Verimlilik = (1 - Hesap) * 100;
                    MessageBox.Show("Öncelikli ve dairesel kuyruktaki 20 müşteri ortalaması arasındaki zaman farkı " + (HerBirDairesel - HerBirTersOncelikli) + Environment.NewLine +
                                    "Verimlilik: %" + Verimlilik + Environment.NewLine +
                                    "Bu durumda dairesel kuyruğu kullanmak, büyükten küçüğe sıralı öncelikli kuyruğa göre daha kazançlıdır.");
                }
            }
        }
    }
}

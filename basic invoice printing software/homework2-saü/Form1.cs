
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2_saü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Text ve Label ı publicte tanımladım cunku tum alanlarda kullanmak istiyorum.
        TextBox txtbox = new TextBox();
        Label lbl3 = new Label();

        //Kod iki kısımdan oluşuyor kuruşlu kuruşsuz 
        //Kurus Kontrolu
        bool kurusVarMı(double num)
        {
            if (Math.Ceiling(num) == num && Math.Floor(num) == num)
                return true;
            else
                return false;
        }
      
        //Burada fatuta yazma islemlerinin yapıldıgı fonksiyon
        void faturaYazma(object sender, EventArgs e)
        {
           
            double faturaTutar = Convert.ToDouble(txtbox.Text);

            //Eger fatura 6 haneden büyük ise kabul etmeyecek.
            if (faturaTutar >= 100000)
            {
                MessageBox.Show("Tutar cok büyüktür!!", "WARNİNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int birler, onlar, yuzler, binler, onbinler;
                double kurus_birler, kurus_onlar;
                //kuruslarla işlemi sonra yapıcam kolaylık sağlaması için int değere donusturdum.
                int sayi = Convert.ToInt32(Math.Floor(faturaTutar));

                //Burada mod ile birlikte basamaklarındaki sayılara buldum bunun amacı array ile yazım isini yaptırmak.
                birler = sayi % 10;

                onlar = (sayi / 10) % 10;

                yuzler = (sayi / 100) % 10;

                binler = (sayi / 1000) % 10;

                onbinler = (sayi / 10000) % 10;

               //array tanımladım basamak degerlerine gore

                string[] birlik = { " ", " BİR ", " İKİ ", " UC ", " DORT ", " BES ", " ALTI ", " YEDİ ", " SEKİZ ", " DOKUZ " };

                string[] onluk = { "", " ON ", " YİRMİ ", " OTUZ ", " KIRK ", " ELLİ ", " ALTMIS ", " YETMİS ", " SEKSEN ", " DOKSAN " };

                string[] yuzluk = { "", " YUZ ", " İKİ YUZ ", " UC YUZ ", " DORT YUZ ", " BES YUZ ", " ALTI YUZ ", " YEDİ YUZ ", " SEKİZ YUZ ", " DOKUZ YUZ " };

                string[] binlik = { "", " BİN ", " İKİ BİN ", " UC BİN ", " DORT BİN ", " BES BİN ", " ALTİ BİN ", " YEDİ BİN ", " SEKİZ BİN ", " DOKUZ BİN " };

                // kurus var mı  kontrol
                if (kurusVarMı(faturaTutar))
                {
                    //Kurus Yok
                    if (onbinler == 0 && binler == 0 && yuzler == 0 && onlar == 0 && birler == 0)
                        lbl3.Text = "SIFIR";
                    else
                        lbl3.Text = onluk[onbinler] + binlik[binler] + yuzluk[yuzler] + onluk[onlar] + birlik[birler] + "TL";

                }
                else
                {
                    //Kurus Var
                    //Buradaki kontrol , kurus kısmında 3 basakmaklı ve dafa fazla basamaklı olamaz mesela 1.564 gibi cunku bu sefer kurus tl'ye donusur.
                    string kurus = faturaTutar.ToString().Substring(faturaTutar.ToString().LastIndexOf('.'));
                    if (kurus.Length <= 3)
                    {

                        //burada kurus oldugu icin bu ifadeleri tam sayıya cevirip moduna alarak yazdırdım.
                        kurus_birler = (100 * faturaTutar) % 10;
                        kurus_onlar = Math.Floor((10 * faturaTutar) % 10);



                        //Kuruslu fatura yazdırmayle ilgili kısım
                        if (onbinler == 0 && binler == 0 && yuzler == 0 && onlar == 0 && birler == 0 && kurus_onlar == 0 && kurus_birler == 0)
                            lbl3.Text = "SIFIR";
                        else
                        {
                            if (onbinler == 0)
                            {
                                if (birler == 0)
                                    lbl3.Text = "SIFIR" + binlik[binler] + yuzluk[yuzler] + onluk[onlar] + birlik[birler] + "TL" + onluk[((int)kurus_onlar)] + birlik[((int)kurus_birler)] + "KURUS";
                                else
                                    lbl3.Text = binlik[binler] + yuzluk[yuzler] + onluk[onlar] + birlik[birler] + "TL" + onluk[((int)kurus_onlar)] + birlik[((int)kurus_birler)] + "KURUS";
                            }
                                
                            else
                                lbl3.Text = onluk[onbinler] + binlik[binler] + yuzluk[yuzler] + onluk[onlar] + birlik[birler] + "TL" + onluk[((int)kurus_onlar)] + birlik[((int)kurus_birler)] + "KURUS";
                        }
                    }
                    //kurus 100 kurus veya 100 kurusu asarsa tl ye dönüsür burada hatalı bir mantık söz konusu olur.
                    else
                        MessageBox.Show("KURUS DEGERİ HATALIDIR");

                }
                
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //Fatura Gir Label
            Label lbl1 = new Label();
            Point lbl1Konum = new Point(300, 140);
            lbl1.Location = lbl1Konum;
            lbl1.Name = "lblFaturaGir";
            lbl1.Text = "FATURA GİR:";
            this.Controls.Add(lbl1);

            //Fatura Gir Textbox
            Point txtboxkonum = new Point(400, 140);
            txtbox.Location = txtboxkonum;
            txtbox.Name = "txtFaturaGir";
            txtbox.Text = "";
            this.Controls.Add(txtbox);


            //Fatura Tutarı Label
            Label lbl2 = new Label();
            Point lbl2Konum = new Point(300, 180);
            lbl2.Location = lbl2Konum;
            lbl2.Name = "lblFaturaTutarı";
            lbl2.Text = "FATURA TUTARI:";
            this.Controls.Add(lbl2);
            //Fatura Tutarı Label  Değer
            Point lbl3Konum = new Point(400, 180);
            lbl3.Location = lbl3Konum;
            lbl3.Name = "lblFaturaTutarıDeger";
            lbl3.Text = "";
            lbl3.Width = 545;
            this.Controls.Add(lbl3);
            //Button oluşturma
            Button btn = new Button();
            Point btnKonum = new Point(325, 300);
            btn.Location = btnKonum;
            btn.Name = "btn";
            btn.Text = "HESAPLA";
            btn.Height = 50;
            btn.Width = 150;
            this.Controls.Add(btn);
            
            btn.Click += new EventHandler(faturaYazma);
        }
    }
}

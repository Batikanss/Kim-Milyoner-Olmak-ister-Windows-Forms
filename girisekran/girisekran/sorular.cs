using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girisekran
{
    public partial class sorular : Form
    {
        public sorular()
        {
            InitializeComponent();
        }
        Random tut = new Random();
        int[] soru = {0,0,0,0};
        int[] qw = new int[24];
        int x;
        
        private void sorular_Load(object sender, EventArgs e)
        {
            if(int.Parse(olunan.Text) == 1)
            {
                label1.BackColor = Color.Yellow;
            }
            sorucuk(x);

        }
        public int lalala(int x)//hangi parada olduğumuz
        {
            if(x==2)
            {
                label1.BackColor = Color.Transparent;label2.BackColor = Color.Yellow;
            }
            if (x == 3)
            {
             label2.BackColor = Color.Transparent; label3.BackColor = Color.Yellow;
        
            }
            if (x == 4)
            {
                label3.BackColor = Color.Transparent; label4.BackColor = Color.Yellow;
            }
            if (x == 5)
            {
                label5.BackColor = Color.Yellow;label4.BackColor = Color.Transparent;
            }
            if (x == 6)
            {
              label5.BackColor = Color.Transparent; label6.BackColor = Color.Yellow;
            }
            if (x == 7)
            {
                label7.BackColor = Color.Yellow; label6.BackColor = Color.Transparent;
            }
            if (x == 8)
            {
            ; label7.BackColor = Color.Transparent; label8.BackColor = Color.Yellow;
                
            }
            if (x == 9)
            {
                label8.BackColor = Color.Transparent; label9.BackColor = Color.Yellow;
                
            }
            if (x == 10)
            {
               label9.BackColor = Color.Transparent; label10.BackColor = Color.Yellow;
          
            }
            if (x == 11)
            {
                 label10.BackColor = Color.Transparent; label11.BackColor = Color.Yellow;
        
            }
            if (x == 12)
            {
              label11.BackColor = Color.Transparent; label12.BackColor = Color.Yellow; 
            }

            return x;
        }
        public int sorucuk(int x)//soru bulan
        {
            if(int.Parse(olunan.Text)>6)
            {
                button5.Enabled = true;
                button5.Visible = true;
            }
               
            if(int.Parse(olunan.Text)>=13)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                button5.Visible = false;
                label13.Text = "1.000.000 TL KAZANDINIZ!";
                panel4.Visible = true;
                label13.Visible = true;
                MessageBox.Show("Tebrikler En Başa Yönlendiriliyorsunuz");
                Form1 enbas = new Form1();
                this.Close();
                enbas.Show();
            }
            if (int.Parse(olunan.Text) <= 4 && int.Parse(olunan.Text) > 0)// ilk 4 soru kolay
            {
            mal:
                x = tut.Next(1, 9);
                if (qw[x] == 15)
                    goto mal;

                if (x == 1)
                {
                    labelsoru.Text = "Eğer size daha çay içecektik? deniyorsa muhtemelen neredesinizdir?";
                    button1.Text = "A) Piknikte";
                    button2.Text = "B) Havalimanında";
                    button3.Text = "C) Misafirlikte";//
                    button4.Text = "D) Uzayda";
                    qw[x] = 15;
                }
                if (x == 2 && qw[x] != 15)
                {
                    labelsoru.Text = "Genellikle Hangisi Bilenir";
                    button1.Text = "A) Çatal";
                    button2.Text = "B) Bıçak";//
                    button3.Text = "C) Kaşık";
                    button4.Text = "D) Tabak";
                    qw[x] = 15;
                }
                if (x == 3 && qw[x] != 15)
                {
                    labelsoru.Text = "Türkiye'nin Başkenti Neresidir?";
                    button1.Text = "A) Ankara";//
                    button2.Text = "B) İzmir";
                    button3.Text = "C) İstanbul";
                    button4.Text = "D) Batman";
                    qw[x] = 15;
                }
                if (x == 4 && qw[x] != 15)
                {
                    labelsoru.Text = "Bir Futbol Maçı Kaç Dakika Sürmektedir?";
                    button1.Text = "A) 45 Dakika";
                    button2.Text = "B) 30 Dakika";
                    button3.Text = "C) 60 Dakika";
                    button4.Text = "D) 90 Dakika";//
                    qw[x] = 15;
                }
                if (x == 5 && qw[x] != 15)
                {
                    labelsoru.Text = "Çin Seddi Nerededir?";
                    button1.Text = "A) Hindistan";
                    button2.Text = "B) Çin";//
                    button3.Text = "C) Güney Kore";
                    button4.Text = "D) Japonya";
                    qw[x] = 15;
                }
                if (x == 6 && qw[x] != 15)
                {
                    labelsoru.Text = "Çok Üzülen Birinin, Halk Arasında Burnunun Nesi Sızladığı Söylenir?";
                    button1.Text = "A) Kemik";
                    button2.Text = "B) Direk";//
                    button3.Text = "C) Delik";
                    button4.Text = "D) Kemer";
                    qw[x] = 15;
                }
                if (x == 7 && qw[x] != 15)
                {
                    labelsoru.Text = "'Bulutların Üzerinde Gezmek' Sözü Hangisini İfade Etmek İçin Kullanılır?";
                    button1.Text = "A) Cesaret";
                    button2.Text = "B) Gurur";
                    button3.Text = "C) Mutluluk";//
                    button4.Text = "D) Şaşkınlık";
                    qw[x] = 15;
                }
                if (x == 8 && qw[x] != 15)
                {
                    labelsoru.Text = "Filika, Genellikle Hangi Araçta Bulunur?";
                    button1.Text = "A) Gemi";//
                    button2.Text = "B) Uçak";
                    button3.Text = "C) Tren";
                    button4.Text = "D) Dolmuş";
                    qw[x] = 15;
                }
            }
                if (int.Parse(olunan.Text) <= 8 && int.Parse(olunan.Text) > 4)//orta zorluk
                {
                tkr:
                    x = tut.Next(1, 9);
                    if (qw[x] == 20)
                        goto tkr;

                    if (x == 1)
                    {
                        labelsoru.Text = "Sherlock Holmes'un birçok macerasında yanında olan yakın dostu kimdir?";
                        button1.Text = "A) Hercule Poirot";
                        button2.Text = "B) Dr. Watson";//
                    button3.Text = "C) Dr. Brian";
                        button4.Text = "D) Miss Marple";
                        qw[x] = 20;
                    }
                    if (x == 2)
                    {
                        labelsoru.Text = "Gabardin nedir?";
                        button1.Text = "A) Bir enstrüman";
                        button2.Text = "B) Bir köpek cinsi";
                        button3.Text = "C) Bir kumaş türü";//
                    button4.Text = "D) Bir saç modeli";
                        qw[x] = 20;
                    }
                    if (x == 3)
                    {
                        labelsoru.Text = "Hangisinin eski adı 'amudufıkari' dir?";
                        button1.Text = "A) Bel kemiği";//
                    button2.Text = "B) Kaval kemiği";
                        button3.Text = "C) Kürek kemiği";
                        button4.Text = "D) Tarak kemiği";
                        qw[x] = 20;
                    }
                    if (x == 4)
                    {
                        labelsoru.Text = "Ana taşıyıcı kuleleri arasındaki mesafe en uzun olan, 'en uzun asma köprü' nerededir?";
                        button1.Text = "A) Türkiye";//
                    button2.Text = "B) Japonya";
                        button3.Text = "C) Çin";
                        button4.Text = "D) ABD";
                        qw[x] = 20;
                    }
                    if (x == 5)
                    {
                        labelsoru.Text = "'Asimetrik paralel' kategorisinde mücadele eden bir sporcu hangi dalda yarışıyordur?";
                        button1.Text = "A) Atletizm";
                        button2.Text = "B) Gülle atma";
                        button3.Text = "C) Binicilik";
                        button4.Text = "D) Jimnastik";//
                    qw[x] = 20;
                    }
                    if (x == 6)
                    {
                        labelsoru.Text = "Hangi adda bir sos yoktur?";
                        button1.Text = "A) Pesto";
                        button2.Text = "B) Ranch";
                        button3.Text = "C) Paprika";
                        button4.Text = "D) Avogadro";//
                    qw[x] = 20;
                    }
                    if (x == 7)
                    {
                        labelsoru.Text = "TDK Atasözleri ve Deyimler Sözlüğü'nde hangi kelimenin geçtiği bir atasözü yoktur?";
                        button1.Text = "A) Kiraz";
                        button2.Text = "B) Erik";
                        button3.Text = "C) Kayısı";//
                    button4.Text = "D) Armut";
                        qw[x] = 20;
                    }
                    if (x == 8)
                    {
                        labelsoru.Text = "2021 TÜİK istatistiklerine göre, bu illerden hangisinin toplam ihracatı daha fazladır?";
                        button1.Text = "A) Çorum";//
                    button2.Text = "B) Eskişehir";
                        button3.Text = "C) Samsun";
                        button4.Text = "D) Adana";
                        qw[x] = 20;
                    }
                }
            if (int.Parse(olunan.Text) <= 12 && int.Parse(olunan.Text) > 8)//en zor zorluk
            {
            bkr:
                x = tut.Next(1, 9);
                if (qw[x] == 25)
                    goto bkr;

                if (x == 1)
                {
                    labelsoru.Text = "Mortal Kombat oyununda 'Outworld' diyarının kralı kimdir?";
                    button1.Text = "A) Shang Tsung";
                    button2.Text = "B) Raiden";
                    button3.Text = "C) Liu Kang";
                    button4.Text = "D) Shao Kahn";//
                    qw[x] = 25;
                }
                if (x == 2)
                {
                    labelsoru.Text = "Ünlü futbolcu Lionel Messi hangi ayda doğmuştur?";
                    button1.Text = "A) Nisan";
                    button2.Text = "B) Mayıs";
                    button3.Text = "C) Haziran";//
                    button4.Text = "D) Temmuz";
                    qw[x] = 25;
                }
                if (x == 3)
                {
                    labelsoru.Text = "Beslenmesinde balık dışında ete yer vermeyen kişilere ne denir?";
                    button1.Text = "A) Parnasyen";
                    button2.Text = "B) Peskataryan";//
                    button3.Text = "C) Gaseyan";
                    button4.Text = "D) Devoniyen";
                    qw[x] = 25;
                }
                if (x == 4)
                {
                    labelsoru.Text = "Zeki Müren'in 'Biraz Fernandel, biraz Belmondo' diye tanımladığı kişi kimdir?";
                    button1.Text = "A) Kemal Sunal";//
                    button2.Text = "B) Cüneyt Arkın";
                    button3.Text = "C) Tarık Akan";
                    button4.Text = "D) Şener Şen";
                    qw[x] = 25;
                }
                if (x == 5)
                {
                    labelsoru.Text = "Türkçede kelimeler en çok hangi harfle başlar?";
                    button1.Text = "A) M harfi";
                    button2.Text = "B) S harfi";
                    button3.Text = "C) R harfi";
                    button4.Text = "D) K harfi";//
                    qw[x] = 25;
                }
                if (x == 6)
                {
                    labelsoru.Text = "Ağustos 2010'da hangi şehirde yaşanan trafiğin açılması 10 gün sürmüştür?";
                    button1.Text = "A) Moskova";
                    button2.Text = "B) Türkiye";
                    button3.Text = "C) Pekin";//
                    button4.Text = "D) Moskova";
                    qw[x] = 25;
                }
                if (x == 7)
                {
                    labelsoru.Text = "Avrupa standartlarına göre basketbolda pota yerden kaç metre yüksekliktedir?";
                    button1.Text = "A) 3.06 Metre";
                    button2.Text = "B) 3.05 Metre";//
                    button3.Text = "C) 3.04 Metre";
                    button4.Text = "D) 3.03 Metre";
                    qw[x] = 25;
                }
                if (x == 8)
                {
                    labelsoru.Text = "On kıtadan oluşan İstiklal Marşı'nın tamamında, bu kelimelerden hangisi daha az geçer?";
                    button1.Text = "A) Toprak";//
                    button2.Text = "B) Vatan";
                    button3.Text = "C) Kan";
                    button4.Text = "D) Yurt";
                    qw[x] = 25;
                }
            }

            return x;
        }//soru bulanson
        public void yanlis()//elenme
        {
            if(int.Parse(olunan.Text) <3)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                button5.Visible = false;
                MessageBox.Show("Elendiniz Maalesef Ödül Yok.");
                MessageBox.Show("En Başa Yönlendiriliyorsunuz");
                Form1 enbas = new Form1();
                this.Close();
                enbas.Show();
            }
            if(int.Parse(olunan.Text) <= 6 && int.Parse(olunan.Text) > 2)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                button5.Visible = false;
                label13.Text ="1.000 TL KAZANDINIZ!";
                panel4.Visible = true;
                label13.Visible = true;
                MessageBox.Show("En Başa Yönlendiriliyorsunuz");
                Form1 enbas = new Form1();
                this.Close();
                enbas.Show();
            }
            if (int.Parse(olunan.Text) <= 12 && int.Parse(olunan.Text) > 6)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                button5.Visible = false;
                label13.Text = "7.500 TL KAZANDINIZ!";
                panel4.Visible = true;
                label13.Visible = true;
                MessageBox.Show("En Başa Yönlendiriliyorsunuz");
                Form1 enbas = new Form1();
                this.Close();
                enbas.Show();
            }
        }//elenmeson

        public void cekilme()//cekilme
        {
            if(int.Parse(olunan.Text)==7)
            {
                DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    button5.Visible = false;
                    label13.Text = "7.500 TL KAZANDINIZ!";
                    panel4.Visible = true;
                    label13.Visible = true;
                    MessageBox.Show("Tebrikler En Başa Yönlendiriliyorsunuz");
                    Form1 enbas = new Form1();
                    this.Close();
                    enbas.Show();
                }
            }
            if (int.Parse(olunan.Text) == 8)
            {
                DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    button5.Visible = false;
                    label13.Text = "15.000 TL KAZANDINIZ!";
                    panel4.Visible = true;
                    label13.Visible = true;
                    MessageBox.Show("Tebrikler En Başa Yönlendiriliyorsunuz");
                    Form1 enbas = new Form1();
                    this.Close();
                    enbas.Show();
                }
            }
            if (int.Parse(olunan.Text) == 9)
            {
                DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    button5.Visible = false;
                    label13.Text = "30.000 TL KAZANDINIZ!";
                    panel4.Visible = true;
                    label13.Visible = true;
                    MessageBox.Show("Tebrikler En Başa Yönlendiriliyorsunuz");
                    Form1 enbas = new Form1();
                    this.Close();
                    enbas.Show();
                }
            }
            if (int.Parse(olunan.Text) == 10)
            {
                DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    button5.Visible = false;
                    label13.Text = "60.000 TL KAZANDINIZ!";
                    panel4.Visible = true;
                    label13.Visible = true;
                    MessageBox.Show("Tebrikler En Başa Yönlendiriliyorsunuz");
                    Form1 enbas = new Form1();
                    this.Close();
                    enbas.Show();
                }
            }
            if (int.Parse(olunan.Text) == 11)
            {
                DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    button5.Visible = false;
                    label13.Text = "125.000 TL KAZANDINIZ!";
                    panel4.Visible = true;
                    label13.Visible = true;
                    MessageBox.Show("Tebrikler En Başa Yönlendiriliyorsunuz");
                    Form1 enbas = new Form1();
                    this.Close();
                    enbas.Show();
                }
            }
            if (int.Parse(olunan.Text) == 12)
            {
                DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    button5.Visible = false;
                    label13.Text = "250.000 TL KAZANDINIZ!";
                    panel4.Visible = true;
                    label13.Visible = true;
                    MessageBox.Show("Tebrikler En Başa Yönlendiriliyorsunuz");
                    Form1 enbas = new Form1();
                    this.Close();
                    enbas.Show();
                }
            }
        }//cekilme son
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "A) Gemi" || button1.Text == "A) Ankara" || button1.Text == "A) Bel kemiği" || button1.Text == "A) Türkiye" || button1.Text == "A) Çorum"||button1.Text== "A) Kemal Sunal"||button1.Text== "A) Toprak")
            {
                MessageBox.Show("Doğru Cevap");
                int m = int.Parse(olunan.Text); m++;
                olunan.Text = m.ToString();
                lalala(m);
                sorucuk(m);
            }
            else
            {
                if (m == 5 || m == 0)
                    yanlis();
                if (m == 1)
                {
                    button1.Text = "A)"; m--;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "B) Dr. Watson" || button2.Text == "B) Direk" || button2.Text == "B) Çin" || button2.Text == "B) Bıçak" || button2.Text == "B) Peskataryan"||button2.Text== "B) 3.05 Metre")
            {
                MessageBox.Show("Doğru Cevap");
                int m = int.Parse(olunan.Text); m++;
                olunan.Text = m.ToString();
                lalala(m);
                sorucuk(m);
            }
            else
            {
                if (m == 5 || m == 0)
                    yanlis();
                if (m == 1)
                {
                    button2.Text = "B)"; m--;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "C) Kayısı" || button3.Text == "C) Bir kumaş türü" || button3.Text == "C) Mutluluk" || button3.Text == "C) Misafirlikte" || button3.Text == "C) Haziran"||button3.Text== "C) Pekin")
            {
                MessageBox.Show("Doğru Cevap");
                int m = int.Parse(olunan.Text); m++;
                olunan.Text = m.ToString();
                lalala(m);
                sorucuk(m);
            }
            else
            {
                if (m == 5 || m == 0)
                    yanlis();
                if (m == 1)
                {
                    button3.Text = "C)"; m--;
                }
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "D) 90 Dakika" || button4.Text == "D) Avogadro" || button4.Text == "D) Mutluluk" || button4.Text == "D) Jimnastik" || button4.Text == "D) Shao Kahn" || button4.Text=="D) K harfi")
            {
                MessageBox.Show("Doğru Cevap");
                int m = int.Parse(olunan.Text); m++;
                olunan.Text = m.ToString();
                lalala(m);
                sorucuk(m);
            }
            else
            {
                if(m==5 ||m==0)
                yanlis();
                if(m==1)
                {
                    button4.Text = "D)";m--;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)//%50 joker
        {
            if(button1.Text== "A) Piknikte")//hep aynı şıkları sildirebilirdin || kullanarak button1.text==A olanlar da hep b ve cyi sildirirdin 2de A C 3te A D 4te B A
            {
                button1.Text = "A)";
                button4.Text = "D)";
            }
            if (button1.Text == "A) Çatal")
            {
                button1.Text = "A)";
                button4.Text = "D)";
            }
            if(button1.Text== "A) Ankara")
            {
                button2.Text = "B)";
                button3.Text = "C)";
            }
            if (button1.Text == "A) Gemi")
            {
                button2.Text = "B)";
                button4.Text = "D)";
            }
            if (button1.Text == "A) Bel kemiği")
            {
                button2.Text = "B)";
                button4.Text = "D)";
            }
            if (button1.Text == "A) Türkiye")
            {
                button3.Text = "C)";
                button4.Text = "D)";
            }
            if (button1.Text == "A) Toprak")
            {
                button2.Text = "B)";
                button4.Text = "D)";
            }
            if (button1.Text == "A) Çorum")
            {
                button3.Text = "C)";
                button2.Text = "B)";
            }
            if (button1.Text == "A) Kemal Sunal")
            {
                button3.Text = "C)";
                button2.Text = "B)";
            }
            if (button2.Text == "B) Direk")//
            {
                button3.Text = "C)";
                button1.Text = "A)";
            }
            if (button2.Text == "B) Peskataryan")//
            {
                button3.Text = "C)";
                button4.Text = "D)";
            }
            if (button2.Text == "B) 3.05 Metre")//
            {
                button3.Text = "C)";
                button1.Text = "A)";
            }
            if (button2.Text == "B) Dr. Watson")//
            {
                button3.Text = "C)";
                button4.Text = "D)";
            }
            if (button2.Text == "B) Çin")//
            {
                button1.Text = "A)";
                button3.Text = "C)";
            }
            if (button3.Text == "C) Pekin")//
            {
                button1.Text = "A)";
                button2.Text = "B)";
            }
            if (button3.Text == "C) Haziran")//
            {
                button1.Text = "A)";
                button4.Text = "D)";
            }
            if (button3.Text == "C) Bir kumaş türü")//
            {
                button2.Text = "B)";
                button4.Text = "D)";
            }
            if (button3.Text == "C) Kayısı")//
            {
                button2.Text = "B)";
                button1.Text = "A)";
            }
            if (button3.Text == "C) Mutluluk")//
            {
                button4.Text = "D)";
                button1.Text = "A)";
            }
            if (button4.Text == "D) Shao Kahn")//
            {
                button2.Text = "B)";
                button1.Text = "A)";
            }
            if (button4.Text == "D) K harfi")//
            {
                button3.Text = "C)";
                button1.Text = "A)";
            }
            if (button4.Text == "D) Avogadro")//
            {
                button3.Text = "C)";
                button2.Text = "B)";
            }
            if (button4.Text == "D) 90 Dakika")//
            {
                button1.Text = "A)";
                button2.Text = "B)";
            }
            if (button4.Text == "D) Jimnastik")//
            {
                button1.Text = "A)";
                button3.Text = "C)";
            }
           

            pictureBox3.Enabled = false;
            pictureBox3.Visible = false;
        }//%50 son

        private void button5_Click(object sender, EventArgs e)
        {
            cekilme();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//doğru cevap joker
        {//A) AnkaraA) GemiA) Bel kemiğiA) TürkiyeA) ÇorumA) Kemal SunalA) Toprak//
            if (button1.Text=="A) Ankara" || button1.Text == "A) Gemi" ||button1.Text== "A) Kemal Sunal"|| button1.Text=="A) Türkiye"|| button1.Text=="A) Çorum"|| button1.Text=="A) Bel kemiği" || button1.Text=="A) Toprak")
            {
                MessageBox.Show("Doğru Cevap A Şıkkı.");
            }//B) BıçakB) ÇinB) DirekB) Dr. WatsonB) PeskataryanB) 3.05 Metre
            if (button2.Text=="B) Direk" || button2.Text== "B) Peskataryan" || button2.Text == "B) 3.05 Metre" || button2.Text == "B) Dr. Watson" || button2.Text == "B) Çin" || button2.Text=="B) Bıçak")
            {
                MessageBox.Show("Doğru Cevap B Şıkkı.");
            }
            if(button3.Text== "C) Pekin" || button3.Text == "C) Haziran" || button3.Text == "C) Bir kumaş türü" || button3.Text == "C) Kayısı" || button3.Text == "C) Mutluluk")
            {
                MessageBox.Show("Doğru Cevap C Şıkkı.");
            }
            if (button4.Text == "D) Shao Kahn" || button4.Text == "D) K harfi" || button4.Text == "D) Avogadro" || button4.Text == "D) 90 Dakika" || button4.Text == "D) Jimnastik")
            {
                MessageBox.Show("Doğru Cevap D Şıkkı.");
            }
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
        }//doğru joker son
        int m=5;
        private void pictureBox4_Click(object sender, EventArgs e)//x2 hak
        {
            m = 1;
            pictureBox4.Visible = false;
            pictureBox4.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int j,v,b,a;//A) AnkaraA) GemiA) Bel kemiğiA) TürkiyeA) ÇorumA) Kemal SunalA) Toprak//
            if ( button1.Text == "A) Ankara" || button1.Text == "A) Gemi" || button1.Text == "A) Kemal Sunal" || button1.Text == "A) Türkiye" || button1.Text == "A) Çorum" || button1.Text == "A) Bel kemiği" || button1.Text == "A) Toprak")
            {
                deneme:
                j = tut.Next(70, 101);//75
                v = tut.Next(0, 100 - j);//30
                b = tut.Next(0, 100-(j+v));//
                a = 100 - (j + v+b); 
                if(j+v+b+a!=100)
                    goto deneme;
                MessageBox.Show("A)%"+j+"\nB)%"+v+"\nC)%"+b+"\nD)%"+a);
            }//B) BıçakB) ÇinB) DirekB) Dr. WatsonB) PeskataryanB) 3.05 Metre
            if (button2.Text == "B) Bıçak"|| button2.Text == "B) Direk" || button2.Text == "B) Peskataryan" || button2.Text == "B) 3.05 Metre" || button2.Text == "B) Dr. Watson" || button2.Text == "B) Çin")
            {
            deneme:
                j = tut.Next(70, 101);//75
                v = tut.Next(0, 100 - j);//30
                b = tut.Next(0, 100 - (j + v));//
                a = 100 - (j + v + b);
                if (j + v + b + a != 100)
                    goto deneme;
                MessageBox.Show("A)%" + v + "\nB)%" + j + "\nC)%" + b + "\nD)%" + a);
            }
            if (button3.Text == "C) Pekin" || button3.Text == "C) Haziran" || button3.Text == "C) Bir kumaş türü" || button3.Text == "C) Kayısı" || button3.Text == "C) Mutluluk"||button3.Text == "C) Misafirlikte" )
            {
            deneme:
                j = tut.Next(70, 101);//75
                v = tut.Next(0, 100 - j);//30
                b = tut.Next(0, 100 - (j + v));//
                a = 100 - (j + v + b);
                if (j + v + b + a != 100)
                    goto deneme;
                MessageBox.Show("A)%" + v + "\nB)%" + b + "\nC)%" + j + "\nD)%" + a);
            }
            if (button4.Text == "D) Shao Kahn" || button4.Text == "D) K harfi" || button4.Text == "D) Avogadro" || button4.Text == "D) 90 Dakika" || button4.Text == "D) Jimnastik")
            {
            deneme:
                j = tut.Next(70, 101);//75
                v = tut.Next(0, 100 - j);//30
                b = tut.Next(0, 100 - (j + v));//
                a = 100 - (j + v + b);
                if (j + v + b + a != 100)
                    goto deneme;
                MessageBox.Show("A)%" + v + "\nB)%" + a + "\nC)%" + b + "\nD)%" + j);
            }
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
        }
    }
}

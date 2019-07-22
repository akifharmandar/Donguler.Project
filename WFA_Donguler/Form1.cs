﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DONGULER - LOOPS
        //Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
        //FOR - FOREACH - WHILE - DOWHILE

        int toplam = 0;
        private void BtnOrnekBir_Click(object sender, EventArgs e)
        {
            //Donguye ilk giris aninda derleyici baslangic degerine bakar ve bir daha asla bu bloga ugramaz. 
            //Bundan sonraki islemler once arttir, daha sonra kosula bak, kosul uygunsa dongunun kod blogunu harekete gecir, uygun degilse donguden cik...

            //for(BaslangicDegeri; BitisKosulu; Artis-AzalisMiktari)


            for (int deger = 1; deger <= 1000; deger++)
            {
                toplam = toplam + deger;
                toplam++;
                listBox1.Items.Add(deger);

            }
        }

        private void BtnOrnekIki_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i >= 0; i--)
            {
                toplam = toplam - i;
                toplam++;
                listBox1.Items.Add(i);
            }
        }

        private void BtnOrnekUc_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= 1000; i += 2)
            {
                toplam += i;
                toplam++;
                listBox1.Items.Add(i);
            }
        }

        private void BtnOrnekDort_Click(object sender, EventArgs e)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                listBox1.Items.Add(i);
            }
        }


        private void BtnOrnekBes_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki sayilarin toplamini ekrana yazdiriniz..
            for (int i = 1; i <= 100; i++)
            {
                toplam =toplam+ i;
                //listBox1.Items.Add(toplam);
                MessageBox.Show(toplam.ToString());
            }
        }

        int çiftToplam = 0;
        int tekToplam = 0;
        int islem1 = 0;
        int islem2 = 0;
        private void BtnOrnekAlti_Click(object sender, EventArgs e)
        {
            //1-100 arasindaki cift sayilarin toplami ile, tek sayilarin toplaminin farklari karesi kactir?
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    çiftToplam += i;
                }
            }
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==1)
                {
                    tekToplam += i;
                }
            }
            islem1 = çiftToplam - tekToplam;
            islem2 = islem1 * islem1;
            MessageBox.Show(islem2.ToString());
        }

        private void BtnOrnekYedi_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılı arasındaki yıllar Listbox'a eklensin ancak
            //1990 ve 1992 yılları eklenmeyecek...

            //int veri = 0;

            for (int i = 1945; i <= 2019; i++)
            {
               listBox1.Items.Add(i);
                listBox1.Items.Remove(1990);
                listBox1.Items.Remove(1992);
            }
            
        }
        string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };

        int veri = 0;
        

        private void Button7_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            if (veri<takimlar.Length)
            {
                listBox2.Items.Add(takimlar[veri]);
                veri++;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //Sayisal bir dizi tanimlayin ve Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };

             if (sayisal[0]>sayisal[1] && sayisal[0]> sayisal[2] && sayisal[0]> sayisal[3]&& 
                    sayisal[0]> sayisal[4]&& sayisal[0]> sayisal[5]&& sayisal[0]> sayisal[6]&&
                sayisal[0]> sayisal[7]&& sayisal[0]> sayisal[8]&& sayisal[0]> sayisal[9])
            {
                MessageBox.Show(sayisal[0].ToString());
            }
            else if ((sayisal[1] > sayisal[0] && sayisal[1] > sayisal[2] && sayisal[1] > sayisal[3] &&
                 sayisal[1] > sayisal[4] && sayisal[1] > sayisal[5] && sayisal[1] > sayisal[6] &&
                sayisal[1] > sayisal[7] && sayisal[1] > sayisal[8] && sayisal[1] > sayisal[9]))
            {
                MessageBox.Show(sayisal[1].ToString());
            }

            else if ((sayisal[2] > sayisal[1] && sayisal[2] > sayisal[0] && sayisal[2] > sayisal[3] &&
                sayisal[2] > sayisal[4] && sayisal[2] > sayisal[5] && sayisal[2] > sayisal[6] &&
               sayisal[2] > sayisal[7] && sayisal[2] > sayisal[8] && sayisal[2] > sayisal[9]))
            {
                MessageBox.Show(sayisal[2].ToString());
            }
            else if ((sayisal[3] > sayisal[1] && sayisal[3] > sayisal[2] && sayisal[3] > sayisal[0] &&
                sayisal[3] > sayisal[4] && sayisal[3] > sayisal[5] && sayisal[3] > sayisal[6] &&
               sayisal[3] > sayisal[7] && sayisal[3] > sayisal[8] && sayisal[3] > sayisal[9]))
            {
                MessageBox.Show(sayisal[3].ToString());
            }
            else if ((sayisal[4] > sayisal[1] && sayisal[4] > sayisal[2] && sayisal[4] > sayisal[0] &&
              sayisal[4] > sayisal[3] && sayisal[4] > sayisal[5] && sayisal[4] > sayisal[6] &&
             sayisal[4] > sayisal[7] && sayisal[4] > sayisal[8] && sayisal[4] > sayisal[9]))
            {
                MessageBox.Show(sayisal[4].ToString());
            }
            else if ((sayisal[5] > sayisal[1] && sayisal[5] > sayisal[2] && sayisal[5] > sayisal[3] &&
            sayisal[5] > sayisal[4] && sayisal[5] > sayisal[0] && sayisal[5] > sayisal[6] &&
           sayisal[5] > sayisal[7] && sayisal[5] > sayisal[8] && sayisal[5] > sayisal[9]))
            {
                MessageBox.Show(sayisal[5].ToString());
            }
            else if ((sayisal[6] > sayisal[1] && sayisal[6] > sayisal[2] && sayisal[6] > sayisal[0] &&
            sayisal[6] > sayisal[3] && sayisal[6] > sayisal[5] && sayisal[6] > sayisal[4] &&
           sayisal[6] > sayisal[7] && sayisal[6] > sayisal[8] && sayisal[6] > sayisal[9]))
            {
                MessageBox.Show(sayisal[6].ToString());
            }
            else if ((sayisal[7] > sayisal[1] && sayisal[7] > sayisal[2] && sayisal[7] > sayisal[0] &&
           sayisal[7] > sayisal[3] && sayisal[7] > sayisal[5] && sayisal[7] > sayisal[4] &&
          sayisal[7] > sayisal[6] && sayisal[7] > sayisal[8] && sayisal[7] > sayisal[9]))
            {
                MessageBox.Show(sayisal[7].ToString());
            }
            else if ((sayisal[8] > sayisal[1] && sayisal[8] > sayisal[2] && sayisal[8] > sayisal[0] &&
           sayisal[8] > sayisal[3] && sayisal[8] > sayisal[5] && sayisal[8] > sayisal[4] &&
          sayisal[8] > sayisal[7] && sayisal[8] > sayisal[6] && sayisal[8] > sayisal[9]))
            {
                MessageBox.Show(sayisal[8].ToString());
            }
            else if ((sayisal[9] > sayisal[1] && sayisal[9] > sayisal[2] && sayisal[9] > sayisal[0] &&
           sayisal[9] > sayisal[3] && sayisal[9] > sayisal[5] && sayisal[9] > sayisal[4] &&
          sayisal[9] > sayisal[7] && sayisal[9] > sayisal[8] && sayisal[9] > sayisal[6]))
            {
                MessageBox.Show(sayisal[9].ToString());
            }
        }
        
        private void Button5_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };

            foreach (var item in sayisal)
            {
                if (item%2==0)
                {
                    int çiftToplam= item.ToString().Count();
                }
                else 
                {
                    int tekToplam = item.ToString().Count();
                }
                
            }
            MessageBox.Show("Çift sayıların adedi: " + çiftToplam + " " + "Tek sayıların adedi:" + tekToplam);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //asagidaki "adim" degiskeninde yer alan metni tersten isterseniz formun tepesine, isterseniz MessageBox'la yazdiriniz...

            //NOT => STRING'LER BİRER CHAR DİZİSİDİR...
            string adim = "bilgeadam";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Karmasik 10 adet sayiyi listbox icerisine ekleyiniz...
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Form uzerinde yer alan tum butonlarin arkaplan renkleri kırmızı, yazi renkleri ise sarı olsun...

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir...
        }



        /*
   FOREACH
   1) Kesinlikle index mantigi yoktur!
   2) Tip bagimli dongulerdir...
   3) Cogu zaman elimizdeki bir koleksiyonun her bir elemanini tek tek ele almak icin kullanilir...
*/


        private void Button16_Click(object sender, EventArgs e)
        {
            //İlgili dizi icerisindeki her bir elemana gecici olarak "str" takma adi verilir ve dongunun her bir adiminda size dizinin her bir elemani teslim edilir...
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            //İkiye bolunenleri listbox1'e bolunemeyenleri listbox2 ye atın... Hem ikiye hem uce bolunenlerin kac tane oldugunu da messagebox'la gosterin...
            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            //Listbox1'deki secili tum elemanlari (birden fazla secim sansi olmali!) listbox2'ye ekleyelim...
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            //Form uzerindeki tum butonlarin arkaplanlari ve yazi renklerini degistiriniz...
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HESAPMAKİNESİ
{
    internal class HesapMakinesi
    {
        
        public int sayi1 = 0;
        public int sayi2=0;
        public int islemturu= 0;
        public int sonuc;
        public string gecmis ="";
        public string label = "";
        
        
        public string labelyazdırma(int x)
        {
            label += " " + x;
            return label;
        }
        public string labelyazdırma(char x)
        {
            label += " " + x;
            return label;
        }
        public void temizleme()
        {
            sayi1 = 0;
            sayi2 = 0;
            islemturu=0;           
            label="";
        }
        public string gecmisyazdırma()
        {
            return gecmis;
        }
        public void işlemkactayız()
        {
            if (sayi2 > 0)
            {
                for (int i = 1; i >= 0; i--)
                {
                    //burada değerleri boş değere eşitlemek
                     
                }
                sayi2 = -1;

            }
            else if (islemturu != 0)
            {
                islemturu = 0;
            }
            else
            {
                sayi1 = -1;
            }
        }
        public void gecmissilme()
        {
            gecmis = "";
            
        }
        public int Hesaplamaisleri(string işlem)
        {
            
            int[] sayıdizisi = { 1000, 100, 10, 1 };
            int sayidizisitakip = 3;
            int hangisayı = 0;

            for (int i = işlem.Length - 1; i >= 0; i--)
            {
                if (işlem[i] == ' ')
                {
                    continue;
                }
                else if (işlem[i] == '+' || işlem[i] == '-' || işlem[i] == 'x' || işlem[i] == '/')
                {
                    hangisayı++;
                    sayidizisitakip = 3;
                }
                else
                {
                    int gecici12 = int.Parse(işlem[i].ToString());
                    if (hangisayı == 0)
                    {
                        sayi2 += gecici12 * sayıdizisi[sayidizisitakip];
                    }
                    else
                    {
                        sayi1 += gecici12 * sayıdizisi[sayidizisitakip];
                    }
                    sayidizisitakip--;
                }
            }

            //bölme işlemi için int yerine ondalıklı veri tipi kullanılabilir
            switch (islemturu)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    break;
                case 4:
                    sonuc = sayi1 / sayi2;
                    break;
            }
            gecmis += "(" + işlem + "=" +sonuc+")";
            // label, sayi1, sayi2 ve gecmis değişkenlerinin değerlerini burada nasıl işleyeceğinize karar vermelisiniz.
            return sonuc;
        }
    }
}


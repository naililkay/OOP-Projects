using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet  { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cadde { get; set; }
        public int KapiNo { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public int Maas  { get; set; }
        public string Unvan() 
        {
            string unvan = "";

            //if (this.Cinsiyet == "E")
            //    unvan = $" Sn Bay {Ad} {Soyad}"; 
            //else 
            //    unvan = $" Sn Bayan {Ad} {Soyad}";

           // koşul operatorü
            unvan = Cinsiyet == "E" ? $" Sn Bay {Ad} {Soyad}" : $" Sn Bay {Ad} {Soyad}";

            return unvan;

        }

        public int Yas()
        {
            DateTime bugun = DateTime.Now;

            int yas = bugun.Year - DogumTarihi.Year;
            DateTime dogumgun = DogumTarihi.AddYears(yas);

            if (dogumgun>bugun)
            {
                yas++;
            }
            return yas;

        }

        public List<string>  AdresAl() 
        {
            List<string> adres=new List<string>();

            adres.Add("unvanı " + Unvan()); 
            adres.Add("caddesi" +  Cadde);
            adres.Add("kapınumarası " + KapiNo.ToString()+ " ");
            adres.Add("il/ ilce "+ Ilce + " " + Sehir);

            return adres;

        }
    }
}

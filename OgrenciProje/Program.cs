using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
    internal class Program
    {
        static List<Personel> personellist = new List<Personel>();
        
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu()
        {
            Console.WriteLine("1.Personel Listesi");
            Console.WriteLine("2.Personel Listesi");
            string secim = Console.ReadLine();
            


            if (secim=="1")
            {

                Createlist();
                
            }
            if (secim == "2")
            {
                
                PerList(personellist);

            }
            
            
            


        }


        static void PerList(List<Personel> lsi )
        {
            Console.WriteLine("Id Ad Soyad maaş");
            Console.WriteLine("*********************");

            foreach (var item in lsi)
            {
                Console.WriteLine($"{item.Id} {item.Ad} {item.Soyad} {item.maas}" );
            }

            //ToplamAl(ls);

        }

        private static void ToplamAl(List<Personel> ls)
        {
            //1.yol

            int toplammaas = 0;
            int ortmaas = 0;
            int toplamkisi = 0;
            int toplamerkek = 0;
            int toplamkadin = 0;
            int toplamerkekmaas = 0;
            int toplamkdnmaas = 0;
            foreach (var item in ls)
            {
                toplamkisi++;
                toplammaas += item.maas;
                if (item.Cinsiyet=="E")
                {
                    toplamerkek++;
                    toplamerkekmaas += item.maas;

                }
                else
                {
                    toplamkadin++;
                    toplamkdnmaas += item.maas;
                }
                
            }

            ortmaas = toplammaas / toplamkisi;

            //yol legn exprension

            toplamkisi = ls.Count;
            toplamerkek = ls.Where(x => x.Cinsiyet == "E").Count();
            toplamkadin = ls.Where(x => x.Cinsiyet == "K").Count();
            toplamerkekmaas = ls.Where(x => x.Cinsiyet == "E").Sum(x => x.maas);
            toplamkdnmaas = ls.Where(x => x.Cinsiyet == "K").Sum(x => x.maas);



            Console.WriteLine($"Toplam kişi {toplamkisi}");
            Console.WriteLine($"Toplam erkek {toplamerkek}");
            Console.WriteLine($"Toplam kadın {toplamkadin}");
            Console.WriteLine($"ortalama maaş  {ortmaas}");

        }

        static void Createlist()
        {
            Random random = new Random();

            for (int i = 1; i < 20; i++)
            {
                Personel personel = new Personel();
                personel.Ad = FakeData.NameData.GetFirstName();
                personel.Id = i;
                personel.Cadde = FakeData.PlaceData.GetStreetName();
                personel.Soyad = FakeData.NameData.GetSurname();
                int yas = random.Next(20, 50);
                personel.DogumTarihi = DateTime.Now.AddYears(yas * -1);

                int cins = random.Next(0, 2);
                if (cins == 0)
                {
                    personel.Cinsiyet = "E";
                }
                else
                {
                    personel.Cinsiyet = "K";
                }

                personel.Ilce = FakeData.PlaceData.GetCounty();
                personel.Sehir = FakeData.PlaceData.GetCity();
                personel.KapiNo = random.Next(1, 130);
                personel.maas = random.Next(3000, 5000);

               personellist.Add(personel); 

            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaçParamVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal tlTutar = Cevir("Kaç Tl var");
            decimal EuroTutar = Cevir("Kaç euro var");
            decimal dolarTutar = Cevir("Kaç dolar var");
            dolarTutar = KurHesapla(dolarTutar, "Dolar kuru ne kadar");
            EuroTutar = KurHesapla(EuroTutar, "euro kuru ne kadar");
            decimal toplam=tlTutar+EuroTutar+dolarTutar;

            Yazdir(toplam);



        }

        static void Yazdir(decimal toplamdeger)
        {
            Console.WriteLine("Toplam Değer : {0} ",toplamdeger);
            Console.ReadLine();
        }

        static decimal Cevir(string soru)
        {
            try
            {

                Console.WriteLine(soru);
                return decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("sayısal bir değer girin lütfen");
                Console.ReadLine();
                Cevir(soru);
                return 0;
            }
            
           

        }

        static decimal KurHesapla(decimal yp, string kursoru)
        {
            decimal kur=Cevir(kursoru);

            return  yp*kur; 
        }

    }
}

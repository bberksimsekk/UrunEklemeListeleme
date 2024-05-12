using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunEklemeListeleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ürünlerin adı, kategorisi, fiyatı, stok miktarı alınacak
            //1 - Ürün Ekle
            //Ürünün tüm özellikleri konsoldan alınabilecek
            //2 - Ürün Listele
            //Ürünün kategori veya adına göre filtreleme yapılabilecek
            //Filtrelemede ürünün tam adını yazmak zorunda değiliz
            //3 - Çıkış

            Program p = new Program();
            List<Ürün> ürünler = new List<Ürün>();

            while(true)
            {
                int seçim = p.MenüYazdır();
                if (seçim == 1)
                {
                    Console.Clear();
                    Ürün u = new Ürün();

                    Console.WriteLine("Ürünün;");
                    Console.Write("Adı = ");
                    u.İsim = Console.ReadLine();
                    Console.Write("Kategorisi = ");
                    u.Kategori = Console.ReadLine();
                    Console.Write("Fiyatı = ");
                    u.Fiyat = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Stok Miktarı = ");
                    u.Stok = Convert.ToInt16(Console.ReadLine());
                    ürünler.Add(u);
                }
                if (seçim == 2)
                {
                    Console.Clear();
                    foreach (Ürün Eleman in ürünler)
                    {
                        Console.WriteLine(Eleman.İsim + " " + Eleman.Kategori + " " + Eleman.Fiyat + " " + Eleman.Stok);
                    }

                    //for (int i = 0; i < ürünler.Count; i++)
                    //{
                    //    Ürün u = ürünler[i];
                    //    Console.WriteLine(u.İsim + " " + u.Kategori + " " + u.Fiyat + " " + u.Stok);
                    //}
                }
                if (seçim == 3) { break; }
            }


        }

        public int MenüYazdır()
        {
            Console.WriteLine("1 - Ürün Ekle");
            Console.WriteLine("2 - Ürün Listele");
            Console.WriteLine("3 - Çıkış");
            Console.Write("İşlem Seçiniz = ");
            int seçim = Convert.ToInt32(Console.ReadLine());
            return seçim;
        }
    }

    class Ürün
    {
        public string İsim { get; set; }

        public string Kategori { get; set; }

        public double Fiyat { get; set; }

        public short Stok { get; set; }
    }
}

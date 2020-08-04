using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Vektorel.Konsol.SinavApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hangi dosya?");
                string path = Console.ReadLine();
                while (true)
                {
                    Kitap k = new Kitap();
                    Console.WriteLine("Kitap Adı:");
                    k.Kitapad = Console.ReadLine();
                    Console.WriteLine("Yazar");
                    k.Yazar = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("Basım Yılı:");
                        k.Basimyil = int.Parse(Console.ReadLine());
                    } while (k.Basimyil > DateTime.Today.Year);

                    DosyaIslemleri.DosyaKaydet(path, k.KitapBilgilerini());
                    Console.WriteLine("Tamam/Devam");
                    string td = Console.ReadLine();
                    if (td.ToLower() == "t")
                    {
                        break;
                    }


                }
            }
            catch (IOException)
            {
                Console.WriteLine("Dosya Yazma Hatası!!");
            }

            catch (Exception)
            {

                Console.WriteLine("Bir hata oluştu!!");
            }

        }

       
    }

    class Kitap
    {
        public string Kitapad { get; set; }
        public string  Yazar { get; set; }
        public int Basimyil { get; set; }
        public string  Tur { get; set; }

        public string KitapBilgilerini()
        {
            return $"Kitap Adı:{this.Kitapad}\nYazar:{this.Yazar}\nBasimyil:{this.Basimyil}\nTür:{this.Tur}";
        }
    }
}

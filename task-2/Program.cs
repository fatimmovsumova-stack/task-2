using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //1ci
            Dictionary<int, string> telebeler = new Dictionary<int, string>();
            telebeler.Add(1, "Fatime");
            telebeler.Add(2, "Xanim");
            telebeler.Add(3, "Mehbube");
            telebeler.Add(4, "Zeyneb");
            telebeler.Add(5, "Zaur");

            while (true)
            {
                Console.WriteLine("\n----MENYU----");
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Telebeni ID ile axtar");
                Console.WriteLine("3.Butun telebeleri goster");
                Console.WriteLine("4.Cixis");

                Console.WriteLine("Seciminizi daxil edin: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Telebe ID:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Telebenin adi:");
                        string ad = Console.ReadLine();

                        if (telebeler.ContainsKey(id))
                        {
                            Console.WriteLine("Bu id movcuddur.");
                        }
                        else
                        {
                            telebeler.Add(id, ad);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Axtarilan telebe id-sini elave edin:");
                        int searchid = Convert.ToInt32(Console.ReadLine());

                        if (telebeler.ContainsKey(searchid))
                        {
                            Console.WriteLine("Telebenin adi: " + telebeler[searchid]);
                        }
                        else
                        {
                            Console.WriteLine("Bu ID-ye sahib telebe tapilmadi!");
                        }
                        break;

                    case 3:
                        foreach (var telebe in telebeler)
                        {
                            Console.WriteLine("ID: " + telebe.Key + "| Ad: " + telebe.Value);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Sistemden cixis edildi...");
                        return;

                    default:
                        Console.WriteLine("1-4 arasi secim edin.");
                        break;


                }



            }

            //2ci
            Console.WriteLine("Fiqurlardan birini secim:");
            Console.WriteLine("1.Daire");
            Console.WriteLine("2.Duzbucaqli");
            Console.WriteLine("3.Ucbucaq");
            Console.WriteLine("---------------");

            double sahe = 0;
            int secim1 = int.Parse(Console.ReadLine());

            switch (secim1)
            {
                case 1:
                    Console.WriteLine("dairenin radiusu: ");
                    double r = double.Parse(Console.ReadLine());
                    sahe = Math.PI * Math.Pow(r, 2);

                    break;

                case 2:
                    Console.Write("Uzunluğu daxil edin: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Eni daxil edin: ");
                    double b = double.Parse(Console.ReadLine());

                    sahe = a * b;
                    break;

                case 3:
                    Console.Write("1-ci tərəfi daxil edin: ");
                    double a1 = double.Parse(Console.ReadLine());

                    Console.Write("2-ci tərəfi daxil edin: ");
                    double b1 = double.Parse(Console.ReadLine());

                    Console.Write("3-cü tərəfi daxil edin: ");
                    double c1 = double.Parse(Console.ReadLine());

                    double s = (a1 + b1 + c1) / 2;

                    sahe = Math.Sqrt(s * (s - a1) * (s - b1) * (s - c1));
                    break;

                default:
                    Console.WriteLine("Yanlış seçim!");
                    return;
            }
            Console.WriteLine("Fiqurun sahəsi: " + Math.Round(sahe, 2));


            //3cu
            List<int> ededler = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int eded = int.Parse(Console.ReadLine());
                ededler.Add(eded);
            }
            int enboyuk = ededler[0];
            int enkicik = ededler[0];
            int cut = 0;
            int tek = 0;

            foreach (int eded in ededler)
            {
                if (eded > enboyuk)
                    enboyuk = eded;

                if (eded < enkicik)
                    enkicik = eded;

                if (eded % 2 == 0)
                    cut++;
                else
                    tek++;
            }

            Console.WriteLine("en boyuk eded: " + enboyuk);
            Console.WriteLine("en kicik eded: " + enkicik);
            Console.WriteLine("cut ededlerin sayı: " + cut);
            Console.WriteLine("tek ededlerin sayı: " + tek);

            //4cu
            Random random = new Random();

            int gizliEded = random.Next(0, 101);
            int texmin;

            do
            {
                Console.Write("ededi tapın (0-100): ");
                texmin = int.Parse(Console.ReadLine());

                if (texmin > gizliEded)
                {
                    Console.WriteLine("Daha kicik eded yaz");
                }
                else if (texmin < gizliEded)
                {
                    Console.WriteLine("Daha boyuk eded yaz");
                }
                else
                {
                    Console.WriteLine("tapdinnn!");
                }

            } while (texmin != gizliEded);
           
  

            

        }
    }
}



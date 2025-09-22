namespace Sõidukite_liidese_ul
{
    class StartClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            List<ISõiduk> sõidukid = new List<ISõiduk>(); // nimekiri ( auto / buss / jalgratas)

            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("       SÕIDUKI VALIKUMENÜÜ        ");
                Console.WriteLine("===================================");
                Console.WriteLine(" [1] Auto");
                Console.WriteLine(" [2] Jalgratas");
                Console.WriteLine(" [3] Buss");
                Console.WriteLine(" [0] Välju");
                Console.WriteLine("===================================");
                Console.Write("Sisesta oma valik: ");
                string valik = Console.ReadLine();

                if (valik == "0") break;

                switch (valik)
                {
                    case "1": // Auto
                        Console.Write("Sisesta kütusekulu l/100km: ");
                        if (!double.TryParse(Console.ReadLine(), out double kulu))
                        {
                            Console.WriteLine("Viga!");
                            continue;
                        }

                        Console.Write("Sisesta vahemaa km: ");
                        if (!double.TryParse(Console.ReadLine(), out double vahemaa))
                        {
                            Console.WriteLine("Viga");
                            continue;
                        }

                        sõidukid.Add(new Auto(kulu, vahemaa));
                        break;

                    case "2": // Jalgratas
                        Console.Write("Sisesta vahemaa km: ");
                        if (!double.TryParse(Console.ReadLine(), out double vahemaa2))
                        {
                            Console.WriteLine("Viga");
                            continue;
                        }
                        sõidukid.Add(new Jalgratas(vahemaa2));
                        break;

                    case "3": // Buss
                        Console.Write("Sisesta kütusekulu l/100km: ");
                        if (!double.TryParse(Console.ReadLine(), out double kulu2))
                        {
                            Console.WriteLine("Viga");
                            continue;
                        }

                        Console.Write("Sisesta vahemaa km: ");
                        if (!double.TryParse(Console.ReadLine(), out double vahemaa3))
                        {
                            Console.WriteLine("Viga");
                            continue;
                        }

                        Console.Write("Sisesta reisijate arv: ");
                        if (!int.TryParse(Console.ReadLine(), out int reisijad))
                        {
                            Console.WriteLine("Viga");
                            continue;
                        }

                        sõidukid.Add(new Buss(kulu2, vahemaa3, reisijad));
                        break;

                    default:
                        Console.WriteLine("Tundmatu valik ");
                        continue;
                }

                // <-- uus koht: tulemused kohe peale case'i
                Console.WriteLine("Sõidukite tulemused:");
                foreach (var s in sõidukid)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            }
        }
    }
}

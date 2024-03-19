namespace ConsoleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;

            while (restart)
            {
                Console.WriteLine("ConsoleCalc v1.2\r");
                Console.WriteLine("-----------------\n");
                Console.WriteLine("Başlamak için herhangi bir boşluk tuşuna basın.....\n");

                int num1 = 0; int num2 = 0;
                ConsoleKeyInfo okunan = Console.ReadKey();

                Console.WriteLine("1. sayıyı yaz ve enter'a tıkla! :)");
                num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("2. sayıyı yaz ve enter'a tıkla! :)");
                num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Listeden bir işlem seç:");
                Console.WriteLine("\tt - Toplama");
                Console.WriteLine("\tc - Çıkarma");
                Console.WriteLine("\tx - Çarpma");
                Console.WriteLine("\tb - Bölme");
                Console.WriteLine("Ne yapmak istersin?? ");


                switch (Console.ReadLine())
                {
                    case "t":
                        Console.WriteLine($"Sonuç: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "c":
                        Console.WriteLine($"Sonuç: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "x":
                        Console.WriteLine($"Sonuç: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "b":
                        Console.WriteLine($"Sonuç: {num1} / {num2} = " + (num1 / num2));
                        break;
                }

                Console.WriteLine("programı kullandığınız için teşekkürler! :)");
                Console.WriteLine("yeniden başlatmak için y'ye, kapatmak için z'ye basınız!");
                Console.ReadKey();
                if (okunan.Key == ConsoleKey.Z)
                {
                    restart = false;
                }

                else if (okunan.Key == ConsoleKey.Y)
                {
                    restart = true;
                }
                Console.Clear();
            }
        }
    }
}

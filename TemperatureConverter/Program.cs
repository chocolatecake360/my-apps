using System.ComponentModel.Design;

namespace TemperatureConverter
{
    internal class Program
    {
        class CelsiusToFahrenheit
        {
            static void Main(string[] args)
            {
                bool restart = true;

                while (restart)
                {
                    Console.WriteLine("Santigrattan fahrenayta için s'ye, fahrenayttan santigrata için f'ye basınız!");
                    ConsoleKeyInfo okunan = Console.ReadKey();

                    if (okunan.Key == ConsoleKey.S)
                    {
                        Console.WriteLine("antigrat derece gir: ");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        double fahrenheit = ((celsius * 9) / 5) + 32;
                        Console.WriteLine("Bu fahrenaytta şu kadar eder: " + fahrenheit);
                        Console.WriteLine("Programımızı kullandığın için teşekkürler! :)");
                        Console.WriteLine("Yeniden başlatmak için y'ye, çıkmak için z'ye basınız! :)");

                        okunan = Console.ReadKey();
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
                    else if (okunan.Key == ConsoleKey.F)
                    {
                        Console.WriteLine("ahrenayt derece gir: ");
                        double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                        double Celsius = (Fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("Bu santigratta şu kadar eder: " + Celsius);
                        Console.WriteLine("Programımızı kullandığın için teşekkürler! :)");
                        Console.WriteLine("Yeniden başlatmak için y'ye, çıkmak için z'ye basınız! :)");
                        okunan = Console.ReadKey();
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
                    else if (okunan.Key == ConsoleKey.P)
                    {
                        Console.WriteLine("EASTER EGG! SELİM'E SARIL EHE EHE");
                        Console.WriteLine("SELİM SEVGİ PUANI: SONSUZ");
                        Console.WriteLine("GELECEKTEKİ SELİM'E EASTER EGG <3");

                    }
                }
                }
            }
        }
    }


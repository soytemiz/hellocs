using System;

namespace basicsum
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

             
                Console.Write("ilk sayı gir: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("ikinci sayı gir: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("operator gir: ");
                Console.WriteLine("\t+ : topla");
                Console.WriteLine("\t- : cikar");
                Console.WriteLine("\t* : carp");
                Console.WriteLine("\t/ : böl");
                Console.Write("operator: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"sonuc: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"sonuc: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"sonuc: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"sonuc: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Gecersiz cevap");
                        break;
                }
                Console.Write("Devam edelim mi ? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Hoscakal");
            Console.ReadKey();
        }
    }
}
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kurs = 60.75m;
            decimal kom1 = 8.0m;
            decimal kom2 = 0.37m;
            var vneseno = false;
            var vidano = 0.0m;

            while (!vneseno)
            {
                Console.Write("Внесите сумму в долларах для обмена: ");
                vneseno = decimal.TryParse(Console.ReadLine(), out vidano);
            }
            var perevod = vidano * kurs;
            if (vidano > 500)
            { 
                Console.WriteLine("Внесенная сумма больше 500 долларов. Коммисия составит 0,37%.");
                Console.WriteLine("Выдано: " + (perevod - ((perevod * kom2) / 100)) + "рублей.");  
            }
            else
            {
               Console.WriteLine("Внесенная сумма меньше 500 долларов. Коммисия составит 8 рублей.");
               Console.WriteLine("Выдано: " + (perevod - kom1) + "рублей.");
            }
            
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKPiT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать на демонстрационный экзамен");
            int sum = 0;
            Console.WriteLine("Введите количество баллов за модуль Разработка, администрирование и защита баз данных");
            int bd = 0;
            while (!int.TryParse(Console.ReadLine(), out bd) || bd > 22 || bd < 0)
            {
                Console.WriteLine("Число баллов за этот модуль не должно превышать 22 баллов! Введите число баллов еще раз!");
            }
            sum += bd;
            Console.WriteLine("Введите количество баллов за модуль разработка модулей программного обеспечения для компьютерных систем");
            int cs = 0;
            while (!int.TryParse(Console.ReadLine(), out cs) || cs > 38 || cs < 0)
            {
                Console.WriteLine("Число баллов за этот модуль не должно превышать 38 баллов! Введите число баллов еще раз!");
            }
            sum += cs;
            Console.WriteLine("Введите количество баллов за модуль сопровождение и обслуживание программного обеспечения компьютерных систем");
            int obsluj = 0;
            while (!int.TryParse(Console.ReadLine(), out obsluj) || obsluj > 20 || obsluj < 0)
            {
                Console.WriteLine("Число баллов за этот модуль не должно превышать 20 баллов! Введите число баллов еще раз!");
            }
            sum += obsluj;
            if (sum >= 0 && sum <= 15)
            {
                Console.WriteLine("Сумма набранных вами баллов: " + sum + ", «2» (неудовлетворительно)");
            }
            else if (sum >= 16 && sum <= 31)
            {
                Console.WriteLine("Сумма набранных вами баллов: " + sum + ", «3» (удовлетворительно)");
            }
            else if (sum >= 32 && sum <= 55)
            {
                Console.WriteLine("Сумма набранных вами баллов: "+sum + ", оценка: «4» (хорошо)");
            }
            else if (sum >= 55 && sum <= 80)
            {
                Console.WriteLine("Сумма набранных вами баллов: " + sum + ", оценка: «5» (отлично)");
            }
            Console.ReadLine();
        }
    }
}

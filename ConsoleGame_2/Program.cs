using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleGame_2
{
    class Program
    {
        static void Main(string[] args)

        {

            Random rnd = new Random();


            Robot user = new Robot(3, 14, 4, 5);
            Robot pc = new Robot(2, 16, 4, 0);

            Console.WriteLine("Давайте сыграем! Ваша задача выжить и убить противника.");
            Console.WriteLine("Показатель здоровья вашего робота: {0}, количество патронов: {1}", user.Hp, user.Bullets);
            Console.WriteLine("Показатель здоровья робота противника: {0}, количество патронов: {1}", pc.Hp, pc.Bullets);
            Console.WriteLine("____________Начинаем!____________");


            while (user.Hp > 0 & pc.Hp > 0)
            {
                Console.Write("Что будете делать? \n 1. Выстрел \n 2. Исцеление \n 3. Купить патроны \n");

                string move = Console.ReadLine();

                switch (move)
                {
                    case "1":
                        user.Shot(pc);
                        break;
                    case "2":
                        user.Heal();
                        break;
                    case "3":
                        user.Purchase();
                        break;
                    default:
                        Console.WriteLine("Команда введена неверно! Попробуйте еще раз.\n");
                        continue;

                }

                if (pc.Hp < 0 || user.Hp < 0) break;

                pc.PcAct(user);

                Console.WriteLine("___________________________");
                Console.WriteLine("| Ваши  показатели |   Очки здоровья: {0}    Патроны: {1}", user.Hp, user.Bullets);
                Console.WriteLine("| Показатели врага |   Очки здоровья: {0}    Патроны: {1} \n", pc.Hp, pc.Bullets);


            }


            if (user.Hp <= 0) Console.WriteLine("Поражение! Противник оказался сильнее...");
            else if (pc.Hp <= 0) Console.WriteLine("Вы устранили противника! Победа!");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_2
{
    public class Robot : InterfaceObj, InterfacePc
    {
        public int Armor { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }
        public int Bullets { get; set; }
        public int Max_hp { get; set; }
        public Robot(int armor, int hp, int damage, int bullets)
        {
            Armor = armor;
            Hp = hp;
            Damage = damage;
            Bullets = bullets;
            Max_hp = hp;

        }

        public void GetInfo()
        {
            Console.WriteLine($"Броня: {Armor}  Жизнь: {Hp}  Урон: {Damage} Патроны: {Bullets}");
        }

        public void Shot(Robot def)
        {

            if (Bullets > 0)
            {
                def.Hp = def.Hp - Damage + def.Armor;
                Bullets -= 1;

            }

            else Console.WriteLine("Недостаточно патронов!");

        }

        public void Heal()
        {
            int n = 1;

            if (Hp < Max_hp)
            {
                Hp += n;
            }

            else
            {
                Console.WriteLine("У вас достаточно здоровья!");

            }
        }

        public void Purchase()
        {
            int m = 1;
            Bullets += m;
        }

        public void PcAct(Robot user)
        {
            if (Hp < 2)
            {
                Heal();
                Console.WriteLine("Противник лечится!");
            }
            else if (Bullets == 0)
            {
                Purchase();
                Console.WriteLine("Противник покупает патроны!");
            }
            else if (Bullets != 0)
            {
                Shot(user);
                Console.WriteLine("Противник стреляет!!!");
            }

        }
    }
}

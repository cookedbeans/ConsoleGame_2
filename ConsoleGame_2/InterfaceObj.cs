using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_2
{
    public interface InterfaceObj
    {
        int Armor { get; set; }
        int Hp { get; set; }
        int Damage { get; set; }
        int Bullets { get; set; }
        int Max_hp { get; set; }
        void GetInfo();
        void Shot(Robot def);
        void Heal();
        void Purchase();

    }
}

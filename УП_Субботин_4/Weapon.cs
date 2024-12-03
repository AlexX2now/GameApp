using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_Субботин_4
{
    public class Weapon
    {
        public static List<Weapon> Weaponlist = new List<Weapon>();
        public string Name;
        public int Lvl;
        public int Damage;
        public string Type_Weapon;

        public Weapon(string name, int lvl, int damage, string type_weapon){
            this.Name = name;
            this.Lvl = lvl;
            this.Damage = damage;
            this.Type_Weapon = type_weapon;
        }

        public Weapon()
        {
            this.Name = "Безымянный щит";
            this.Lvl = 1;
            this.Damage = 10;
            this.Type_Weapon = "Щит";
        }

        public string GetWeapon()
        {
            return $"{Type_Weapon}: {Name}, lvl {Lvl}, dm {Damage}";
        }

        public static Weapon operator +(Weapon a, Weapon b)
        {
            return new Weapon(a.Name + "+", ++a.Lvl, a.Damage + b.Damage, a.Type_Weapon);
        }
    }
}

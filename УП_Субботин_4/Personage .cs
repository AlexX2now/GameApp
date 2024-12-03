using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_Субботин_4
{
    public class Personage
    {
        public string Name;
        public int Lvl;
        public int Strength;
        public int Dexterity;
        public int Intellect;
        public Weapon Weapon;

        public Personage(string name, int lvl, int strenght, int dexterity, int intellect, Weapon weapon) {
            this.Name = name;
            this.Lvl = lvl;
            this.Strength = strenght;
            this.Dexterity = dexterity;
            this.Intellect = intellect;
            this.Weapon = weapon;
        }

        public Personage() {
            this.Name = "Безымянный персонаж";
            this.Lvl = 1;
            this.Strength = 1;
            this.Dexterity = 1;
            this.Intellect = 10;
        }


        public static int GetPower(int strenght, int dexterity, int intellect, int lvl, int weaponlvl, int weapondamage)
        {
            return (((strenght + dexterity + intellect) * lvl) + (weaponlvl * weapondamage));
        }

        public static string GetTitle(int power, string type_weapon)
        {
            if ( type_weapon == "Меч")
            {
                if (power < 51)
                    return "Просто мечник";
                else if (power < 101)
                    return "Хороший мечник";
                else if (power < 201)
                    return "Отличный мечник";
                else if (power < 401)
                    return "Великолепный мечник";
                else
                    return "Безупречный мечник";
            }
            else if (type_weapon == "Клинки")
            {
                if (power < 51)
                    return "Кадет";
                else if (power < 101)
                    return "Рядовой";
                else if (power < 201)
                    return "Ефрейтор";
                else if (power < 401)
                    return "Младший капрал";
                else
                    return "Капрал";
            }
            else if (type_weapon == "Щит")
            {
                if (power < 51)
                    return "Просто щитоносец";
                else if (power < 101)
                    return "Хороший щитоносец";
                else if (power < 201)
                    return "Отличный щитоносец";
                else if (power < 401)
                    return "Великолепный щитоносец";
                else
                    return "Безупречный щитоносец";
            }
            else
            {
                if (power < 51)
                    return "Просто лучник";
                else if (power < 101)
                    return "Хороший лучник";
                else if (power < 201)
                    return "Отличный лучник";
                else if (power < 401)
                    return "Великолепный лучник";
                else
                    return "Безупречный лучник";
            }
        }
    }
}

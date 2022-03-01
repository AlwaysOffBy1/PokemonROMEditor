using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonROMEditor
{
    public class Pokemon
    {
        public enum Type { Normal, Fighting, Flying, Poison, Ground, Rock, Bird, Bug, Ghost, Steel, Unknown, Fire, Water, Grass, Electric, Psychic, Ice, Dragon, Dark, Blank };

        private int number = 0;
        private int health = 0;
        private int attack = 0;
        private int defense = 0;
        private int specialAttack = 0;
        private int specialDefense = 0;
        private int speed = 0;
        private int catchRate = 0;
        private int baseXP = 0;
        private int growthRate = 0;
        private int total = 0;
        private string name = "Nullemon";
        private byte[] MASTER_ARRAY;
        private byte[] BACKUP_ARRAY;
        private Type type1, type2;

        public int Health { get { return health; } set { health = value; } }
        public int Number { get { return number; } set { number = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int Defense { get { return defense; } set { defense = value; } }
        public int SpecialAttack { get { return specialAttack; } set { specialAttack = value; } }
        public int SpecialDefense { get { return specialDefense; } set { specialDefense = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int CatchRate { get { return catchRate; } set { catchRate = value; } }
        public int BaseXP { get { return baseXP; } set { baseXP = value; } }
        public int GrowthRate { get { return growthRate; } set { growthRate = value; } }
        public String Name { get { return name; } set { name = value; } }
        public int Total { get { return health + attack + defense + specialAttack + specialDefense + speed; } set { total = value; } }
        public Type Type1 { get { return type1; } set { type1 = value; } }
        public Type Type2 { get { return type2; } set { type2 = value; } }

        public Pokemon() : this(0, "Nullemon", 1, 2, 3, 4, 5, 6) { }
        public Pokemon(byte[] b)
        {
            MASTER_ARRAY = b;
            BACKUP_ARRAY = MASTER_ARRAY;
            //Standard stats are 1:1. C# auto coverts from HEX (b is in hex) to DEC (int is in dec)
            this.Number = MASTER_ARRAY[0];
            this.Health = MASTER_ARRAY[1];
            this.Attack = MASTER_ARRAY[2];
            this.Defense = MASTER_ARRAY[3];
            this.Speed = MASTER_ARRAY[4];
            this.SpecialAttack = MASTER_ARRAY[5];
            this.SpecialDefense = MASTER_ARRAY[6];

            this.Total = this.Health + this.Attack + this.Defense + this.SpecialAttack + this.SpecialDefense + this.Speed;

            this.Type1 = ByteToType(MASTER_ARRAY[7]);
            this.Type2 = ByteToType(MASTER_ARRAY[8]);

            this.CatchRate = MASTER_ARRAY[9];
            this.BaseXP = MASTER_ARRAY[10];
            this.GrowthRate = MASTER_ARRAY[22];
        }
        public Pokemon(int num, String name, int hp, int att, int def, int spa, int spd, int spe)
        {
            this.Number = num;
            this.Name = name;
            this.Health = hp;
            this.Attack = att;
            this.Defense = def;
            this.SpecialAttack = spa;
            this.SpecialDefense = spd;
            this.Speed = spe;
            this.Total = hp + att + def + spa + spd + spe;
            //Initialize a MASTER_ARRAY, eventhough it will go unused
            if(this.MASTER_ARRAY == null)
            {
                this.MASTER_ARRAY = new byte[32];
                for (int i = 0; i < 32; i++) { MASTER_ARRAY[i] = 0; }
            }

        }

        public Type ByteToType(byte b)
        {
            switch (b)
            {
                case 0:
                    return Type.Normal;
                case 1:
                    return Type.Fighting;
                case 2:
                    return Type.Flying;
                case 3:
                    return Type.Poison;
                case 4:
                    return Type.Ground;
                case 5:
                    return Type.Rock;
                case 6:
                    return Type.Bird;
                case 7:
                    return Type.Bug;
                case 8:
                    return Type.Ghost;
                case 9:
                    return Type.Steel;
                case 13 + 6:
                    return Type.Unknown;
                case 14 + 6:
                    return Type.Fire;
                case 15 + 6:
                    return Type.Water;
                case 16 + 6:
                    return Type.Grass;
                case 17 + 6:
                    return Type.Electric;
                case 18 + 6:
                    return Type.Psychic;
                case 19 + 6:
                    return Type.Ice;
                case 20 + 6:
                    return Type.Dragon;
                case 21 + 6:
                    return Type.Dark;
                default:
                    return Type.Blank;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public interface IAttributes
    {
        int STR { get; set; }
        int DEX { get; set; }
        int CON { get; set; }
        int INT { get; set; }
        int WIS { get; set; }
        int CHA { get; set; }
    }
    public struct Trait
    {
        public Trait(string s)
        {
            description = s;
        }
        string description;
        string desc { get { return description; } }
    }
    class Race : IAttributes
    {
        public Race(int strengthBonus, int dexterityBonus, int constitutionBonus, int intelligenceBonus, int wisdomBonus, int charismaBonus, string Size, int landSpeed, int swimSpeed, int flySpeed)
        {
            strBonus = strengthBonus;
            dexBonus = dexterityBonus;
            conBonus = constitutionBonus;
            intBonus = intelligenceBonus;
            wisBonus = wisdomBonus;
            chaBonus = charismaBonus;
            size = Size;
            landspeed = landSpeed;
            swimspeed = swimSpeed;
            flyspeed = flySpeed;
        }
        private int strBonus, dexBonus, conBonus, intBonus, wisBonus, chaBonus;
        int IAttributes.STR
        {
            get { return strBonus; }
            set { strBonus = value; }
        }
        int IAttributes.DEX
        {
            get { return dexBonus; }
            set { dexBonus = value; }
        }
        int IAttributes.CON
        {
            get { return conBonus; }
            set { conBonus = value; }
        }
        int IAttributes.INT
        {
            get { return intBonus; }
            set { intBonus = value; }
        }
        int IAttributes.WIS
        {
            get { return wisBonus; }
            set { wisBonus = value; }
        }
        int IAttributes.CHA
        {
            get { return chaBonus; }
            set { chaBonus = value; }
        }

        string size;
        int landspeed, swimspeed, flyspeed;
        List<string> racialLanguages;
        List<Trait> racialTraits;

        public void AddLanguages(string [] languages)
        {
            foreach(string lang in languages)
            {
                racialLanguages.Add(lang);
            }
        }

        public void AddTraits(Trait [] traits)
        {
            foreach(Trait trait in traits)
            {
                racialTraits.Add(trait);
            }
        }
    }

    class Entity : IAttributes
    {
        private int strength, dexterity, constitution, intelligence, wisdom, charisma;
        int IAttributes.STR
        {
            get { return strength; }
            set { strength = value; }
        }
        int IAttributes.DEX
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        int IAttributes.CON
        {
            get { return constitution; }
            set { constitution = value; }
        }
        int IAttributes.INT
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        int IAttributes.WIS
        {
            get { return wisdom; }
            set { wisdom = value; }
        }
        int IAttributes.CHA
        {
            get { return charisma; }
            set { charisma = value; }
        }

        string race;
        string alignment;
        int exp;
        string[] languages;
        Trait[] traits;
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

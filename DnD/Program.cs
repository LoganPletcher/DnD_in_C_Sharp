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
    public class Trait
    {
        public Trait(string s)
        {
            description = s;
        }
        public readonly string description;
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
        public List<string> racialLanguages;
        public List<Trait> racialTraits;

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
        public Entity(int STR, int DEX, int CON, int INT, int WIS, int CHA, Race RACE, string ALIGNMENT, int EXP)
        {
            m_strength = STR;
            m_dexterity = DEX;
            m_constitution = CON;
            m_intelligence = INT;
            m_wisdom = WIS;
            m_charisma = CHA;
            m_race = RACE;
            m_alignment = ALIGNMENT;
            m_exp = EXP;
            foreach(string language in RACE.racialLanguages)
            {
                m_languages.Add(language);
            }
            foreach(Trait trait in RACE.racialTraits)
            {
                m_traits.Add(trait);
            }
        }

        private int m_strength, m_dexterity, m_constitution, m_intelligence, m_wisdom, m_charisma;
        int IAttributes.STR
        {
            get { return m_strength; }
            set { m_strength = value; }
        }
        int IAttributes.DEX
        {
            get { return m_dexterity; }
            set { m_dexterity = value; }
        }
        int IAttributes.CON
        {
            get { return m_constitution; }
            set { m_constitution = value; }
        }
        int IAttributes.INT
        {
            get { return m_intelligence; }
            set { m_intelligence = value; }
        }
        int IAttributes.WIS
        {
            get { return m_wisdom; }
            set { m_wisdom = value; }
        }
        int IAttributes.CHA
        {
            get { return m_charisma; }
            set { m_charisma = value; }
        }

        private Race m_race;
        string m_alignment;
        int m_exp;
        List<string> m_languages;
        List<Trait> m_traits;
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

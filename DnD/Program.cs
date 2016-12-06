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

    public class Dice
    {
        public Dice()
        {
            m_numberOfDice = 1;
            m_diceSize = 20;
        }
        public int m_numberOfDice;
        public int m_diceSize;

        public List<int> RollDice()
        {
            List<int> results = new List<int>();
            Random rng = new Random();
            for (int i = 1; i < m_numberOfDice; i++)
            {
                results.Add(rng.Next(1, m_diceSize + 1));
            }
            return results;
        }
    }
    public class SavingThrow
    {
        public SavingThrow(string savingThrowName)
        {
            m_savingThrowName = savingThrowName;
            m_savingThrowBonus = 0;
            m_savingThrowProficiency = false;
        }
        public string m_savingThrowName;
        public int m_savingThrowBonus;
        public bool m_savingThrowProficiency;
    }

    public class Skill
    {
        public Skill(string skillName, string abilityName)
        {
            m_skillName = skillName;
            m_skillAbility = abilityName;
        }
        public string m_skillName;
        public string m_skillAbility;
        public int m_skillBonus;
        public bool m_skillProficiency;
    }
    public class Trait
    {
        public Trait(string s)
        {
            m_description = s;
        }
        public readonly string m_description;
    }
    class Race : IAttributes
    {
        public Race(int strengthBonus, int dexterityBonus, int constitutionBonus, int intelligenceBonus, int wisdomBonus, int charismaBonus, string mSize, int landSpeed, int swimSpeed, int flySpeed)
        {
            m_strBonus = strengthBonus;
            m_dexBonus = dexterityBonus;
            m_conBonus = constitutionBonus;
            m_intBonus = intelligenceBonus;
            m_wisBonus = wisdomBonus;
            m_chaBonus = charismaBonus;
            m_size = mSize;
            m_landspeed = landSpeed;
            m_swimspeed = swimSpeed;
            m_flyspeed = flySpeed;
        }
        private int m_strBonus, m_dexBonus, m_conBonus, m_intBonus, m_wisBonus, m_chaBonus;
        public int STR
        {
            get { return m_strBonus; }
            set { m_strBonus = value; }
        }
        public int DEX
        {
            get { return m_dexBonus; }
            set { m_dexBonus = value; }
        }
        public int CON
        {
            get { return m_conBonus; }
            set { m_conBonus = value; }
        }
        public int INT
        {
            get { return m_intBonus; }
            set { m_intBonus = value; }
        }
        public int WIS
        {
            get { return m_wisBonus; }
            set { m_wisBonus = value; }
        }
        public int CHA
        {
            get { return m_chaBonus; }
            set { m_chaBonus = value; }
        }

        public string m_size;
        public int m_landspeed, m_swimspeed, m_flyspeed;
        public List<string> m_racialLanguages;
        public List<Trait> m_racialTraits;

        public void AddLanguages(string [] languages)
        {
            foreach(string lang in languages)
            {
                m_racialLanguages.Add(lang);
            }
        }

        public void AddTraits(Trait [] traits)
        {
            foreach(Trait trait in traits)
            {
                m_racialTraits.Add(trait);
            }
        }
    }

    class Entity : IAttributes
    {
        public Entity(int STR, int DEX, int CON, int INT, int WIS, int CHA, Race RACE, string ALIGNMENT, int EXP)
        {
            m_strength = STR + RACE.STR;
            m_dexterity = DEX + RACE.DEX;
            m_constitution = CON + RACE.CON;
            m_intelligence = INT + RACE.INT;
            m_wisdom = WIS + RACE.WIS;
            m_charisma = CHA + RACE.CHA;
            m_race = RACE;
            m_alignment = ALIGNMENT;
            m_exp = EXP;
            foreach(string language in RACE.m_racialLanguages)
            {
                m_languages.Add(language);
            }
            foreach(Trait trait in RACE.m_racialTraits)
            {
                m_traits.Add(trait);
            }
        }

        private int m_strength, m_dexterity, m_constitution, m_intelligence, m_wisdom, m_charisma;
        public int STR
        {
            get { return m_strength; }
            set { m_strength = value; }
        }
        public int DEX
        {
            get { return m_dexterity; }
            set { m_dexterity = value; }
        }
        public int CON
        {
            get { return m_constitution; }
            set { m_constitution = value; }
        }
        public int INT
        {
            get { return m_intelligence; }
            set { m_intelligence = value; }
        }
        public int WIS
        {
            get { return m_wisdom; }
            set { m_wisdom = value; }
        }
        public int CHA
        {
            get { return m_charisma; }
            set { m_charisma = value; }
        }

        private Race m_race;
        private string m_alignment;
        private int m_exp;
        private List<string> m_languages;
        private List<Trait> m_traits;
    }

    class Class
    {
        public int m_classLevel;
        public int m_proficiencyBonus;
        public int m_specialClassPoints;      //Like Ki Points for Monk or Rage for Barbarians
        public Dice m_specialClassDice;       //Like Martial Arts for Monk or Sneak Attack for Rogues
        public Dice m_specialClassDiceTwo;    //Like Song of Rest for Bards
        public int m_cantripsKnown;
        public int m_spellsKnown;
        public int[] m_spellSlotsperSpellLevel = new int[9];
        public int m_hitPoints;
        public Dice m_hitDice;
        public List<string> m_armorProficiencies;
        public List<string> m_weaponProficiencies;
        public List<string> m_toolProficiencies;
        public string[] m_savingThrows = new string[2];
        public List<string> m_classSkills;
        public List<Trait> m_classFeatures;
        public List<Trait> m_spells;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

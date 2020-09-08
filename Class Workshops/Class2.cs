using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Workshops
{
    class Class2
    {
        public string CharacterName; public int CharacterLevel; public string CharacterRace; public double HitPoints; public string CharacterClass;
        public bool inGuild;

        public void CharacterSelect()
        {
            if (CharacterLevel >= 100)
            {
                Console.WriteLine($"Welcome {CharacterName}. You are mighty {CharacterClass}, of the {CharacterRace} people. You must be a hard one to defeat with {HitPoints} hit points.");

            }
            else if (CharacterLevel >= 50)
            { 
            
            }
        }




    }

}

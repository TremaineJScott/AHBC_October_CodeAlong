using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AhbcOctoberWeekSix
{
    class Character
    {
        private string characterName;
        public string CharacterName
        {
            get { return characterName; }
            set
            {
                if (ValidateName(value) == false)
                {
                    characterName = "invald";
                }
                else
                {
                    characterName = value;
                }
            }
        }
        public List<Character> CharacterList = new List<Character>();
        public Character ReturnFirstCharacterAlphabetically()
        {
            return CharacterList.OrderBy(x => x.CharacterList).First();
        }
        private bool ValidateName(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexTester
{
    public class CharacterBank
    {
        private List<string> characters;

        public CharacterBank()
        {
              characters = new List<string>()
           {"a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        }

        public string GetCharacter()
        {
            Random random = new Random();
                int index = random.Next(characters.Count);

                return characters[index];
        }
    }
}

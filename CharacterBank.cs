using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexTester
{
    public class CharacterBank
    {
        public List<string> characters;
        public string fromGetCharacter1;
        public char fromGetCharacter2;

        public CharacterBank()
        {
              characters = new List<string>()
           {"a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        }

        public string GetCharacter()
        {
            Random random = new Random();
                int index = random.Next(characters.Count);
                Console.WriteLine("Your letter is shown below:\n\n");
                Console.WriteLine(characters[index]);
                fromGetCharacter1 = characters[index];
            fromGetCharacter2 = char.Parse(fromGetCharacter1);
                
                return characters[index];
            
            
                
        }
    }
}

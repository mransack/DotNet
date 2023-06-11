using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class HashSetExample
    {
        public static void CountUniqueCharacters(string input)
        { 
            Console.WriteLine(input);
            HashSet<char> set = new HashSet<char>();
            int count = 0;
            foreach (char c in input)
            {
                if (!set.Contains(c))
                {
                    set.Add(c);
                    count++;
                }
            }
            Console.WriteLine(" " + count);
        }
        public record class Sample(char Ch, int count);

        public static void CountUniqueCharactersPresence(string input)
        {
            Hashtable hashTable = new Hashtable();

            foreach (char c in input)
            {
                if (hashTable.ContainsKey(c))
                {
                    var tmpcount = (int)(hashTable[c] ?? 0);
                    hashTable.Remove(c);
                    hashTable.Add(c, tmpcount + 1);
                }
                else 
                {
                    hashTable.Add(c, 1);
                }
            }
            foreach (DictionaryEntry item in hashTable)
            { 
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }

        public static void CountUniqueCharatersWithDictionary(string input)
        { 
            Dictionary<char, int> characs = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (characs.ContainsKey(c))
                {
                    int tmpCount = characs[c];
                    characs.Remove(c);
                    characs.Add(c, tmpCount+1);
                }
                else 
                {
                    characs.Add(c, 1);
                }
            }
            Console.WriteLine("");
            foreach (KeyValuePair<char, int> item in characs)
            {
                //Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }

            var res = input.GroupBy(c => c).Select(x => new
            {
                A = x.FirstOrDefault(),
                V = x.Count()
            }).ToList();
            res.ForEach(x => Console.WriteLine("{0}: {1}", x.A , x.V));
        }
    }
}

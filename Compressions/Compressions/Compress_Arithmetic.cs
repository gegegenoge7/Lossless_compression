using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Compressions
{
    class Compress_Arithmetic
    {
        private List<char_freq> frequency_list;

        public void compress_with_Arith(string InputFilename, string OutputFilename)
        {
            frequency_list = new List<char_freq>();
            string fileString = File.ReadAllText(InputFilename);
            create_char_freq(fileString);
            
        }
        private void create_char_freq(string fileString)
        {
            foreach (char c in fileString)
            {
                bool found = false;
                foreach (char_freq entry in frequency_list)
                {
                    if (entry.ID == c)
                    {
                        found = true;
                        entry.Count++;
                    }
                }
                if (!found)
                {
                    char_freq newEntry = new char_freq(c);
                    frequency_list.Add(newEntry);
                }
            }
        }
    }
}

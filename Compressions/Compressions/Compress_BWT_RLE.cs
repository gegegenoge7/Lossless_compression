using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Compressions
{
    class Compress_BWT_RLE
    {
        public void compress_with_BWT_RLE(string InputFilename, string OutputFilename)
        {
            string fileString = File.ReadAllText(InputFilename);
            List<string> fileStrings_rotated = new List<string>();
            rotate_strings(fileStrings_rotated, fileString);
            fileStrings_rotated.Sort();
            string coded_string = "";
            foreach (string entry in fileStrings_rotated)
            {
                coded_string += entry[entry.Length - 1];
            }
            List<char_freq> compressed_freq = new List<char_freq>();
            compressed_freq = compress(coded_string, '\0', compressed_freq);
            StringBuilder compressed_fileString = new StringBuilder();
            foreach (char_freq count in compressed_freq)
            {
                compressed_fileString.Append(count.ID + count.Count + "_");
            }
            File.WriteAllText(OutputFilename, compressed_fileString.ToString());
        }
        private void rotate_strings(List<string> fileStrings_rotated, string fileString)
        {
            for (int i = 0; i < fileString.Length; i++)
            {
                char lastchar = fileString[fileString.Length-1];
                fileString.TrimEnd();
                fileString = lastchar + fileString;
                fileStrings_rotated.Add(fileString);
            }
        }
        private List<char_freq> compress(string coded_string, char last_char, List<char_freq> counted_char)
        {
            if (0 == coded_string.Length)
            {
                return counted_char;
            }
            else
            {
                if (last_char == coded_string[0])
                {
                    counted_char[counted_char.Count - 1].Count += 1;
                }
                else
                {
                    char_freq newEntry = new char_freq(coded_string[0], 1);
                    counted_char.Add(newEntry);
                }
                return compress(coded_string.Remove(0, 1), last_char, counted_char);
            }
        }
        public void uncompress_with_BWT_RLE(string InputFilename, string OutputFilename)
        {
            string fileString = File.ReadAllText(InputFilename);
            string[] fileStringSplit = fileString.Split('_');

            StringBuilder UncompressedFileString = new StringBuilder();
            char entry_char = '\0';
            foreach (string entry in fileStringSplit)
            {
                entry_char = entry[0];
                int num = Convert.ToInt32(entry.TrimStart());
                for (int i = 0; i < num; i++)
                {
                    UncompressedFileString.Append(entry_char);
                }
            }


        }
    }
}

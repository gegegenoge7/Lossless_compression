/******************************************************************************
 * Name: Compress_RLE.cs
 * Made By: Hayato Yokoyama
 * This class will be called via compress_with_RLE, and will compress the 
 * file via RLE. It will read the file in binary, and will convert it into a
 * text file with a string that represents how many 1's and 0's there were,
 * starting with the number of 0's.
 * The runtime of this program is O(n), n being the number of bits in the file.
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Compressions
{
    class Compress_RLE
    {
        public void compress_with_RLE(string InputFilename, string OutputFilename) {
            byte[] fileBytes = File.ReadAllBytes(InputFilename);
            StringBuilder string_fileBytes = new StringBuilder();
            foreach (byte b in fileBytes) {
                string_fileBytes.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            List<int> counted_binary = new List<int>();
            counted_binary.Add(0);
            counted_binary = compress(string_fileBytes, 0, counted_binary);
            StringBuilder compressed_fileBytes = new StringBuilder();
            foreach (int count in counted_binary) {
                compressed_fileBytes.Append(count.ToString() + "_");
            }
            File.WriteAllText(OutputFilename, compressed_fileBytes.ToString());
        }
        private List<int> compress(StringBuilder string_fileBytes, int last_binary, List<int> counted_binary) {
            StringBuilder compressed_fileBytes = new StringBuilder();
            if (0 == string_fileBytes.Length)
            {
                return counted_binary;
            }
            else {
                if (last_binary == 0) {
                    if (string_fileBytes[0] == '0') {
                        counted_binary[counted_binary.Count - 1] += 1;
                    }
                    else {
                        counted_binary.Add(1);
                    }
                }
                else {
                    if (string_fileBytes[0] == '0')
                    {
                        counted_binary[counted_binary.Count - 1] += 1;
                    }
                    else
                    {
                        counted_binary.Add(1);
                    }
                }
                return compress(string_fileBytes.Remove(0,1), last_binary, counted_binary);
            }
        }
    }
}

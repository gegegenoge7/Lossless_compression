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
        void compress_with_RLE(string InputFilename, string OutputFilename) {
            byte[] fileBytes = File.ReadAllBytes(InputFilename);
            StringBuilder string_fileBytes = new StringBuilder();
            foreach (byte b in fileBytes) {
                string_fileBytes.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            List<int> counted_binary = new List<int>();
            counted_binary.Add(0);
            counted_binary = compress(string_fileBytes, 0, counted_binary);
            StringBuilder compressed_fileBytes = new StringBuilder();
            bool binary = false;
            foreach (int count in counted_binary) {
                string IntConversion = (binary ? 1 : 0).ToString();
                compressed_fileBytes.Append(IntConversion + count.ToString());
            }
            File.WriteAllText(OutputFilename, compressed_fileBytes.ToString());
        }
        List<int> compress(StringBuilder string_fileBytes, int last_binary, List<int> counted_binary) {
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
                return compress(string_fileBytes, last_binary, counted_binary);
            }
        }
    }
}

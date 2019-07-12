using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Compressions
{
    class Compress_Huffman
    {
        void compress_with_Huffman(string InputFilename, string OutputFilename)
        {
            StringBuilder compressed_fileString = new StringBuilder();
            List<char_freq>
            string fileString = File.ReadAllText(InputFilename);
            File.WriteAllText(OutputFilename, compressed_fileBytes.ToString());
        }
    }
}

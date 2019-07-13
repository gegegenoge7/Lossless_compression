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
        private List<char_freq> frequency_list;
        private byte[] compressed_fileByte;
        private StringBuilder compressed_binary_string;

        void compress_with_Huffman(string InputFilename, string OutputFilename)
        {
            frequency_list = new List<char_freq>();
            string fileString = File.ReadAllText(InputFilename);
            byte[] fileByte = File.ReadAllBytes(InputFilename);
            create_char_freq(fileString);
            char_freq root = create_huffman_tree();
            compress(fileString, root);
            StringBuilder String_rep_tree = convert_tree();
            int numBytes = compressed_binary_string.ToString().Length / 8;
            compressed_fileByte = new byte[numBytes];
            for (int i = 0; i < numBytes; ++i)
            {
                compressed_fileByte[i] = Convert.ToByte(compressed_binary_string.ToString().Substring(8 * i, 8), 2);
            }
            File.WriteAllBytes(OutputFilename, compressed_fileByte);
            File.AppendAllText(OutputFilename, String_rep_tree.ToString());
        }
        void create_char_freq(string fileString)
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
        char_freq create_huffman_tree()
        {
            frequency_list = frequency_list.OrderBy(f => f.Count).ToList();
            char_freq root = new char_freq();
            int index = 0;
            while (index+1 < frequency_list.Count())
            {
                char_freq newNode = new char_freq(frequency_list[index], frequency_list[index+1]);
                frequency_list.Add(newNode);//add to correct place
                root = newNode;
                index += 2;
            }
            return root;
        }
        void compress(string fileString, char_freq root)
        {
            compressed_binary_string = new StringBuilder();
            foreach (char c in fileString)
            {

                char_freq node = frequency_list.Find(f => f.ID == c);
                while (node != root)
                {
                    char_freq tempNode = node.ParentNode;
                    if (tempNode.LeftNode == node)
                    {
                        compressed_binary_string.Append('1');
                    }
                    if (tempNode.RightNode == node)
                    {
                        compressed_binary_string.Append('0');
                    }
                    node = tempNode;
                }
            }
        }
        void convert_tree()
        {

        }
    }
}

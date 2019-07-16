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

        public void compress_with_Huffman(string InputFilename, string OutputFilename)
        {
            frequency_list = new List<char_freq>();
            string fileString = File.ReadAllText(InputFilename);
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
            File.WriteAllText("HuffmanTreeData_" + OutputFilename, String_rep_tree.ToString());
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
        private char_freq create_huffman_tree()
        {
            frequency_list = frequency_list.OrderBy(f => f.Count).ToList();
            char_freq root = new char_freq();
            int index = 0;
            int Num_entries = frequency_list.Count();
            while (index+1 < Num_entries)
            {
                char_freq newNode = new char_freq(frequency_list[index], frequency_list[index+1], frequency_list);
                frequency_list.Add(newNode);//add to correct place
                root = newNode;
                index += 2;
                Num_entries = frequency_list.Count();
            }
            return root;
        }
        private void compress(string fileString, char_freq root)
        {
            compressed_binary_string = new StringBuilder();
            foreach (char c in fileString)
            {
                char_freq node = frequency_list.Find(f => f.ID == c);
                string tempString = "";
                while (node != root)
                {
                    char_freq tempNode = frequency_list[node.ParentNodeIndex];
                    if (frequency_list[tempNode.LeftNodeIndex] == node)
                    {
                        tempString = '1' + tempString;
                    }
                    if (frequency_list[tempNode.RightNodeIndex] == node)
                    {
                        tempString = '0' + tempString;
                    }
                    node = tempNode;
                }
                compressed_binary_string.Append(tempString);
            }
        }
        private StringBuilder convert_tree()
        {
            StringBuilder treeString = new StringBuilder();
            int index = 0;
            foreach (char_freq entry in frequency_list)
            {
                treeString.AppendLine(index + "," + entry.ID + "," + entry.Count + "," + entry.ParentNodeIndex + "," + entry.LeftNodeIndex + "," + entry.RightNodeIndex);
                index++;
            }
            return treeString;
        }
        private void Uncompress_with_Huffman(string InputFilename, string InputTreeFilename, string OutputFilename)
        {
            byte[] CompressedFileByte = File.ReadAllBytes(InputFilename);
            string[] Huffman_tree = File.ReadAllLines(InputTreeFilename);

            frequency_list = new List<char_freq>();
            foreach (string Huffman_node in Huffman_tree)
            {
                string[] node_info = Huffman_node.Split(',');
                char_freq newNode = new char_freq();//add correctly
                frequency_list.Add(newNode);
            }
            int index = 0;
            StringBuilder CompressedByteString = new StringBuilder();
            foreach (byte b in CompressedFileByte)
            {
                CompressedByteString.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            StringBuilder Uncompressed_fileString = new StringBuilder();
            char_freq traversal = ;//find root - make variable so that we know the type of node it is - add node, char node, or root node
            while (index < CompressedByteString.Length)
            {
                if ((traversal.LeftNodeIndex == ) && (traversal.RightNodeIndex == ))//if this is a edge node
                {
                    Uncompressed_fileString.Append(traversal.ID);
                }
                if (CompressedByteString[index] == '1')
                {
                    traversal = frequency_list[traversal.RightNodeIndex];
                    index++;
                }
                else
                {
                    traversal = frequency_list[traversal.LeftNodeIndex];
                    index++;
                }
            }
        }
    }
}

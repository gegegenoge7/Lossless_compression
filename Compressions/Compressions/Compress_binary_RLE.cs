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
    class Compress_binary_RLE
    {
        /****This method will be called from the form to compress the input file into the outputfile****/
        public void compress_with_RLE(string InputFilename, string OutputFilename) {
            //read input file as bytes
            byte[] fileBytes = File.ReadAllBytes(InputFilename);
            StringBuilder string_fileBytes = new StringBuilder();
            foreach (byte b in fileBytes) {
                string_fileBytes.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            //count the repeating 0 and 1's, but assume that we start from a 0.
            List<int> counted_binary = new List<int>();//this will be the list of repeating binary - assumes first entry is the number of repeating 0's
            counted_binary.Add(0);
            counted_binary = compress(string_fileBytes, '0', counted_binary);

            //convert the list of repeating binary into number followed by an underscore
            StringBuilder compressed_fileBytes = new StringBuilder();
            foreach (int count in counted_binary) {
                compressed_fileBytes.Append(count.ToString() + "_");
            }
            File.WriteAllText(OutputFilename, compressed_fileBytes.ToString());
        }

        /****This recursive method will be called by compress_with_RLE and by itself to convert the binary string representation of the file into a list of numbmer of repeating binary****/
        private List<int> compress(StringBuilder string_fileBytes, char last_binary, List<int> counted_binary) {
            if (0 == string_fileBytes.Length)//end condition
            {
                return counted_binary;
            }
            else {
                if (last_binary == string_fileBytes[0])//if the binary before matches this one
                {
                    counted_binary[counted_binary.Count - 1] += 1;//add to ount of repeated binary
                }
                else
                {
                    counted_binary.Add(1);//if not, the streak is broken - create new entry to list
                }
                last_binary = string_fileBytes[0];//update last binary
                return compress(string_fileBytes.Remove(0,1), last_binary, counted_binary);//keep calling the method while shaving off one char in the string at a time
            }
        }
        /****This method will be called from the form to unocmpress the file compressed by this method****/
        public void uncompress_with_RLE(string InputFilename, string OutputFilename)
        {
            //read all text and split it by the underscore to get an array of string integers
            string fileString = File.ReadAllText(InputFilename);
            string[] fileStringSplit = fileString.Split('_');

            //build the binary representation of the file by keep on appending the appropriate binary for each count
            StringBuilder UncompressedFileString = new StringBuilder();
            bool binaryBool = false;
            foreach (string entry in fileStringSplit)
            {
                int binary = binaryBool ? 1 : 0;
                int num = Convert.ToInt32(entry);
                for (int i = 0; i < num; i++)
                {
                    UncompressedFileString.Append(binary);
                }
                binaryBool = !binaryBool;
            }

            //convert the binary string into array of bytes
            int numBytes = UncompressedFileString.ToString().Length / 8;
            byte[] Uncompressed_fileByte = new byte[numBytes];
            for (int i = 0; i < numBytes; ++i)
            {
                Uncompressed_fileByte[i] = Convert.ToByte(UncompressedFileString.ToString().Substring(8 * i, 8), 2);
            }

            File.WriteAllBytes(OutputFilename, Uncompressed_fileByte);
        }
    }
}

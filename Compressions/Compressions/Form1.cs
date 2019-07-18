using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            string inputFile = this.Input_file_textBox.Text;
            string outputFile = this.Output_file_textBox.Text;
            if (this.option_compress_comboBox.Text == "Compress")
            {
                if (this.option_algorithm_textbox.Text == "RLE(binary)")
                {
                    Compress_binary_RLE newProcess = new Compress_binary_RLE();
                    newProcess.compress_with_RLE(inputFile, outputFile);
                }
                else if (this.option_algorithm_textbox.Text == "RLE(BWT)")
                {
                    Compress_BWT_RLE newProcess = new Compress_BWT_RLE();
                    newProcess.compress_with_BWT_RLE(inputFile, outputFile);
                }
                else if (this.option_algorithm_textbox.Text == "Huffman Coding")
                {
                    Compress_Huffman newProcess = new Compress_Huffman();
                    newProcess.compress_with_Huffman(inputFile, outputFile);
                }
                else if (this.option_algorithm_textbox.Text == "Arithmetic Coding")
                {
                    Compress_Arithmetic newProcess = new Compress_Arithmetic();
                    newProcess.compress_with_Arith(inputFile, outputFile);
                }
            }
            else if (this.option_compress_comboBox.Text == "Uncompress")
            {
                if (this.option_algorithm_textbox.Text == "RLE(binary)")
                {
                    Compress_binary_RLE newProcess = new Compress_binary_RLE();
                    newProcess.compress_with_RLE(inputFile, outputFile);
                }
                else if (this.option_algorithm_textbox.Text == "RLE(BWT)")
                {
                    Compress_BWT_RLE newProcess = new Compress_BWT_RLE();
                    newProcess.compress_with_BWT_RLE(inputFile, outputFile);
                }
                else if (this.option_algorithm_textbox.Text == "Huffman Coding")
                {
                    Compress_Huffman newProcess = new Compress_Huffman();
                    newProcess.compress_with_Huffman(inputFile, outputFile);
                }
                else if (this.option_algorithm_textbox.Text == "Arithmetic Coding")
                {
                    Compress_Arithmetic newProcess = new Compress_Arithmetic();
                    newProcess.compress_with_Arith(inputFile, outputFile);
                }
            }
        }
    }
}

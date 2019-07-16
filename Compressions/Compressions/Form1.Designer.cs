namespace Compressions
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input_browse_button = new System.Windows.Forms.Button();
            this.browse_output_button = new System.Windows.Forms.Button();
            this.input_file_label = new System.Windows.Forms.Label();
            this.output_folder_label = new System.Windows.Forms.Label();
            this.Input_file_textBox = new System.Windows.Forms.TextBox();
            this.Output_file_textBox = new System.Windows.Forms.TextBox();
            this.c_RLE_binary_button = new System.Windows.Forms.Button();
            this.c_RLE_BWT_button = new System.Windows.Forms.Button();
            this.c_huffman_button = new System.Windows.Forms.Button();
            this.c_arithmetic_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_browse_button
            // 
            this.Input_browse_button.Location = new System.Drawing.Point(665, 99);
            this.Input_browse_button.Name = "Input_browse_button";
            this.Input_browse_button.Size = new System.Drawing.Size(75, 23);
            this.Input_browse_button.TabIndex = 0;
            this.Input_browse_button.Text = "Browse...";
            this.Input_browse_button.UseVisualStyleBackColor = true;
            this.Input_browse_button.Click += new System.EventHandler(this.Input_browse_button_Click);
            // 
            // browse_output_button
            // 
            this.browse_output_button.Location = new System.Drawing.Point(665, 157);
            this.browse_output_button.Name = "browse_output_button";
            this.browse_output_button.Size = new System.Drawing.Size(75, 23);
            this.browse_output_button.TabIndex = 1;
            this.browse_output_button.Text = "Browse...";
            this.browse_output_button.UseVisualStyleBackColor = true;
            // 
            // input_file_label
            // 
            this.input_file_label.AutoSize = true;
            this.input_file_label.Location = new System.Drawing.Point(63, 102);
            this.input_file_label.Name = "input_file_label";
            this.input_file_label.Size = new System.Drawing.Size(122, 17);
            this.input_file_label.TabIndex = 2;
            this.input_file_label.Text = "File To Compress:";
            this.input_file_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // output_folder_label
            // 
            this.output_folder_label.AutoSize = true;
            this.output_folder_label.Location = new System.Drawing.Point(63, 160);
            this.output_folder_label.Name = "output_folder_label";
            this.output_folder_label.Size = new System.Drawing.Size(168, 17);
            this.output_folder_label.TabIndex = 3;
            this.output_folder_label.Text = "Save Compressed file as:";
            // 
            // Input_file_textBox
            // 
            this.Input_file_textBox.Location = new System.Drawing.Point(183, 99);
            this.Input_file_textBox.Name = "Input_file_textBox";
            this.Input_file_textBox.Size = new System.Drawing.Size(476, 22);
            this.Input_file_textBox.TabIndex = 4;
            // 
            // Output_file_textBox
            // 
            this.Output_file_textBox.Location = new System.Drawing.Point(229, 157);
            this.Output_file_textBox.Name = "Output_file_textBox";
            this.Output_file_textBox.Size = new System.Drawing.Size(430, 22);
            this.Output_file_textBox.TabIndex = 5;
            // 
            // c_RLE_binary_button
            // 
            this.c_RLE_binary_button.Location = new System.Drawing.Point(128, 281);
            this.c_RLE_binary_button.Name = "c_RLE_binary_button";
            this.c_RLE_binary_button.Size = new System.Drawing.Size(75, 55);
            this.c_RLE_binary_button.TabIndex = 6;
            this.c_RLE_binary_button.Text = "RLE (binary)";
            this.c_RLE_binary_button.UseVisualStyleBackColor = true;
            // 
            // c_RLE_BWT_button
            // 
            this.c_RLE_BWT_button.Location = new System.Drawing.Point(270, 281);
            this.c_RLE_BWT_button.Name = "c_RLE_BWT_button";
            this.c_RLE_BWT_button.Size = new System.Drawing.Size(75, 55);
            this.c_RLE_BWT_button.TabIndex = 7;
            this.c_RLE_BWT_button.Text = "RLE (BWT)";
            this.c_RLE_BWT_button.UseVisualStyleBackColor = true;
            // 
            // c_huffman_button
            // 
            this.c_huffman_button.Location = new System.Drawing.Point(411, 281);
            this.c_huffman_button.Name = "c_huffman_button";
            this.c_huffman_button.Size = new System.Drawing.Size(75, 55);
            this.c_huffman_button.TabIndex = 8;
            this.c_huffman_button.Text = "Huffman Coding";
            this.c_huffman_button.UseVisualStyleBackColor = true;
            // 
            // c_arithmetic_button
            // 
            this.c_arithmetic_button.Location = new System.Drawing.Point(562, 281);
            this.c_arithmetic_button.Name = "c_arithmetic_button";
            this.c_arithmetic_button.Size = new System.Drawing.Size(80, 55);
            this.c_arithmetic_button.TabIndex = 9;
            this.c_arithmetic_button.Text = "Arithmetic Coding";
            this.c_arithmetic_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 389);
            this.Controls.Add(this.c_arithmetic_button);
            this.Controls.Add(this.c_huffman_button);
            this.Controls.Add(this.c_RLE_BWT_button);
            this.Controls.Add(this.c_RLE_binary_button);
            this.Controls.Add(this.Output_file_textBox);
            this.Controls.Add(this.Input_file_textBox);
            this.Controls.Add(this.output_folder_label);
            this.Controls.Add(this.input_file_label);
            this.Controls.Add(this.browse_output_button);
            this.Controls.Add(this.Input_browse_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Input_browse_button;
        private System.Windows.Forms.Button browse_output_button;
        private System.Windows.Forms.Label input_file_label;
        private System.Windows.Forms.Label output_folder_label;
        private System.Windows.Forms.TextBox Input_file_textBox;
        private System.Windows.Forms.TextBox Output_file_textBox;
        private System.Windows.Forms.Button c_RLE_binary_button;
        private System.Windows.Forms.Button c_RLE_BWT_button;
        private System.Windows.Forms.Button c_huffman_button;
        private System.Windows.Forms.Button c_arithmetic_button;
    }
}


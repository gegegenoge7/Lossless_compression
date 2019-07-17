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
            this.option_compress_comboBox = new System.Windows.Forms.ComboBox();
            this.option_compress_label = new System.Windows.Forms.Label();
            this.option_algorithm_textbox = new System.Windows.Forms.ComboBox();
            this.choose_algorithm_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
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
            this.browse_output_button.Click += new System.EventHandler(this.browse_output_button_Click);
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
            // option_compress_comboBox
            // 
            this.option_compress_comboBox.FormattingEnabled = true;
            this.option_compress_comboBox.Items.AddRange(new object[] {
            "Compress",
            "Uncompress"});
            this.option_compress_comboBox.Location = new System.Drawing.Point(244, 32);
            this.option_compress_comboBox.Name = "option_compress_comboBox";
            this.option_compress_comboBox.Size = new System.Drawing.Size(121, 24);
            this.option_compress_comboBox.TabIndex = 10;
            // 
            // option_compress_label
            // 
            this.option_compress_label.AutoSize = true;
            this.option_compress_label.Location = new System.Drawing.Point(63, 35);
            this.option_compress_label.Name = "option_compress_label";
            this.option_compress_label.Size = new System.Drawing.Size(175, 17);
            this.option_compress_label.TabIndex = 11;
            this.option_compress_label.Text = "Compress or Uncompress:";
            // 
            // option_algorithm_textbox
            // 
            this.option_algorithm_textbox.FormattingEnabled = true;
            this.option_algorithm_textbox.Items.AddRange(new object[] {
            "RLE (binary)",
            "RLE (BWT)",
            "Huffman Coding",
            "Arithmetic Coding"});
            this.option_algorithm_textbox.Location = new System.Drawing.Point(229, 209);
            this.option_algorithm_textbox.Name = "option_algorithm_textbox";
            this.option_algorithm_textbox.Size = new System.Drawing.Size(275, 24);
            this.option_algorithm_textbox.TabIndex = 12;
            // 
            // choose_algorithm_label
            // 
            this.choose_algorithm_label.AutoSize = true;
            this.choose_algorithm_label.Location = new System.Drawing.Point(63, 212);
            this.choose_algorithm_label.Name = "choose_algorithm_label";
            this.choose_algorithm_label.Size = new System.Drawing.Size(157, 17);
            this.choose_algorithm_label.TabIndex = 13;
            this.choose_algorithm_label.Text = "Compression Algorithm:";
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(292, 276);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(230, 65);
            this.start_button.TabIndex = 14;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 389);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.choose_algorithm_label);
            this.Controls.Add(this.option_algorithm_textbox);
            this.Controls.Add(this.option_compress_label);
            this.Controls.Add(this.option_compress_comboBox);
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
        private System.Windows.Forms.ComboBox option_compress_comboBox;
        private System.Windows.Forms.Label option_compress_label;
        private System.Windows.Forms.ComboBox option_algorithm_textbox;
        private System.Windows.Forms.Label choose_algorithm_label;
        private System.Windows.Forms.Button start_button;
    }
}


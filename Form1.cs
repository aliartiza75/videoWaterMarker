using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YoutubeVideoUploader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(".mp4");
            comboBox1.Items.Add(".mkv");
            comboBox1.Items.Add(".avi");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                label1.Text = "";
                // Dialog to select folder where videos are placed
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select folder where videos are placed";
                DialogResult result = fbd.ShowDialog();



                // Output Folder to place videos
                FolderBrowserDialog fbd2 = new FolderBrowserDialog();
                fbd2.Description = "Select the folder where you wanna place the videos";
                DialogResult result2 = fbd2.ShowDialog();

                /////////////////////////////////////

                // Displays an OpenFileDialog so the user can select a Python Files
                /* OpenFileDialog openFileDialog1 = new OpenFileDialog();
                //openFileDialog1.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
                openFileDialog1.Filter = "Python Files|*.py";
                openFileDialog1.Title = "Python file containing watermarking code";
                openFileDialog1.ShowDialog();
                string pythonFile = openFileDialog1.FileName.ToString();


                // TO select the Python Exe file
                //openFileDialog1.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
                openFileDialog1.Filter = "Exe Files|*.exe";
                openFileDialog1.Title = "Python .exe File";
                openFileDialog1.ShowDialog();
                string pythonExeFile = openFileDialog1.FileName.ToString();
                */
                // video formats
                /////////////////////////////////////


                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);
                    //                string[] files = Directory.GetFiles(@fbd.SelectedPath, "*.mp4");

                    //string[] extensions = { ".mp4", ".mkv", ".avi"};
                    string[] extensions = { comboBox1.SelectedItem.ToString() };
                    string[] files = Directory.GetFiles(@fbd.SelectedPath, "*.*")
                        .Where(f => extensions.Contains(System.IO.Path.GetExtension(f).ToLower())).ToArray();

                    // C: \Users\john\gcc\bin
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\file_names.txt"))
                    {


                        // If the line doesn't contain the word 'Second', write the line to the file.

                        file.WriteLine(fbd.SelectedPath.ToString()); // folder path
                        file.WriteLine(comboBox1.SelectedItem.ToString());
                        file.WriteLine(textBox1.Text.ToString()); // Text to be written on video
                        file.WriteLine(fbd2.SelectedPath.ToString()); // Text to be written on video

                    }  // end

                    /// Python COde 
                    /// 

                    // Selected files from the directory
                    int i = 0;
                    foreach (string file in files)
                    {

                        richTextBox1.Text += "################# Video #" + ++i + " ############\n";
                        richTextBox1.Text += file.ToString() + "\n"; // Showing status
                                                                     ////////////////////////////////////////
                        i++;

                    } // foreach end

                    // Executing python file using batch code
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = @"C:\Users\1.bat";
                    proc.Start();
                    label1.Text = "Done";



                    ////////////////////////////////
                }
            }
            else
            {
                label1.Text = "Please select a video format";
            }




           
            //Display result 
        } // function end
    }
}

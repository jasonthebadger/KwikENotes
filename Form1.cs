using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Kwik_E_Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "kwk files (*.kwk)|*.kwk";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
                file.WriteLine(KENtextbox.Text);
                file.Close();
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "kwk files (*.kwk)|*.kwk";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog1.FileName);
                KENtextbox.Text = text;


            }
        }
    }
}

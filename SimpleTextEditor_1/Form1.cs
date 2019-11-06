using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleTextEditor_1
{
    public partial class Form1 : Form
    {
        private string _name;
        private string _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = _defaultPath;
            saveFileDialog1.InitialDirectory = _defaultPath;
        }

        private void openButton_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(_name);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _name = saveFileDialog1.FileName;
                File.WriteAllText(_name, textBox1.Text);
            }
        }
    }
}

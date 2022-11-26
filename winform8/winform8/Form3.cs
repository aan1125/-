using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winform8
{
    public partial class Form3 : Form
    {

     
        public Form3()
        {
            InitializeComponent();
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var sr = new StreamReader("test1.txt");
            
            richTextBox1.AppendText(sr.ReadToEnd());
            

            sr.Close();

            
        }
    }
}


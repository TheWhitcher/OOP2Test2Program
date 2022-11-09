using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Test2Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Length len = new Length();
            MessageBox.Show(len.ToString());
        }
    }
}

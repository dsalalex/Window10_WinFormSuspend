using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TestSuspend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Case 1: The application will turn into suspend status
            throw new Exception("Error");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Case 2: The application will pop up an error dialog(JIT error), after close the dialog, the application will terminated
            //throw new Exception("Error");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinosaurGame
{
    public partial class MainScreen : Form
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //2.13 experimented with allow quit, it is read only.   

            Application.Run(new MainScreen());

        }
        public MainScreen()
        {
            
            InitializeComponent();











































        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

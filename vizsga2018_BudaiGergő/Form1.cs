using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizsga2018_BudaiGergő
{
    public partial class Form1 : Form
    {
        HappyLiving happyLiving = new HappyLiving("lakoparkok.txt");
        List<Image> floor = new List<Image>();
        int aPark = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            floor.Add(Image.FromFile("kereszt.jpg"));
            floor.Add(Image.FromFile("Haz1.jpg"));     
            floor.Add(Image.FromFile("Haz2.jpg"));     
            floor.Add(Image.FromFile("Haz3.jpg"));
        }
        void panelupdate()
        {

        }

        private void buttonBal_Click(object sender, EventArgs e)
        {
            panelupdate();
        }

        private void buttonJobb_Click(object sender, EventArgs e)
        {
            panelupdate();
        }
    }
}

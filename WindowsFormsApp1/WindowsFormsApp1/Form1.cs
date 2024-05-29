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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string productname;
            string unit;
            double minprice;
            double maxprice;
            double averageprice;
            int lineCount;
            object curitem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            marketlstbx.Items.AddRange(System.IO.File.ReadAllLines("C:\\Users\\LAB\\Desktop\\quiz3market.txt"));

            int lineCount = 0;
            using (var reader = File.OpenText("C:\\Users\\LAB\\Desktop\\quiz3market.txt"))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            itemcountlbl.Text = lineCount + " items read from file";
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            object curitem = marketlstbx.SelectedItem;
            MessageBox.Show (Convert.ToString(marketlstbx.SelectedItem),"Market Summary");

        }
    }
}

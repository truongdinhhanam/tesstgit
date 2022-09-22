using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LiB_B_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            for(int i = LiB_A.SelectedItems.Count - 1; i>=0; i--)
            {
                LiB_B.Items.Add(LiB_A.SelectedItems[i]);
                LiB_A.Items.Remove(LiB_A.SelectedItems[i]);
            }
            LiB_B.Sorted = true;                
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LiB_A.Items.Count; i++)
            {
                LiB_B.Items.Add(LiB_A.Items[i]);
                
            }
            LiB_A.Items.Clear();
            LiB_B.Sorted = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for (int i = LiB_B.SelectedItems.Count - 1; i >= 0; i--)
            {
                LiB_A.Items.Add(LiB_B.SelectedItems[i]);
                LiB_B.Items.Remove(LiB_B.SelectedItems[i]);
            }
            LiB_A.Sorted = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LiB_B.Items.Count; i++)
            {
                LiB_A.Items.Add(LiB_B.Items[i]);

            }
            LiB_B.Items.Clear();
            LiB_A.Sorted = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> hoTen = new Dictionary<string, string>();
            
        }
    }
}

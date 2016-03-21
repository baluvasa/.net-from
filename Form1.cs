using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            //textBox1.Text = listBox1.SelectedItem.ToString();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!listBox1.Items.Contains(textBox1.Text) && !listBox2.Items.Contains(textBox1.Text))
                {
                        listBox1.Items.Add(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Focus();
                   
                }
                else
                {
                    if (listBox1.Items.Contains(textBox1.Text))
                    {
                        listBox1.SelectedItem = textBox1.Text;
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                    else
                    {
                        listBox2.SelectedItem = textBox1.Text;
                        textBox1.Clear();
                        textBox1.Focus();
                    }



                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = listBox1.SelectedIndices[x];
                    listBox1.Items.RemoveAt(idx);
                }
            }
            else {
                for (int x = listBox2.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = listBox2.SelectedIndices[x];
                    listBox2.Items.RemoveAt(idx);
                }
            }
            /* int selectedIndex = listBox1.SelectedIndex;
            int selectedIndex1 = listBox2.SelectedIndex;
           
        if (selectedIndex != -1)
               listBox1.Items.RemoveAt(selectedIndex);
        else
            listBox2.Items.RemoveAt(selectedIndex1);
            */
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string a = listBox2.Items.Count.ToString();
            int se = listBox1.SelectedIndex;
            if (se > -1)
            {

                for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = listBox1.SelectedIndices[x];
                    listBox2.Items.Add(listBox1.Items[idx]);
                    listBox1.Items.RemoveAt(idx);
                } 
               
              /*  string selectedIndex = listBox1.SelectedItem.ToString();
                if (!listBox2.Items.Contains(selectedIndex))
                {
                    listBox2.Items.Add(selectedIndex);
                    listBox1.Items.Remove(selectedIndex);
                    listBox1.ClearSelected();
                }*/
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int se1 = listBox2.SelectedIndex;
            if (se1 > -1)
            {
                for (int x = listBox2.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = listBox2.SelectedIndices[x];
                    listBox1.Items.Add(listBox2.Items[idx]);
                    listBox2.Items.RemoveAt(idx);
                } 
                /*string selectedIndex = listBox2.SelectedItem.ToString();
                if (!listBox1.Items.Contains(selectedIndex))
                {
                    listBox1.Items.Add(selectedIndex);
                    listBox2.Items.Remove(selectedIndex);
                    listBox2.ClearSelected();
                }*/

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                int j = 0;
                for (j = 0; j <= listBox1.Items.Count - 1; j++)
                {
                    listBox2.Items.Add(listBox1.Items[j]);
                }
                listBox1.Items.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                int j = 0;
                for (j = 0; j <= listBox2.Items.Count - 1; j++)
                {
                    listBox1.Items.Add(listBox2.Items[j]);
                }
                listBox2.Items.Clear();
            }
        }
    }
}

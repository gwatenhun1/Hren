using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            panelMain.Width = this.ClientSize.Width;
            panelMain.Height = this.ClientSize.Height;
            panelInventory.Width = this.ClientSize.Width;
            panelInventory.Height = this.ClientSize.Height;
            panel3.Width = this.ClientSize.Width;
            panel3.Height = this.ClientSize.Height;
            panelMain.Location = new Point(0, 0);
            panelInventory.Location = new Point(0, 0);
            panel3.Location = new Point(0, 0);

            this.Controls.Add(this.panelInventory);
            this.Controls.Add(this.panel3);
            panelMain.Visible = false;
            panelInventory.Visible = false;
            panel3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            panelMain.Visible = true;
            panel3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
            panelMain.Visible = false;
 
        }

        private void button3_Click(object sender, EventArgs e)
        {

            panelMain.Visible = true;
            panelInventory.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
            panelInventory.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
 
            panelInventory.Visible = true;
            panel3.Visible = false;

        }

        private void buttonPanelInventory_Click(object sender, EventArgs e)
        {
            panelInventory.Visible = true;
            panelMain.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 1000)
            {
                timer1.Enabled = false;
                MessageBox.Show("Задание выполнено!");
                progressBar1.Value=0;
                RandomClass random = new RandomClass();
                locations locations = new locations();
                int randomValue = random.randomizer();
                int result = locations.itemsValue(randomValue);


                MessageBox.Show($"Число: {randomValue}. \nКол-во преметов: {result}");

            }

            progressBar1.Value = progressBar1.Value+1;

        }








        private void button7_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 1000;
        }
    }
}

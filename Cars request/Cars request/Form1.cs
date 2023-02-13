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

namespace Cars_request
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int i = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            selesctFile();

        }

        private void selesctFile()
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                lblLinkOfFile.Text = openFileDialog1.FileName;
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            randomNum();
        }
        List<String> cars = new List<string>();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            add();
            clear();
            randomNum();

        }

        private void randomNum()
        {
            i = random.Next(4000, 8000);
            lblRandom.Text = i.ToString();
        }

        private void clear()
        {
            txtCarName.Text = "";
            txtCarKind.Text = "";
            txtCarColor.Text = "";
        }

        private void add()
        {
            StreamWriter writer = new StreamWriter(lblLinkOfFile.Text,true);
            String s = (lblRandom).Text + " " + txtCarName.Text + " " + txtCarColor.Text + " " + txtCarKind.Text;
            writer.WriteLine(s);
            cars.Add(s);
            writer.Close();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            addToList();
        }

        private void addToList()
        {
            int i = cars.Count();

            for (int q = 0; q < i; q++)
            {
                String s = cars[q].ToString();
                listShow.Items.Add((q + 1) + "- " + s);
            }
        }

        private void btnShowFile_Click(object sender, EventArgs e)
        {
            readFromFile();
        }

        private void readFromFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                String s = reader.ReadLine();

                while (s != null)
                {
                    listShow.Items.Add(s);
                    s = reader.ReadLine();
                }
                reader.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listShow.Items.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;
            
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            
            linkLabel1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
           
            linkLabel2.Parent = pictureBox2;
            linkLabel2.BackColor = Color.Transparent;
            
            linkLabel3.Parent = pictureBox2;
            linkLabel3.BackColor = Color.Transparent;
            
            linkLabel4.Parent = pictureBox2;
            linkLabel4.BackColor = Color.Transparent;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            homePanel.Visible = true;
            menuPanel.Visible = false;
            //adoptionPanel.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            homePanel.Visible = false;
            menuPanel.Visible = true;
            //adoptionPanel.Visible = false;

            label1.BringToFront();
            label2.BringToFront();
            linkLabel1.BringToFront();
            linkLabel2.BringToFront();
            linkLabel3.BringToFront();

            menuPanel

        }
    }
}

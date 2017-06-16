using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS4ME;
using MetroFramework;

namespace PSe7en
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        PS4ME.PS4ME PS4 = new PS4ME.PS4ME();

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PS4.Connect(metroTextBox1.Text);
                metroLabel1.Text = "Status: Connected to " + metroTextBox1.Text;
            }
            catch
            {
                MessageBox.Show("Failed to connect to " + metroTextBox1.Text);
                metroLabel1.Text = "Status: Failed to connect to " + metroTextBox1.Text;
            }
            }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    PS4.AttachProcess("default_mp.elf");
                    metroLabel2.Text = "Status: attached";
                }
                catch
                {
                    MessageBox.Show("Failed to attach to COD Ghosts");
                    metroLabel2.Text = "Status: Failed to attach";
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    PS4.Disconnect();
                    metroLabel1.Text = "Status: Disconnected";
                }
                catch
                {
                    MessageBox.Show("Failed to disconnect from PS4 are you connected?");
                }
            }
            }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                PS4.writeMemory("0x81B09D", "0x01");
            }
            catch
            {
                MessageBox.Show("Failed to enable FPS Counter");
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                PS4.writeMemory("0x1F0C455", "0x99");
            }
            catch
            {
                MessageBox.Show("Failed to give player unlimted ammo");
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            try
            { 
                PS4.writeMemory("0x1F0F29C", "metroTextBox1.Text");
            }
            catch
            {
                int num = (int)MessageBox.Show("Failed to set name");
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.se7ensins.com");
        }
    }
}

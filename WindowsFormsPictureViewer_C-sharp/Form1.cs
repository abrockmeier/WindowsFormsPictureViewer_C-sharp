using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPictureViewer_C_sharp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}


		private void B1_anzeigen_Click(object sender, EventArgs e)
		{
			//Mieeeepp
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{ 
				pictureBox1.Load(openFileDialog1.FileName);
			}
		}

		private void B2_loeschen_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
		}

		private void B3_BGfarbe_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.BackColor = colorDialog1.Color;
			}
		}
		
		private void B4_schliessen_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CB_stretch_CheckedChanged(object sender, EventArgs e)
		{
			if (CB_stretch.Checked)
			{ 
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			else
				pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
		}
	}
}

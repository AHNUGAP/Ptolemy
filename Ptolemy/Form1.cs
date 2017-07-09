using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPSControlLibrary;
namespace Ptolemy
{
    /*public partial class Port
	{
		public void Port(Image i)
		{
			PictureBox pbx = new PictureBox();
			pbx.Size = new Size(50, 50);
			pbx.Location = new Point(200, 60);

			this.Controls.Add(pbx);
		}
	}*/
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int count = 1 ;
        private int count_input =1;
        private int count_output = 1;
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {

        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void toolStripButton_NewInPort_Click(object sender, EventArgs e)
        {
            InputPort input = new InputPort();
            input.Location = new Point(200, 100+count_input*60);
            panel2.Controls.Add(input);
            input.label.Text = "port" + count.ToString();
            count_input++;count++;
            input.Refresh();
           
        }

        private void toolStripButton_NewOutPort_Click(object sender, EventArgs e)
        {
            OutputPort output = new OutputPort();
            output.Location = new Point(400,100+count_output*60);
            panel2.Controls.Add(output);
            output.label.Text = "port" + count.ToString();
            count_output++; count++;
            output.Invalidate();

        }
    }
}

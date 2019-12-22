using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oof
{
    public partial class Win : Form
    {
        Players win = Players.Not;
        public Win()
        {
            InitializeComponent();
        }

        public Win(Players win)
        {
            InitializeComponent();

            if (win.Equals(Players.Cross))
            {
                richTextBox1.Text="Победа салата!";
            } else if (win.Equals(Players.Zero))
            {
                richTextBox1.Text = "Победа пончика!";
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

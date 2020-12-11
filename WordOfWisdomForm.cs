using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class frmWordsOfWisdom : Form
    {
        public frmWordsOfWisdom()
        {
            InitializeComponent();
        }

        private void FrmWordsOfWisdom_Load(object sender, EventArgs e)
        {
            
            lblFirstQuote.Text = "A day without laughter is a day wasted. \n  By Charlie Chaplin";
            lblSecondQuote.Text = "Design is not just what it looks like and feels like. Design is how it works.\n  By Steve Jobs";
            lblThirdQuote.Text = "Quality is more important than quantity. One home run is much better than two doubles.\n  By Steve Jobs";
            lblFourthQuote.Text = "All of us do not have equal talent. But, all of us have an equal opportunity to develop our talents.\n By APJ Abdul Kalam ";
        }

        private void LblFirstQuote_MouseHover(object sender, EventArgs e)
        {
            lblFirstQuote.BackColor = Color.White;
        }

        private void LblSecondQuote_MouseHover(object sender, EventArgs e)
        {
            lblSecondQuote.BackColor = Color.White;
        }

        private void LblThirdQuote_MouseHover(object sender, EventArgs e)
        {
            lblThirdQuote.BackColor = Color.White;
        }

        private void LblFourthQuote_MouseHover(object sender, EventArgs e)
        {
            lblFourthQuote.BackColor = Color.White;
        }
    }
}

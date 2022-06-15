using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    class SmartText
    {
        string startingSentence;
        TextBox textbox;
        

        public SmartText(string startingSentence, TextBox textbox)
        {
            this.startingSentence = startingSentence;
            this.textbox = textbox;
            InicialState();
        }
        public void InicialState()
        {
            if (textbox.Text == "")
            {
                textbox.Text = startingSentence;
                textbox.ForeColor = Color.Gray;
            }
        }
        public void WritingState()
        {
            if (textbox.Text == startingSentence && textbox.ForeColor == Color.Gray)
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
            }
        }
    }
}

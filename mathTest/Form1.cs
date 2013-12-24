using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mathTest
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            questionSet = new question[10];
            for (int i = 0; i < (questionSet.Length);i++ )
            {
                questionSet[i] = new question();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int i;
            bool result;
            bool convert = false;
            convert = int.TryParse(textBox1.Text.ToString(),out i);
            if (convert != true)
            {
                i = 0;
                result = questionSet[questionNumber].result(-1);
            }
            else
            {
                result = questionSet[questionNumber].result(i);
            }

            if (questionNumber < (questionSet.Length -1))
            {
                questionNumber++;
            }
            else
            {
                questionNumber = 0;
            }
            lblQuestion.Text = questionSet[questionNumber].question_text;
            lblStatus.Text = questionSet[questionNumber].status;
        }

        public question[] questionSet;
        public int questionNumber = 0;
    }
}

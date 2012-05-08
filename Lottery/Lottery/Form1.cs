using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiazedLib;

namespace Lottery
{

    public partial class Lottery : Form
    {

        public Lottery()
        {
            InitializeComponent();
            initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            BiazedLib.Sorting sort = new BiazedLib.Sorting();
            BiazedLib.Math Math = new BiazedLib.Math();
            numbers = sort.bubblesort(validate(Math.generate(7,1,39)));
            label1.Text = numbers[0].ToString();
            label2.Text = numbers[1].ToString();
            label3.Text = numbers[2].ToString();
            label4.Text = numbers[3].ToString();
            label5.Text = numbers[4].ToString();
            label6.Text = numbers[5].ToString();
            label7.Text = numbers[6].ToString();


        }


        private List<int> validate(List<int> input)
        {
            Random numb = new Random();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i != j)
                    {
                        if (input[i] == input[j])
                        {
                            input[i] = numb.Next(1,39);
                            validate(input);
                        }
                    }
                }
                
            }
            return input;
        }

        private void initialize()
        {
                label1.Text = "0";
                label2.Text = "0";
                label3.Text = "0";
                label4.Text = "0";
                label5.Text = "0";
                label6.Text = "0";
                label7.Text = "0";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

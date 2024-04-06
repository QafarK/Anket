namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            char data = ' ';
            if (label1.Text.Length > 0)
            {
                if (label1.Text[label1.Text.Length - 1].Equals('*') || label1.Text[label1.Text.Length - 1].Equals('/') || label1.Text[label1.Text.Length - 1].Equals('-'))
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                    label1.Text += '+';
                }
                else if (!label1.Text[label1.Text.Length - 1].Equals('+'))
                    label1.Text += '+';
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            char data = ' ';
            if (label1.Text.Length > 0)
            {
                if (label1.Text[label1.Text.Length - 1].Equals('*') || label1.Text[label1.Text.Length - 1].Equals('/') || label1.Text[label1.Text.Length - 1].Equals('+'))
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                    label1.Text += '-';
                }
                else if (!label1.Text[label1.Text.Length - 1].Equals('-'))
                    label1.Text += '-';
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            char data = ' ';
            if (label1.Text.Length > 0)
            {
                if (label1.Text[label1.Text.Length - 1].Equals('-') || label1.Text[label1.Text.Length - 1].Equals('/') || label1.Text[label1.Text.Length - 1].Equals('+'))
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                    label1.Text += '*';
                }
                else if (!label1.Text[label1.Text.Length - 1].Equals('*'))
                    label1.Text += '*';
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            char data = ' ';
            if (label1.Text.Length > 0)
            {
                if (label1.Text[label1.Text.Length - 1].Equals('*') || label1.Text[label1.Text.Length - 1].Equals('-') || label1.Text[label1.Text.Length - 1].Equals('+'))
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                    label1.Text += '/';
                }
                else if (!label1.Text[label1.Text.Length - 1].Equals('/'))
                    label1.Text += '/';
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string data = "";
            List<char> op = new List<char>();

            for (int i = 0; i < label1.Text.Length; i++)
            {
                if (i == 0 && label1.Text[0].Equals('-'))
                {
                    data += "0 ";
                    op.Add('-');
                }
                else
                {
                    if (label1.Text[i].Equals('+') || label1.Text[i].Equals('-') || label1.Text[i].Equals('*') || label1.Text[i].Equals('/'))
                    {
                        op.Add(label1.Text[i]);
                        data += ' ';
                    }
                    else
                        data += label1.Text[i];
                }
            }
            var nums = data.Split(' ');
            int result = Convert.ToInt32(nums[0]);

            int index = 0;
            for (int i = 0; i < op.Count; i++)
            {
                if (op[i].Equals('+'))
                    result = result + Convert.ToInt32(nums[index + 1]);
                else if (op[i].Equals('-'))
                    result = result - Convert.ToInt32(nums[index + 1]);
                else if (op[i].Equals('*'))
                    result = result * Convert.ToInt32(nums[index + 1]);
                else if (op[i].Equals('/'))
                    result = result / Convert.ToInt32(nums[index + 1]);
                index++;
            }
            label1.Text = result.ToString();
        }
    }
}
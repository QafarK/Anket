using Newtonsoft.Json;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json;

namespace Anket
{
    public partial class Form1 : Form
    {
        string Text1 = "";
        string Text2 = "";
        string Text3 = "";
        string Text4 = "";
        string Text5 = "";
        string Text6 = "";
        string Text7 = "";
        string date = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text1 = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Text2 = textBox2.Text;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Text3 = textBox5.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Text4 = textBox3.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Text5 = textBox6.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Text6 = textBox4.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Text7 = textBox7.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonDirectory = Path.Combine("..\\..\\..\\", "JSON");
            if (!Directory.Exists(jsonDirectory))
                Directory.CreateDirectory(jsonDirectory);

            if ((Text1.Length > 0 && Text2.Length > 0 &&
                Text3.Length > 0 && Text4.Length > 0 &&
                Text5.Length > 0 && Text6.Length > 0 && Text7.Length > 0 && date.Length > 0) &&
                (radioButton1.Checked == true || radioButton2.Checked == true))
            {
                Person person = new(Text7, Text2, Text1, Text3, Text4, Text5, Text6, date.ToString(), radioButton1.Checked ? "Male" : "Female");
                TextInfo text = CultureInfo.CurrentCulture.TextInfo;
                person.TitleName = text.ToTitleCase(person.TitleName);

                string jsonPath = Path.Combine(jsonDirectory, person.TitleName + ".json");
                string json = JsonConvert.SerializeObject(person, Formatting.Indented);
                File.WriteAllText(jsonPath, json);
            }
            else
                MessageBox.Show("Please fill all the fields");
        }
    }
}

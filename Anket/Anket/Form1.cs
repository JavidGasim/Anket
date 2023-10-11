using System.Text.Json;

namespace Anket
{
    public partial class Form1 : Form
    {
        List<Anket_Class> anket_Classes = new List<Anket_Class>();

        Anket_Class anket = new Anket_Class();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            anket.anket_name = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            anket.anket_surname = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            anket.anket_father_name = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            anket.anket_country = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            anket.anket_city = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            anket.anket_phone = textBox7.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            anket.anket_birthday = dateTimePicker1.Value.ToShortDateString();
        }

        private void man_CheckedChanged(object sender, EventArgs e)
        {
            anket.anket_gender = man.Text;
        }

        private void woman_CheckedChanged(object sender, EventArgs e)
        {
            anket.anket_gender = woman.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string jsonPath = "../../../Anket.json";

            File.Delete(jsonPath);
            anket_Classes.Add(anket);

            JsonSerializerOptions serializerOptions = new JsonSerializerOptions();
            serializerOptions.WriteIndented = true;

            string jsonstr = JsonSerializer.Serialize(anket_Classes, serializerOptions);

            File.AppendAllText(jsonPath, jsonstr);

            Anket_Class anket_1 = new Anket_Class();
            anket = anket_1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {
            string jsontxt = File.ReadAllText("../../../Anket.json");

            var list = System.Text.Json.JsonSerializer.Deserialize<List<Anket_Class>>(jsontxt);

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].anket_name == textBox1.Text)
                {
                    textBox2.Text = list[i].anket_name;
                    textBox3.Text = list[i].anket_surname;
                    textBox4.Text = list[i].anket_father_name;
                    textBox5.Text = list[i].anket_country;
                    textBox6.Text = list[i].anket_city;
                    textBox7.Text = list[i].anket_phone;
                    dateTimePicker1.Text = list[i].anket_birthday;

                    if (list[i].anket_gender == "man")
                    {
                        man.Select();
                    }

                    else
                    {
                        woman.Select();
                    }
                }
            }
        }
    }
}
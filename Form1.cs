using Questionnarie2.Models;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace Questionnarie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsJsonFileEmpty(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                return string.IsNullOrWhiteSpace(jsonContent);
            }
            return true;
        }


        List<Person> persons = new();
        static string fileName = "personJson.json";
         string txt = $"../../../Json/{fileName}";
        bool isJsonEmpty;
        bool checkError = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_file_name.Text))
            {
                textBox_file_name.Text = "personJson.json";
            }

            fileName = textBox_file_name.Text;
            txt = $"../../../Json/{fileName}";

            ListBox.SelectionMode = SelectionMode.MultiExtended;
            isJsonEmpty = IsJsonFileEmpty(txt);
            if (isJsonEmpty)//bos deyilse
            {
                string json = File.ReadAllText(txt);
                var list = JsonSerializer.Deserialize<List<Person>>(json);
                persons = list!;
                ListBox.DataSource = persons;
            }
        }
        public void FileExist()
        {
            if (!File.Exists(txt))
            {
                using (File.Create(txt)) ;
               
            }
        }
     //elave et
        private void button1_add_Click(object sender, EventArgs e)
        {
            ListBox.DataSource = persons;
            FileExist();
            label_message.Visible = false;
            string? name = textBox1_name.Text;
            string surname = textBox2_surname.Text;
            string email = textBox3_mail.Text;
            string phone = textBox4_tel.Text;
            DateTime date = dateTimePicker1.Value;

            CheckError(ref checkError);
            if (checkError)
            {
                if (CheckMail())
                {
                    Person person = new Person(name, surname, email, phone, date);

                    isJsonEmpty = IsJsonFileEmpty(txt);
                    if (isJsonEmpty)//bosdursa
                    {
                        persons.Add(person);
                    }
                    else
                    {
                        string json = File.ReadAllText(txt);
                        var list = JsonSerializer.Deserialize<List<Person>>(json);
                        list!.Add(person);
                        persons = list;
                        ListBox.DataSource = persons;
                    }
                    JsonSerializerOptions options = new();
                    options.WriteIndented = true;
                    string text = JsonSerializer.Serialize(persons, options);
                    File.WriteAllText(txt, text);

                    label_message.Text = "Elave edildi!";
                    label_message.Visible = true;

                    textBox1_name.Text = null;
                    textBox2_surname.Text = null;
                    textBox3_mail.Text = null;
                    textBox4_tel.Text = null;
                }
                else { MessageBox.Show("Bu mail-de istifadeci movcuddur!", "Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }


        }
        // Check all textBox
        public void CheckString(ref TextBox textBox)
        {
            if (textBox.Text.Length < 3) textBox.ForeColor = Color.Red;
            else textBox.ForeColor = Color.Black;

        }
        public void CheckRegex(ref TextBox textBox, Regex regex)
        {
            if (regex.IsMatch(textBox.Text)) textBox.ForeColor = Color.Green;
            else textBox.ForeColor = Color.Red;

        }

        private void textBox1_name_TextChanged(object sender, EventArgs e)
        {
            label_message.Visible = false;
            var NameTextBox = sender as TextBox;
            CheckString(ref NameTextBox!);

        }

        private void textBox2_surname_TextChanged(object sender, EventArgs e)
        {
            label_message.Visible = false;
            var SurnameTextBox = sender as TextBox;
            CheckString(ref SurnameTextBox!);
        }

        private void textBox3_mail_TextChanged(object sender, EventArgs e)
        {
            label_message.Visible = false;
            Regex regex = new(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            var MailTextBox = sender as TextBox;
            CheckRegex(ref MailTextBox!, regex);
        }

        private void textBox4_tel_TextChanged(object sender, EventArgs e)
        {
            label_message.Visible = false;
            var PhoneTextBox = sender as TextBox;
            Regex regex = new Regex(@"\d{3}-\d{3}-\d{2}-\d{2}");
            CheckRegex(ref PhoneTextBox!, regex);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label_message.Visible = false;
        }
        //Check Error
        public void CheckError(ref bool checkError)
        {
            Regex regex_phone = new Regex(@"\d{3}-\d{3}-\d{2}-\d{2}");
            Regex regex_mail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (textBox1_name.Text.Length < 3)
            {
                MessageBox.Show("Ad min 3 simvoldan ibaret olmalidir!", "Sintaksis sehv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkError = false;
            }
            if (textBox2_surname.Text.Length < 3)
            {
                MessageBox.Show("Soyad min 3 simvoldan ibaret olmalidir", "Sintaksis sehv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkError = false;
            }

            if (textBox4_tel.ForeColor == Color.Red)
            {
                MessageBox.Show("Duzgun sintaksis=>000-000-00-00!", "Sintaksis sehv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkError = false;
            }
            else if (textBox3_mail.ForeColor == Color.Red)
            {
                MessageBox.Show("En az bir defe @ ve . islenmelidir!", "Sintaksis sehv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkError = false;
            }

        }
        //eyni mailde ist-ci daxil edilmesin
        public bool CheckMail()
        {
            string json = File.ReadAllText(txt);
            bool isEmpty = IsJsonFileEmpty(json);
            if (!isEmpty)//file bos deyilse
            {
                var list = JsonSerializer.Deserialize<List<Person>>(json);
                foreach (var item in list!)
                {
                    if (textBox3_mail.Text == item.Email) return false;
                }
            }
            return true;

        }
        //data uzerinde deyisiklik etmek
        private void button_changeData_Click(object sender, EventArgs e)
        {
            button1_save_change.Visible = true;
            button1_add.Visible = false;
            string json = File.ReadAllText(txt);
            var list = JsonSerializer.Deserialize<List<Person>>(json);
            var selectedPerson = (Person)ListBox.SelectedItem;

            if (selectedPerson != null)
            {
                foreach (var item in list)
                {
                    if (item.Name == selectedPerson.Name)
                    {
                        textBox1_name.Text = item.Name;
                        textBox2_surname.Text = item.Surname;
                        textBox3_mail.Text = item.Email;
                        textBox4_tel.Text = item.Phone;
                        dateTimePicker1.Value = item.Date;
                        break;
                    }

                }
            }
        }
        //fayl adinin duzgun yazilmasi
        private void textBox_file_name_TextChanged(object sender, EventArgs e)
        {
            label_message.Visible = false;
            if (textBox_file_name.Text.Contains(".json"))
            {
                textBox_file_name.ForeColor = Color.Black;
            }
            else textBox_file_name.ForeColor = Color.Red;
        }
        //var olan faylin axtarisi
        private void button2_searchFile_Click(object sender, EventArgs e)
        {
            if (textBox_file_name.ForeColor == Color.Red)
            {
                MessageBox.Show("Sintaksis=>faylAdi.json", "Sintaksis sehv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListBox.DataSource = null;
            fileName = textBox_file_name.Text;
            txt = $"../../../Json/{fileName}";

            isJsonEmpty = IsJsonFileEmpty(txt);
            if (isJsonEmpty)//bosdursa
            {
                label_message.Visible = true;
                label_message.ForeColor = Color.Red;
                label_message.Text = "Data yoxdur!";
            }
            else//bos deyilse
            {
                string json = File.ReadAllText(txt);
                var list = JsonSerializer.Deserialize<List<Person>>(json);
                persons = list!;
                ListBox.DataSource = persons;
            }
        }
        //fayl varsa elave edir,yoxdursa yaranib elave edilir
        private void button1_writeNewFile_Click(object sender, EventArgs e)
        {
            if (textBox_file_name.ForeColor == Color.Red)
            {
                MessageBox.Show("Sintaksis=>faylAdi.json", "Sintaksis sehv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fileName = textBox_file_name.Text;
            txt = $"../../../Json/{fileName}";
            if (File.Exists(txt))
            {
                isJsonEmpty = IsJsonFileEmpty(txt);
                if (isJsonEmpty)//bosdursa
                {
                    foreach (var item in ListBox.SelectedItems)
                    {
                        var person = item as Person;
                        persons.Add(person!);
                    }

                }
                else//bos deyilse
                {
                    string jsonFile = File.ReadAllText(txt);
                    var list = JsonSerializer.Deserialize<List<Person>>(jsonFile);
                    foreach (var item in ListBox.SelectedItems)
                    {
                        var person = item as Person;
                        list!.Add(person!);
                    }
                    persons = list!;
                    
                }
                label_message.Visible = true;
                label_message.Text = "Data elave edildi!";
                label_message.ForeColor = Color.Green;

            }
            else
            {
                using (File.Create(txt)) ;
                foreach (var item in ListBox.SelectedItems)
                {
                    var person = item as Person;
                    persons.Add(person!);
                }
                label_message.Visible = true;
                label_message.Text = "Yeni fayl yaradildi!";
                label_message.ForeColor = Color.Green;
            }
            ListBox.DataSource = persons;
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(persons, options);
            File.WriteAllText(txt, json);
        }
        //deyisiklikleri json faylina yazmaq
        private void button1_save_change_Click(object sender, EventArgs e)
        {
            CheckError(ref checkError);
            string json = File.ReadAllText(txt);
            var list = JsonSerializer.Deserialize<List<Person>>(json);
            var selectedPerson = (Person)ListBox.SelectedItem;
            foreach (var item in list)
            {
                if (item.Name == selectedPerson.Name)
                {
                    list.Remove(item);
                    item.Name = textBox1_name.Text;
                    item.Surname = textBox2_surname.Text;
                    item.Email = textBox3_mail.Text;
                    item.Phone = textBox4_tel.Text;
                    item.Date = dateTimePicker1.Value;
                    CheckError(ref checkError);
                    if (checkError)
                    {
                        list.Add(item);
                        persons = list;
                        JsonSerializerOptions options = new();
                        options.WriteIndented = true;
                        string text = JsonSerializer.Serialize(persons, options);
                        File.WriteAllText(txt, text);
                        textBox1_name.Text = null;
                        textBox2_surname.Text = null;
                        textBox3_mail.Text = null;
                        textBox4_tel.Text = null;
                        button1_add.Visible = true;
                        button1_save_change.Visible = false;

                        label_message.Text = "Deyisiklik yadda saxlanildi! ";
                        label_message.Visible = true;

                    }
                    break;
                }
            }

        }

    
    }

}
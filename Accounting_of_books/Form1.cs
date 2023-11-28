using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Accounting_of_books
{
    public partial class Form1 : Form
    {
        Book[] books = new Book[0];
        bool add_flag = false;
        bool red_flag = false;
        List<Book> books_list = new List<Book>();
        List<string> genre = new List<string>();
        List<string> writer = new List<string>();
        List<string> date = new List<string>();

        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            textBox_date.ReadOnly = true;
            textBox_name.ReadOnly = true;
            textBox_genre.ReadOnly = true;
            textBox_inStock.ReadOnly = true;
            textBox_sum.ReadOnly = true;
            textBox_writer.ReadOnly = true;
            comboBox_genre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_writer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_date.DropDownStyle = ComboBoxStyle.DropDownList;
            full_list();
        }

        public void read_book(int index, string path)
        {
            books_list.Clear();
            using (StreamReader reader = new StreamReader(path))
            {
                books[index] = new Book(reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), path);
                books_list.Add(books[index]);
            }
        }

        public void full_list()
        {
            but_add.Enabled = true;
            but_del.Enabled = true;
            but_redact.Enabled = true;
            but_cancel.Enabled = false;
            but_save.Enabled = false;
            but_sort.Enabled = true;
            comboBox_genre.Items.Clear();
            comboBox_genre.Items.Add("-");
            comboBox_genre.SelectedIndex = 0;
            comboBox_writer.Items.Clear();
            comboBox_writer.Items.Add("-");
            comboBox_writer.SelectedIndex = 0;
            comboBox_date.Items.Clear();
            comboBox_date.Items.Add("-");
            comboBox_date.SelectedIndex = 0;
            string[] file = Directory.GetFiles("Books");
            books = new Book[file.Length];
            if (file.Length > 0)
            {
                int i = 0;
                foreach (string path in file)
                {
                    read_book(i, path);
                    i++;
                }
                i = 0;

                genre.Add(books[0].genre);
                writer.Add(books[0].writer);
                date.Add(books[0].date);
                foreach (Book book in books)
                {
                    for (int j = 0; j < genre.LongCount(); j++) if (book.genre != genre[j]) genre.Add(book.genre);
                    for (int j = 0; j < writer.LongCount(); j++) if (book.writer != writer[j]) writer.Add(book.writer);
                    for (int j = 0; j < date.LongCount(); j++) if (book.date != date[j]) date.Add(book.date);
                    i++;
                }
                genre = genre.Distinct().ToList();
                writer = writer.Distinct().ToList();
                date = date.Distinct().ToList();
                foreach (string genre in genre) comboBox_genre.Items.Add(genre);
                foreach (string writer in writer) comboBox_writer.Items.Add(writer);
                foreach (string date in date) comboBox_date.Items.Add(date);
                sort();
                listBox.SelectedIndex = 0;
            }
            else
            {
                textBox_name.Text = "";
                textBox_writer.Text = "";
                textBox_genre.Text = "";
                textBox_date.Text = "";
                textBox_sum.Text = "";
                textBox_inStock.Text = "";
                listBox.SelectedItem = null;
                but_del.Enabled = false;
                but_redact.Enabled = false;
                books_list.Clear();
            }
        }

        public void sort()
        {
            books_list.Clear();
            foreach (Book book in books) books_list.Add(book);
            if (comboBox_genre.Text != "-")
            {
                for (int j = 0; j < books_list.LongCount(); j++)
                {
                    if (books_list[j].genre != comboBox_genre.Text)
                    {
                        books_list.RemoveAt(j);
                        j--;
                    }
                }
            }
            if (comboBox_writer.Text != "-")
            {
                for (int j = 0; j < books_list.LongCount(); j++)
                {
                    if (books_list[j].writer != comboBox_writer.Text)
                    {
                        books_list.RemoveAt(j);
                        j--;
                    }
                }
            }
            if (comboBox_date.Text != "-")
            {
                for (int j = 0; j < books_list.LongCount(); j++)
                {
                    if (books_list[j].date != comboBox_date.Text)
                    {
                        books_list.RemoveAt(j);
                        j--;
                    }
                }
            }
            listBox.Items.Clear();
            foreach (Book book in books_list) listBox.Items.Add(book.name + " " + book.writer + " " + book.date + " " + book.genre);

        }





        private void but_sort_Click(object sender, EventArgs e)
        {
            sort();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                but_add.Enabled = true;
                but_del.Enabled = true;
                but_redact.Enabled = true;
                but_save.Enabled = false;
                but_cancel.Enabled = false;
                textBox_name.Text = books_list[listBox.SelectedIndex].name;
                textBox_writer.Text = books_list[listBox.SelectedIndex].writer;
                textBox_genre.Text = books_list[listBox.SelectedIndex].genre;
                textBox_date.Text = books_list[listBox.SelectedIndex].date;
                textBox_sum.Text = "" + books_list[listBox.SelectedIndex].sum;
                textBox_inStock.Text = "" + books_list[listBox.SelectedIndex].inStock;
            }
            catch { }
        }
        void textBoxReadOnly(bool x)
        {
            textBox_name.ReadOnly = x;
            textBox_writer.ReadOnly = x;
            textBox_genre.ReadOnly = x;
            textBox_date.ReadOnly = x;
            textBox_sum.ReadOnly = x;
            textBox_inStock.ReadOnly = x;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            textBoxReadOnly(false);
            textBox_name.Text = "";
            textBox_writer.Text = "";
            textBox_genre.Text = "";
            textBox_date.Text = "";
            textBox_sum.Text = "";
            textBox_inStock.Text = "";
            but_add.Enabled = false;
            but_del.Enabled = false;
            but_redact.Enabled = false;
            but_cancel.Enabled = true;
            but_save.Enabled = true;
            but_sort.Enabled = false;
            add_flag = true;
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            if(add_flag)
            {
                full_list();
                add_flag = false;
            }
            if(red_flag)
            {
                int id = listBox.SelectedIndex;
                textBox_name.Text = "" + books_list[id].name;
                textBox_writer.Text = "" + books_list[id].writer;
                textBox_genre.Text = "" + books_list[id].genre;
                textBox_date.Text = "" + books_list[id].date;
                textBox_sum.Text = "" + books_list[id].sum;
                textBox_inStock.Text = "" + books_list[id].inStock;
                red_flag = false;
            }
            textBoxReadOnly(true);
            but_add.Enabled = true;
            but_del.Enabled = true;
            but_redact.Enabled = true;
            but_cancel.Enabled = false;
            but_save.Enabled = false;
            but_sort.Enabled = true;
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            int id = listBox.SelectedIndex;
            File.Delete(books_list[id].path);
            full_list();
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            if(add_flag)
            {
                if(textBox_date.Text != "" & textBox_writer.Text != "" & textBox_genre.Text != "" & textBox_date.Text != "" & textBox_sum.Text != "" & textBox_inStock.Text != "")
                {
                    try
                    {
                        int i = int.Parse(textBox_sum.Text);
                        i = int.Parse(textBox_inStock.Text);
                        Random random = new Random();
                        using (FileStream fs = File.Create("Books/" + random.Next(1000, 9999) + ".txt"))
                        {
                            AddText(fs, textBox_name.Text);
                            AddText(fs, "\n" + textBox_writer.Text);
                            AddText(fs, "\n" + textBox_genre.Text);
                            AddText(fs, "\n" + textBox_date.Text);
                            AddText(fs, "\n" + textBox_sum.Text);
                            AddText(fs, "\n" + textBox_inStock.Text);
                        }
                        add_flag = false;
                        textBoxReadOnly(true);
                        but_add.Enabled = true;
                        but_del.Enabled = true;
                        but_redact.Enabled = true;
                        but_cancel.Enabled = false;
                        but_save.Enabled = false;
                        but_sort.Enabled = true;
                        init();
                    }
                    catch 
                    {
                        MessageBox.Show("Неверный формат данных", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Заполнкны не все данные", "Ошибка");
                }
            }

            if (red_flag)
            {
                if (textBox_date.Text != "" & textBox_writer.Text != "" & textBox_genre.Text != "" & textBox_date.Text != "" & textBox_sum.Text != "" & textBox_inStock.Text != "")
                {
                    try
                    {
                        int i = int.Parse(textBox_sum.Text);
                        i = int.Parse(textBox_inStock.Text);
                        int id = listBox.SelectedIndex;
                        File.Delete(books_list[id].path);
                        using (FileStream fs = File.Create(books_list[id].path))
                        {
                            AddText(fs, textBox_name.Text);
                            AddText(fs, "\n" + textBox_writer.Text);
                            AddText(fs, "\n" + textBox_genre.Text);
                            AddText(fs, "\n" + textBox_date.Text);
                            AddText(fs, "\n" + textBox_sum.Text);
                            AddText(fs, "\n" + textBox_inStock.Text);
                        }
                        red_flag = false;
                        textBoxReadOnly(true);
                        but_add.Enabled = true;
                        but_del.Enabled = true;
                        but_redact.Enabled = true;
                        but_cancel.Enabled = false;
                        but_save.Enabled = false;
                        but_sort.Enabled = true;
                        init();
                        listBox.SelectedIndex = id;
                    }
                    catch 
                    {
                        MessageBox.Show("Неверный формат данных", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Заполнкны не все данные", "Ошибка");
                }
            }
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private void but_redact_Click(object sender, EventArgs e)
        {
            textBoxReadOnly(false);
            but_add.Enabled = false;
            but_del.Enabled = false;
            but_redact.Enabled = false;
            but_cancel.Enabled = true;
            but_save.Enabled = true;
            but_sort.Enabled = false;
            red_flag = true;
        }

        
    }
}

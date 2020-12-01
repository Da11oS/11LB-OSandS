using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ОСИС_11ЛБ_Файловые_операции
{
    public partial class Form1 : Form
    {
        int n25 = 10 + 25;//добавить № варианта
        FileStream file1;
        StreamReader reader;
        string filename1;
        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            FileInfo fsi = new FileInfo(openFileDialog1.FileName);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            // Get a reference to each file in that directory.
            FileInfo[] fiArr = di.GetFiles();
            // Display the names and sizes of the files.
            richTextBox1.AppendText("\n" + "The directory contains the following files:" + di.Name);
            foreach (FileInfo f in fiArr)
                richTextBox1.AppendText("\n" + "The size of " + f.Name + " is " + f.Length + " bytes. " + f.CreationTime);

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Find(FileTextBox.Text);
            richTextBox1.SelectionColor = Color.Red;

        }

        private void OpenForReadingButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл            
            filename1 = openFileDialog1.FileName;
            file1 = new FileStream(filename1, FileMode.Open);
            reader = new StreamReader(file1);

        }

        private void RadLineButton_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\n" + reader.ReadLine());
        }

        private void WriteLineButton_Click(object sender, EventArgs e)
        {
            writer.WriteLine(FileTextBox.Text);
        }

        private void CloseForReadButton_Click(object sender, EventArgs e)
        {
            reader.Close();
        }

        private void OpenForWriteButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл            
            filename1 = openFileDialog1.FileName;
            file1 = new FileStream(filename1, FileMode.Append);
            writer = new StreamWriter(file1);

        }

        private void CloseForWriteButton_Click(object sender, EventArgs e)
        {
            writer.Close();
        }

        private void UnitReadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл            
            string filename = openFileDialog1.FileName;
            using (FileStream fstream = new FileStream(@filename, FileMode.OpenOrCreate))
            {

                fstream.Seek(int.Parse(PositionTextBox.Text) + 2, SeekOrigin.Begin);//  .End);
                byte[] output = new byte[n25];
                int n = fstream.Read(output, 0, output.Length);
                string textFromFile = Encoding.Default.GetString(output);
                FileTextBox.Text = textFromFile;

            }
        }

        private void WriteUnitButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл            
            string filename = saveFileDialog1.FileName;
            using (FileStream fstream = new FileStream(@filename, FileMode.OpenOrCreate))
            {
                string replaceText = FileTextBox.Text;
                if (replaceText.Length < n25)
                {
                    replaceText = replaceText + "..........";
                }
                if (replaceText.Length > n25)
                {
                    replaceText = replaceText.Substring(0, n25);
                }
                fstream.Seek(int.Parse(PositionTextBox.Text) + 2, SeekOrigin.Begin); 
                byte[] input = Encoding.Default.GetBytes(replaceText);
                fstream.Write(input, 0, input.Length);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FileInfo fsi = new FileInfo(openFileDialog1.FileName);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            // Get a reference to each file in that directory.
            FileInfo[] fiArr = di.GetFiles();
            // Display the names and sizes of the files.
            richTextBox1.AppendText("\n" + "The directory contains the following files:" + di.Name);
            foreach (FileInfo f in fiArr)
                richTextBox1.AppendText("\n" + "The size of " + f.Name + " is " + f.Length + " bytes. " + f.CreationTime);
        }

        private void СоздатьПапкуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Directory.SetCurrentDirectory(folderBrowserDialog1.SelectedPath);
            Directory.CreateDirectory("25Вариант TestDir");     //№ варианта      
        }

        private void ОткрытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.* |html files(*.html)|*.html";
            // использовать расширение по варианту
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл            
            string filename = openFileDialog1.FileName;
            // читаем файл в строку

            string fileText = System.IO.File.ReadAllText(filename);
            richTextBox1.Text = fileText;
            string s1 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string s2 = "abvgde_=zijklmnoprstufhc@%&*y()-!ABVGDEEJZIJKLMNOPRSTUFHCHSITYWLOY";
            string s = "";
            string buf = richTextBox1.Text;
            int k = 0;
            for (int i = 0; i < buf.Length; i++)
            {
                k = 0;
                for (int j = 1; j < 66; j++)
                {
                    if (s1[j] == buf[i])
                    { k = j; };
                };
                if (k > 0)
                { s = s + s2[k].ToString(); }
                else
                { s = s + buf[i].ToString(); };
            };
            System.IO.File.WriteAllText(filename, s, Encoding.UTF8);
        }
    }
}

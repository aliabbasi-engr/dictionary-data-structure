using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class OpenFileForm : Form
    {
        private static string sourceFile = "";
        public static string SourceFile
        {
            get { return sourceFile; }
            set { sourceFile = value; }
        }

        private static bool fileLoaded = false;

        public static bool FileLoaded
        {
            get { return fileLoaded; }
            set { fileLoaded = value;  }
        }

        private static Language language = Language.EN;
        public static Language Language
        {
            get { return language; }
            set { language = value; }
        }

        public OpenFileForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (Language == Language.EN)
                Process.Start(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\info_EN.pdf");
            else
                Process.Start(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\info_DE.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (language == Language.EN)
            {
                openFileDialog1.Title = "Open Source Text File";
                openFileDialog1.Filter = "Text Files (*.txt)| *.txt";
            }
            else if (language == Language.DE)
            {
                openFileDialog1.Title = "Open Source Textdatei";
                openFileDialog1.Filter = "Textdateien (*.txt)| *.txt";
            }
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                SourceFile = openFileDialog1.FileName;
                FileLoaded = true;
                var form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var streamWriter = new StreamWriter("Words.txt");
            SourceFile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\Words.txt";
            streamWriter.Close();
            FileLoaded = false;
            var form2 = new Form2();
            form2.ShowDialog();
        }

        private void labelEN_Click(object sender, EventArgs e)
        {
            labelEN.Font = new Font(labelEN.Font.Name, labelEN.Font.Size, FontStyle.Bold);
            labelDE.Font = new Font(labelDE.Font.Name, labelDE.Font.Size, FontStyle.Regular);
            Language = Language.EN;
            label1.Text = "Press following key to open you source text file:";
            openFileButton.Text = "Open File";
            button2.Text = "I don't have a file";
            label2.Text = "Click here for more info about this project";
        }

        private void labelDE_Click(object sender, EventArgs e)
        {
            labelEN.Font = new Font(labelEN.Font.Name, labelEN.Font.Size, FontStyle.Regular);
            labelDE.Font = new Font(labelDE.Font.Name, labelDE.Font.Size, FontStyle.Bold);
            Language = Language.DE;
            label1.Text = "Drücken Sie die folgende Taste, um die Quelltextdatei zu öffnen:";
            openFileButton.Text = "Datei öffnen";
            button2.Text = "Ich habe keine Datei";
            label2.Text = "Klicken Sie hier, um weitere Informationen zu diesem Projekt zu erhalten";
        }
    }
}

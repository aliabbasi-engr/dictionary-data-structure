using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    static class Helper
    {
        public static int GetIntValue(double number)
        {
            return (int)number;
        }

        public static double GetDoubleValue(double number)
        {
            var doubleValue = number.ToString();
            doubleValue = '0' + doubleValue.Substring(doubleValue.IndexOf('.'));
            return double.Parse(doubleValue);
        }

        public static Dictionary<string, double> GetDataFromFile(string filePath)
        {
            var dictionary = new Dictionary<string, double>();
            string dataLine;
            string[] datas = new string[2];
            try
            {
                var reader = new StreamReader(filePath);
                while (!reader.EndOfStream)
                {
                    dataLine = reader.ReadLine();
                    dataLine = dataLine.Trim();
                    datas = dataLine.Split('-');
                    dictionary.Add(datas[1], double.Parse(datas[0]));
                }
                reader.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dictionary;
        }

        public static void AddDataToFile(double value, string key, string filePath)
        {
            var writer = new StreamWriter(filePath, true);
            Console.WriteLine();
            writer.WriteLine(value.ToString() + '-' + key);
            writer.Close();
        }

        public static void RemoveDataFromFile(string value , string key , string filePath)
        {
            string dataLine;
            string tempFilePath = Path.GetDirectoryName(filePath) + "\\temp.txt";
            string[] datas = new string[2];
            bool fileIsEmpty = true;
            StreamReader reader = new StreamReader(filePath);
            while (!reader.EndOfStream)
            {
                dataLine = reader.ReadLine();
                dataLine = dataLine.Trim();
                datas = dataLine.Split('-');
                if (datas[0] != value && datas[1] != key)
                {
                    AddDataToFile(double.Parse(datas[0]), datas[1], tempFilePath);
                    fileIsEmpty = false;
                }
            }
            reader.Close();
            if (fileIsEmpty)
            {
                StreamWriter writer = new StreamWriter(tempFilePath);
                writer.Close();
            }
            File.Delete(filePath);
            File.Move(Path.GetDirectoryName(filePath) + "\\temp.txt", filePath);
        }
    }
}

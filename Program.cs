using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Практическая_работа__13
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    static class Table
    {
        public static int Row;
        public static int Column;
        public static void Save()
        {
            StreamWriter file = new StreamWriter("config.ini");
            file.WriteLine(Column);
            file.WriteLine(Row);
            file.Close();
        }
        public static void Open()
        {
            try
            {
                StreamReader file = new StreamReader("config.ini");
                int column = Convert.ToInt32(file.ReadLine());
                int row = Convert.ToInt32(file.ReadLine());
                Column = column;
                Row = row;
                file.Close();
            }
            
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Файл конфигурации не найден!");
                Row = 5;
                Column = 5;
            }
        }
    }
}

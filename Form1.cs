using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_6;

namespace Практическая_работа__13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Подсказки для кнопок
            ToolTip tp = new ToolTip();
            tp.SetToolTip(button1, "Заполнение случайными значениями");
            toolTip1.SetToolTip(button2, "Нажмите, чтобы рассчитать");
        }

        //Кнопка Рассчитать
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//Очищение textbox
            Matr.Summ(table, textBox1);
        }

        //Кнопка Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matr.ClearMas(table);
        }

        //Кнопка Сохранить
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matr.SaveFile(table);
        }

        //Кнопка Открыть
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matr.OpenFile(table);
        }

        //Кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик Алешина Дарья ИСП-31" +
                "Вариант 6" +
                "Практическая работа №13" +
                "Дана целочисленная матрица размера M * N." +
                " Найти номер последнего из ее столбцов, " +
                "содержащих равное количество положительных и отрицательных элементов(нулевые элементы матрицы не учитываются)." +
                "Если таких столбцов нет, то вывести 0.");
        }

        //Кнопка Заполнить
        private void button1_Click(object sender, EventArgs e)
        {
            Matr.ZpMas(table);
        }

        //Начальные значения таблицы
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
            //table - таблица DataGridView
            table.ColumnCount = 5;//Количество столбцов
            table.RowCount = 1;//Количество строк
            kolvo.Value = 5;
            kolstr.Value = 1;
        }

        //Изменение количества колонок
        private void kolvo_ValueChanged(object sender, EventArgs e)
        {
            table.ColumnCount = Convert.ToInt32(kolvo.Value);
        }

        //Изменение количества строк
        private void kolstr_ValueChanged(object sender, EventArgs e)
        {
            table.RowCount = Convert.ToInt32(kolstr.Value);
        }

        //Строка состояния
        //Размер таблицы
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(kolstr.Value);
            int a2 = Convert.ToInt32(kolvo.Value);
            statusStrip1.Items[0].Text = a1.ToString() + "x" + a2.ToString();
        }

        //Строка состояния
        //Номер ячейки
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            int x = table.CurrentCell.RowIndex + 1;
            int y = table.CurrentCell.ColumnIndex + 1;
            statusStrip1.Items[1].Text = "(" + x.ToString() + "," + y.ToString() + ")";
        }

        //Контекстное меню1
        private void table_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        //Кнопка Очистить
        private void очиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.ColumnCount; i++)
            {
                for (int j = 0; j < table.RowCount; j++)
                {
                    table[i, j].Value = " ";
                }
            }
        }

        //Вопрос о закрытии формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //
        private void задатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            table.ColumnCount = Table.Column;
            table.RowCount = Table.Row;
            kolvo.Value = Table.Column;
            kolstr.Value = Table.Row;
        }
    }
}

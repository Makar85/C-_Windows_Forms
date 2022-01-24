using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourseLab2.BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Cрок пользования
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        List<Item> its = new List<Item>(); //список для хранения единиц хранения библиотеки

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
                 Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();

            b.PriceBook(PeriodUse);

            its.Add(b);

            //очищаем поля для ввода новой информации

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверяем состояние флажка сортировки и
            //в случае его установки сортируем список
            if (SortInvNumber)
                its.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        //---------------------------------------------------Журналы----------------------------------------------------------------------
        public string VolumeMag // Том
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public int NumberMag // Номер
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public string TitleMag // Название
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public int YearMag // Дата выпуска
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }

        public int InvNumberMag // Инвентарный номер
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }

        public bool ExistenceMag // Наличие
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        public bool SortInvNumberMag // Сортировка по инвентарному номеру
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }

        public bool CheckSubMag // Сортировка по инвентарному номеру
        {
            get { return checkBox6.Checked; }
            set { checkBox6.Checked = value; }
        }

        List<Item> itsmag = new List<Item>(); //список журналов 

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(VolumeMag, NumberMag, TitleMag, YearMag, 
                InvNumberMag, ExistenceMag); 
            if (CheckSubMag == true)
            {
                m.Subs();
            }

            if (ExistenceMag == true)
            {
                m.Return();            
            }

            itsmag.Add(m); //Добавлем журнал в список
            


            //очищаем поля для ввода новой информации

            VolumeMag = TitleMag  = "";
            NumberMag = InvNumberMag = 0;
            YearMag = 20;
            ExistenceMag = CheckSubMag = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //проверяем состояние флажка сортировки и
            //в случае его установки сортируем список
            if (SortInvNumber)
                itsmag.Sort();

            StringBuilder sbMag = new StringBuilder();
            foreach (Item item in itsmag)
            {
                sbMag.Append("\n" + item.ToString());
            }
            richTextBox2.Text = sbMag.ToString();
        }
    }
}   





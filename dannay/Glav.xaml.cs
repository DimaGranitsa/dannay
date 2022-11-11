using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dannay
{
    /// <summary>
    /// Логика взаимодействия для Glav.xaml
    /// </summary>
    public partial class Glav : Page
    {
        public Glav()
        {
            InitializeComponent();
        }

        private void qwe_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                int num = rand.Next(000, 999);
                int num2 = rand.Next(00, 99);
                int num3 = rand.Next(00, 99);
                string result = "+7 " + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString() + " " + num3.ToString();
                lov.Text += result.ToString() + "\n";
            }
        }

        private void lov_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void qwee_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                int num = rand.Next(000, 999);
                int num2 = rand.Next(00, 99);
                int num3 = rand.Next(00, 99);
                string result = "+1 " + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString() + " " + num3.ToString();
                lov.Text += result.ToString() + "\n";
            }
        }

        private void qweee_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                int num = rand.Next(000, 999);
                int num2 = rand.Next(00, 99);
                int num3 = rand.Next(00, 99);
                string result = "+2 " + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString() + " " + num3.ToString();
                lov.Text += result.ToString() + "\n";
            }
        }

        private void qweeee_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 15; i++)
            {
                int num = rand.Next(000, 999);
                int num2 = rand.Next(00, 99);
                int num3 = rand.Next(00, 99);
                string result = "+3 " + " " + num.ToString() + " " + num2.ToString() + " " + num3.ToString() + " " + num3.ToString();
                lov.Text += result.ToString() + "\n";
            }
        }

        private void cliar_Click(object sender, RoutedEventArgs e)
        {
            lov.Text = "";
        }

        private void namem_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                string[] menname = { "Павел", "lexa", "artem", "lom", "wd", "wdwww", "wdwdwdwdwd"};
                string namem = menname[rand.Next(0, 3)];
                lov.Text += namem.ToString() + "\n";
            }
        }

        private void pochta_Click(object sender, RoutedEventArgs e)
        {
            //string[] menname = { "qweertyuiio" };
            //string namem = "";
            //Random rand = new Random();
            //for (int j = 0; j < 2; j++)
            //{
            //    string result = namem.ToString() + " "  + "+3 " + " " + namem.ToString() + "" + ".ru";
            //    namem = menname[rand.Next(0, menname.Length)];
            //    lov.Text += result.ToString() + "\n";
            //}
            Random rand = new Random();
            for (int i = 0; i < 1; i++)
            {
                string[] menname = { "Павел", "lexa", "artem", "lom", "wd", "wdwww", "wdwdwdwdwd" };
                string[] menname1 = { ".ry", ".com", ".lob",  ".wwww", ".wwww сегодня мой адрес такой WWWWW" };
                string[] menname2 = { "Павел", "lexa", "artem", "lom", "wd", "wdwww", "wdwdwdwdwd" };

                string namem = menname[rand.Next(0, 7)] + " " + menname2[rand.Next(0, 7)] + " " + "@" + " "+  menname1[rand.Next(0, 5)];

                lov.Text += namem.ToString() + "\n";
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            //Сохранение файла
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Текстик (*.txt)|*.txt";

                if (saveFileDialog1.ShowDialog() == true)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile(), System.Text.Encoding.Default))
                    {
                        sw.Write(lov.Text);
                        sw.Close();
                    }
                }
            
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            //Открытие файла
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Текстик (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                StreamReader reader = new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251));

                lov.Text = reader.ReadToEnd();

                reader.Close();
                return;
            }
        }
        
    }
    }


//return result;
//string[] randoms = new string[20];
//randoms[0] =  "Granitsa@yandex.ru";
//randoms[1] =  "Granitsa@yandex.com";
//randoms[2] =  "Granitsa@yandex.sry";
//randoms[3] =  "Granitsa@yandex.bom";
//randoms[4] =  "Granitsa@yandex.lom";
//randoms[5] =  "Granitsa@yandex.ru";
//randoms[6] =  "Granitsa@yandex.com";
//randoms[7] =  "Granitsa@yandex.sry";
//randoms[8] =  "Granitsa@yandex.bom";
//randoms[9] =  "Granitsa@yandex.lom";
//randoms[10] = "Granitsa@yandex.ru";
//randoms[11] = "Granitsa@yandex.com";
//randoms[12] = "Granitsa@yandex.sry";
//randoms[13] = "Granitsa@yandex.bom";
//randoms[14] = "Granitsa@yandex.lom";
////Random r = new Random();
//string randsror = randoms[r.Next(0, randoms.Length - 1)];
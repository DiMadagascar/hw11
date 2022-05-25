using System;
using System.Collections.Generic;
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
using System.Xml.Serialization;
using System.IO;

namespace HW11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            StartWindow();
          
            //CreateClients();
        }
        public void StartWindow()
        {
            



        }
        //public void CreateClients()
        // {
        //     Random R = new Random();
        //     List<Clients> list = new List<Clients>();

        //     for (uint i = 1; i <= 5; i++)
        //     {
        //         list.Add(new Clients($"Имя_{i}", $"Фамилия_{i}", $"Отчество_{i}", 8928 + R.Next(0000000, 9999999), Convert.ToString(9612 + R.Next(111111, 999999))));
        //     }

        //     SerializeClientsList(list, "listClients.xml");
        // }
        static void SerializeClientsList(List<Clients> СoncreteClientsList, string Path)
        {
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Clients>));

            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            // Запускаем процесс сериализации
            xmlSerializer.Serialize(fStream, СoncreteClientsList);

            // Закрываем поток
            fStream.Close();
        }
        /// <summary>
        /// Метод десериализации Worker
        /// </summary>
        /// <param name="СoncreteWorker">Экземпляр для сериализации</param>
        /// <param name="Path">Путь к файлу</param>
        static List<Clients> DeserializeClientsList(string Path)
        {
            List<Clients> list = new List<Clients>();
            
            
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Clients>));

            // Создаем поток для чтения данных
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            // Запускаем процесс десериализации
            list = xmlSerializer.Deserialize(fStream) as List<Clients>;

            // Закрываем поток
            fStream.Close();

            // Возвращаем результат
            return list;
        }
        static List<Manager> DeserializeClientsListManager(string Path)
        {
            List<Manager> list = new List<Manager>();
           
            
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Consultant>));

            // Создаем поток для чтения данных
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            // Запускаем процесс десериализации
            list = xmlSerializer.Deserialize(fStream) as List<Manager>;

            // Закрываем поток
            fStream.Close();

            // Возвращаем результат
            return list;
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (Person.SelectedIndex ==0)
            {
                List<Clients> list = new List<Clients>();
                list = DeserializeClientsList("listClients.xml");
                list.OfType<Consultant>().ToList();
                TextBox1.Text = list[0].LastName;
                TextBox2.Text = list[0].FirstName;
                TextBox3.Text = list[0].Patronymic;
                TextBox4.Text = list[0].Phone.ToString();
                TextBox5.Text = list[0].PassportId.ToString();
            }
            else
            {
                List<Clients> list = new List<Clients>();
                list = DeserializeClientsList("listClients.xml");
                list.OfType<Manager>().ToList();
                TextBox1.Text = list[0].LastName;
                TextBox2.Text = list[0].FirstName;
                TextBox3.Text = list[0].Patronymic;
                TextBox4.Text = list[0].Phone.ToString();
                TextBox5.Text = list[0].PassportId.ToString();
            }
        }

        private void Person_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

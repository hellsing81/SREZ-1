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

namespace Laboratory.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu(int imageid, string fio)
        {
            InitializeComponent();

            //if (imageid == 1)
            //{
            //    img.Source = new BitmapImage(new Uri($"{Directory.GetCurrentDirectory()}/res/Администратор.png", UriKind.Relative));
            //    tbfio.Text = fio;
            //    tbrole.Text = "Администратор"; 
            //}
            //if (imageid == 2)
            //{
            //    img.Source = new BitmapImage(new Uri("res/Laborant_1.png", UriKind.Relative));
            //    tbfio.Text = fio;
            //    tbrole.Text = "Лаборант";
            //}
            //if (imageid == 3) 
            //    {
            //    img.Source = new BitmapImage(new Uri("res/Бухгалтер.jpeg", UriKind.Relative));
            //    tbfio.Text = fio;
            //    tbrole.Text = "Бухгалтер";
            //    }
            dginf.ItemsSource = DB.db.AccountData.ToList();
        }


    }
}

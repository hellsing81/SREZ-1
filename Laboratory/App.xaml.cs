
using Laboratory.Models;
using System.Windows;

namespace Laboratory
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static LaboratoryEntities DBConnection = new LaboratoryEntities();
    }
}

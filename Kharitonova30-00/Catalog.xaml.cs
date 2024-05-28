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

namespace Kharitonova30_00
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public Catalog()
        {
            InitializeComponent();
            Cars car1 = new Cars()
            {
                id = 1,
                carNumber = "А123НР47",
                carStatus = "Оплачен",
                carType = "Превышение скорости",
                carCost = 250
            };
            Cars car2 = new Cars()
            {
                id = 1,
                carNumber = "П277ЛВ47",
                carStatus = "Оплачен",
                carType = "Проезд под знак Разворот запрещен",
                carCost = 1000
            };
            Cars car3 = new Cars()
            {
                id = 1,
                carNumber = "Н184ГР48",
                carStatus = "Не оплачен",
                carType = "Вождение без страховки",
                carCost = 2000
            };
            Cars car4 = new Cars()
            {
                id = 1,
                carNumber = "Г222ВО90",
                carStatus = "Оплачен",
                carType = "Вождение в нетрезвом виде",
                carCost = 10000
            };
            Cars car5 = new Cars()
            {
                id = 1,
                carNumber = "Н404ЕО47",
                carStatus = "Не оплачен",
                carType = "Помогите, я застрял в матрице",
                carCost = 404
            };

            List<Cars> carList = new List<Cars>() { car1, car2, car3, car4, car5 };
            ListCatalog.ItemsSource = carList.ToList();
        }
    }
}

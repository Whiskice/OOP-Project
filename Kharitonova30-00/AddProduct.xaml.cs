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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbCost.Text.ToString()) || String.IsNullOrWhiteSpace(tbCost.Text.ToString())||
                String.IsNullOrEmpty(tbNumber.Text.ToString()) || String.IsNullOrWhiteSpace(tbNumber.Text.ToString()) ||
                String.IsNullOrEmpty(tbType.Text.ToString()) || String.IsNullOrWhiteSpace(tbType.Text.ToString()) ||
                String.IsNullOrEmpty(tbStatus.Text.ToString()) || String.IsNullOrWhiteSpace(tbStatus.Text.ToString()))
                {
                MessageBox.Show("Заполните все поля");
                }
            else
            {
                var lastId = AppFrame.carList.Capacity;
                try
                {
                    Cars newcars = new Cars()
                    {
                        id = lastId,
                        carNumber = tbNumber.Text.ToString(),
                        carType = tbType.Text.ToString(),
                        carStatus = tbStatus.Text.ToString(),
                        carCost = Convert.ToInt32(tbCost.Text.ToString())
                    };
                    AppFrame.carList.Add(newcars);
                    MessageBox.Show("Успешно добавлено");
                    AppFrame.frameMain.Navigate(new Catalog());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);   
                }
            }
            
        }
    }
}

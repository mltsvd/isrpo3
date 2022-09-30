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

namespace Практическая_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double[,] matr;
        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int columnIndex = e.Column.DisplayIndex;
            int rowIndex = e.Row.GetIndex();
            matr[rowIndex, columnIndex] = Convert.ToInt32(((TextBox)e.EditingElement).Text);
        }
        
        private void Заполнить_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(RowCount.Text, out int row) == true && Int32.TryParse(ColumnCount.Text, out int count) == true)
            {
                Class2.Init(out matr, count, row);
                dataGrid.ItemsSource = Class1.ToDataTable(matr).DefaultView;
            }
            else MessageBox.Show("Введены некорректные значения", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Создать_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(RowCount.Text, out int row) == true && Int32.TryParse(ColumnCount.Text, out int count) == true)
            {
                Class2.Create(out matr, count, row);
                dataGrid.ItemsSource = Class1.ToDataTable(matr).DefaultView;
            }
            else MessageBox.Show("Введены некорректные значения", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void Raschet_Click(object sender, RoutedEventArgs e)
        {
            Class2.Raschet(matr, out double summ);
            sum.Text = summ.ToString();

        }
        
    }
}

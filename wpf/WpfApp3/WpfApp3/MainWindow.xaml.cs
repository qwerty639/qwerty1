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

namespace WpfApp3
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

        private void Expander_Expanded(object cender, RoutedEventArgs e)
        {
            ((Expander)sender) = new Button() { Width = 80, Height = 30, Content = "Пивет"};
        }

        private void Expander_Collapsed(object cender, RoutedEventArgs e)
        {
            MessageBox.Show(" Экспандер свернут ");
        }
    }
}

using System.Windows;
using Practika01.masterDataSetTableAdapters;
namespace Practika01
{
    public partial class MainWindow : Window
    {
        buyerTableAdapter buyer = new buyerTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            buyerDataGrid.ItemsSource = buyer.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            POPA wim = new POPA();
            wim.Show();
        }

    }
}

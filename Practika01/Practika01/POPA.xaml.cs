using System.Windows;
using Practika01.masterDataSetTableAdapters;

namespace Practika01
{
    public partial class POPA : Window
    {
        saleTableAdapter sale = new saleTableAdapter();
        public POPA()
        {
            InitializeComponent();
            saleDataGrid.ItemsSource = sale.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PIPA wim = new PIPA();
            wim.Show();
        }
    }
}
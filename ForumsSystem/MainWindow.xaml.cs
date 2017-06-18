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


namespace ForumsSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<VisibleItem> dataList { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            LoadListItems();
        }


        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }



        private void LoadListItems()
        {
            dataList = new List<VisibleItem>();
            dataList = getDataList();
            ListBoxConverter.ItemsSource = dataList;
            this.ListBoxConverter.DataContext = this;
        }
        private List<VisibleItem> getDataList()
        {
            VisibleItem vItem;
            for (int i = 1; i < 15; i++)
            {
                vItem = new VisibleItem();
                vItem.Name = "Sub Forum  " + i;
                vItem.PictureID = i;
                vItem.SomeDetail = "Detail  " + i;
                dataList.Add(vItem);
            }
            return dataList;
        }
    }
}

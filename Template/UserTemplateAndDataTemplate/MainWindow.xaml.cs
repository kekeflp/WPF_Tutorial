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

namespace UserTemplateAndDataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IninalCarList();
        }

        // 选择事件
        private void lbxCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarListItemView cliv = e.AddedItems[0] as CarListItemView;
            if (cliv != null)
            {
                this.detailView.Car = cliv.Car;
            }
        }

        // 初始化ListBox
        private void IninalCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car(){Automaker="BYD",Name="宋",Year="2019",TopSpeed="200"},
                new Car(){Automaker="BYD",Name="秦",Year="2017",TopSpeed="240"},
                new Car(){Automaker="BYD",Name="唐",Year="2019",TopSpeed="220"},
                new Car(){Automaker="BYD",Name="元",Year="2020",TopSpeed="180"}
            };
            foreach (var item in carList)
            {
                CarListItemView cliv = new CarListItemView();
                cliv.Car = item;
                this.lbxCars.Items.Add(cliv);
            }
        }
    }
}

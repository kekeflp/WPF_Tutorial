using System.Collections.Generic;
using System.Windows;

namespace ValueConverter
{
    /// <summary>
    /// DataTemple.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemple : Window
    {
        public DataTemple()
        {
            InitializeComponent();
            IninalCarList();
        }

        private void IninalCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car(){Automaker="BYD",Name="宋",Year="2019",TopSpeed="200"},
                new Car(){Automaker="BYD",Name="秦",Year="2017",TopSpeed="240"},
                new Car(){Automaker="BYD",Name="唐",Year="2019",TopSpeed="220"},
                new Car(){Automaker="BYD",Name="元",Year="2020",TopSpeed="180"}
            };

            this.lbxListCar.ItemsSource = carList;
        }
    }
}
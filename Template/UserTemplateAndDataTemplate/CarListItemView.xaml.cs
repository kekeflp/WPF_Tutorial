using System;
using System.Collections.Generic;
using System.Text;
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
    /// CarListItemView.xaml 的交互逻辑
    /// </summary>
    public partial class CarListItemView : UserControl
    {
        public CarListItemView()
        {
            InitializeComponent();
        }

        private Car _car;
        public Car Car
        {
            get { return _car; }
            set
            {
                _car = value;
                this.tbkName.Text = Car.Name;
                this.tbkYear.Text = Car.Year;
                string uriStr = string.Format(@"/Resources/Logos/{0}.png", Car.Automaker);
                this.imageLogo.Source = new BitmapImage(new Uri(uriStr, UriKind.Relative));
            }
        }
    }
}

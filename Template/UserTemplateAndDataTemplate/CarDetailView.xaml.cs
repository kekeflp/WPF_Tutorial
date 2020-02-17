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
    /// CarDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class CarDetailView : UserControl
    {
        public CarDetailView()
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
                this.tbkTopspeed.Text = Car.TopSpeed;
                this.tbkAutomaker.Text = Car.Automaker;
                this.tbkYear.Text = Car.Year;
                string uriStr = string.Format(@"/Resources/Images/{0}.png", Car.Name);
                this.imagePhoto.Source = new BitmapImage(new Uri(uriStr, UriKind.Relative));
            }
        }
    }

}

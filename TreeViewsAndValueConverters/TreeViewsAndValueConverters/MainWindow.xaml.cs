using System;
using System.Collections.Generic;
using System.IO;
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

namespace TreeViewsAndValueConverters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Directory.GetLogicalDrives() 的作用是拿到本机的磁盘数量
            // 此处用for循环指定数量也可以
            foreach (var drive in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem();

                // 添加磁盘头和全路径
                item.Header = drive;
                item.Tag = drive;
                 
                // 添加一个空项目
                item.Items.Add(null);

                // 添加到主视图中
                FoldView.Items.Add(item);
            } 
        }
    }
}

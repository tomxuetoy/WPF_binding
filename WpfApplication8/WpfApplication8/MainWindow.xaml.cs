using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string str = "initial...";

        public MainWindow()
        {
            InitializeComponent();

            var t = new DispatcherTimer();
            // 1 second
            t.Interval = new TimeSpan(0, 0, 0, 0, 300);
            t.Tick += aaa;
            t.IsEnabled = true;
            t.Start();

            DataContext = this;
        }

        private void aaa(object sender, EventArgs e)
        {
            for (int i = 0; ; i++)
            {
                Names = i.ToString();
            }
        }

        public string Names
        {
            get { return str; }
            set { str = value; }
        }
    }
}

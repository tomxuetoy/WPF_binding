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

            //var timer = new System.Timers.Timer();
            //timer.Interval = 100;
            //timer.Elapsed += timer_Elapsed;
            //timer.Enabled = true;
            var t = new DispatcherTimer();
            // 1 second
            t.Interval = new TimeSpan(0, 0, 0, 0, 300);
            t.Tick += t_Tick;
            //t.IsEnabled = false;
            t.Start();

            DataContext = this;
        }

        int index = 0;

        void t_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            index++;
            this.Dispatcher.Invoke(delegate
            {
                Names = index + "";
            });
        }

        //void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    index++;
        //    this.Dispatcher.Invoke(delegate
        //    {
        //        Names = index + "";
        //    });
        //}

        //public string Names
        //{
        //    get { return str; }
        //    set { str = value; }
        //}

        private string Names
        {
            get { return (string)GetValue(NamesProperty); }
            set { SetValue(NamesProperty, value); }
        }

        private static readonly DependencyProperty NamesProperty =
            DependencyProperty.Register("Names2", typeof(string), typeof(MainWindow), new UIPropertyMetadata(string.Empty));
    }
}

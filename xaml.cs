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

namespace GoodTimes317324
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

        private void btncalculate_Click(object sender, RoutedEventArgs e)
        {
            int ottawa;
            int victoria = -300;
            int edmonton = -200;
            int winnepeg = -100;
            int toronto = 0;
            int halifax = 100;
            int stjohns = 130;

            int.TryParse(txttime.Text, out ottawa);

            //MessageBox.Show(ottawa.ToString());

            victoria = ottawa + victoria;
            edmonton = ottawa + edmonton;
            winnepeg = ottawa + winnepeg;
            toronto = ottawa + toronto;
            halifax = ottawa + halifax;
            stjohns = ottawa + stjohns;

            if (victoria < 0)
            {
                victoria = victoria + 2400;
            }

            if (edmonton < 0)
            {
                edmonton = edmonton + 2400;
            }

            if (winnepeg < 0)
            {
                winnepeg = winnepeg + 2400;
            }

            if (halifax > 2359)
            {
                halifax = halifax - 2400;
            }

            if (stjohns > 2359)
            {
                stjohns = stjohns - 2400;
            }
            MessageBox.Show(ottawa.ToString() + " in Ottawa" + Environment.NewLine +
                victoria.ToString() + " in Victoria" + Environment.NewLine +
                edmonton.ToString() + " in Edmonton" + Environment.NewLine +
                winnepeg.ToString() + " in Winnepeg" + Environment.NewLine +
                toronto.ToString() + " in Toronto" + Environment.NewLine +
                halifax.ToString() + " in Halifax" + Environment.NewLine +
                stjohns.ToString() + " in St. John's" + Environment.NewLine );


        }
    }
}

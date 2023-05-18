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

namespace Prog_124_S23_L11_ICompareable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<DemoCompare> _demoList = new List<DemoCompare>();
        

        public MainWindow()
        {
            InitializeComponent();
            _demoList.Add(new DemoCompare("Will", 10, new DateTime(1974, 8, 4)));
            _demoList.Add(new DemoCompare("Ronda", 15, new DateTime(1945, 8, 4)));
            _demoList.Add(new DemoCompare("Meili", 1, new DateTime(1999, 8, 4)));
            _demoList.Add(new DemoCompare("John", 24, new DateTime(2021, 8, 4)));
            _demoList.Add(new DemoCompare("Kai", 55, new DateTime(1933, 8, 4)));
            _demoList.Add(new DemoCompare("Henry", 111, new DateTime(1374, 8, 4)));
            _demoList.Add(new DemoCompare("Arsh", 65, new DateTime(1174, 8, 4)));

            _demoList.Sort();

            lbList.ItemsSource = _demoList;

            _demoList.Add(new DemoCompare("Sarah", 65, new DateTime(1174, 8, 4)));
            _demoList.Add(new DemoCompare("Ednalynn", 65, new DateTime(1174, 8, 4)));
            _demoList.Add(new DemoCompare("Cirella", 65, new DateTime(1174, 8, 4)));


        }


    }
}

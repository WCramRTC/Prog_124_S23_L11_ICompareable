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
        List<Student> _students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            // Adding 4 students to our students list
            _students.Add(new Student("Josh", "Emery", 110));
            _students.Add(new Student("Will", "Cram", 71));
            _students.Add(new Student("Ana", "Mendes", 120));
            _students.Add(new Student("David", "Selberg", 114));

            // Displaying the students to our list box
            lbList.ItemsSource = _students;


        }

        public void InterfaceExample()
        {
            //lbList.Items.Add("obj is an Object? - " + obj is object); // Will show true or false if the object IS an object
            //lbList.Items.Add("obj is an Door? - " + obj is Door); // Will show true or false if the object IS an object
            //lbList.Items.Add("obj is an DoubleDoor? - " + obj is DoorDouble); // Will show true or false if the object IS an object

            List<IOpen> _openableOjbects = new List<IOpen>();
            _openableOjbects.Add(new DoorSingle());
            _openableOjbects.Add(new DoorDouble());
            _openableOjbects.Add(new MyWindow());
            _openableOjbects.Add(new Jar());

            foreach (IOpen openable in _openableOjbects)
            {
                lbList.Items.Add(openable);
            }

            ////MessageBox.Show(obj.GetType().ToString());
            //Object obj = new MyWindow();
            //if (obj is IOpen)
            //{
            //    IOpen door = (IOpen)obj;
            //    MessageBox.Show(door.ToString());

            //}

            // What can we open
            // Doors
            // Windows
            // Containers
            // Applications
            // Eyes
        }

        public void TestCode()
        {
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

        private void btnSortGrade_Click(object sender, RoutedEventArgs e)
        {
            // Call the sort method on your students list
            _students.Sort();

            // Call Refresh on the listBox Items to update the list
            lbList.Items.Refresh();
        }

        private void btnSortFirst_Click(object sender, RoutedEventArgs e)
        {
            // Build instance of sort object
            StudentCompareFirstName sort = new StudentCompareFirstName();

            // Call list sort
            // PASS IN INSTANCE OF SORT OBJECT
            _students.Sort(sort);

            lbList.Items.Refresh();

        }

        private void btnSortLast_Click(object sender, RoutedEventArgs e)
        {
            _students.Sort(new StudentSortLastNameDesc());
            lbList.Items.Refresh();
        }
    }
}

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

namespace Icomparable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentList = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            Preload();

            Student_SortGenEdGrade grade = new Student_SortGenEdGrade();

            //studentList.Sort(grade);

            DisplayStudent();
        }

        
        void Preload()
        {
            studentList.Add(new Student("Will", "Cram"));
            studentList.Add(new Student("Anne", "Nguygen"));


        }

        

        public void DisplayStudent(List<Student>studentList,LbStudent lbStudent)
        {

            lbStudent.Items.Clear();

            foreach (Student student in studentList)
            {
                lbStudent.Items.Add(student);
            }
        }
    }  

}
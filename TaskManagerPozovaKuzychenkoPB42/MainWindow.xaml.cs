using System;
using System.Collections.Generic;
using System.Linq;
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
using TaskManagerPozovaKuzychenkoPB42.DataBase;
using TaskManagerPozovaKuzychenkoPB42.DataBase.Data;
using TaskManagerPozovaKuzychenkoPB42.DataBase.Data.Enums;

namespace TaskManagerPozovaKuzychenkoPB42
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Task> TODOTasks;
        private List<Task> InProgressTasks;
        private List<Task> DoneTasks;

        public MainWindow()
        {
            InitTasks();

            InitializeComponent();

            DataContext = TODOTasks;
            taskPriorityCB.SelectedIndex = 1;
        }

        private void AddNewTask_Click(object sender, RoutedEventArgs e)
        {
            Button sender1 = (Button)sender;
            string taskType = sender1.Name;

            if(taskType == "TODO")
            {

            }
            if(taskType == "InProgress")
            {

            }
            if (taskType == "Done")
            {

            }
        }

        private List<Task> GetTasks(TaskType taskType)
        {
            if(taskType == TaskType.ToDo)
            {
                List<Task> ToDoTasks = new List<Task>();

                Task task1 = new Task(1,"Название крутое","Очень классное описание",
                    DateTime.Today,DateTime.Today.AddDays(3),TaskPriority.Normal,TaskType.ToDo);

                ToDoTasks.Add(task1);
                return ToDoTasks;
            }
            return null;
        }

        private void InitTasks()
        {
            TODOTasks = new List<Task>(0);
            InProgressTasks = new List<Task>();
            DoneTasks = new List<Task>();

            Task task1 = new Task(1,"Название очень", "Очень классное описание",
                    DateTime.Today, DateTime.Today, TaskPriority.Normal, TaskType.ToDo);

            Task task2 = new Task(2,"Название крутое", "Очень классное описание",
                    DateTime.Today, DateTime.Today, TaskPriority.Normal, TaskType.ToDo);

            TODOTasks.Add(task1);
            TODOTasks.Add(task2);
            TODOTasks.Add(task1);
            TODOTasks.Add(task2);
            TODOTasks.Add(task1);
            TODOTasks.Add(task2);
            TODOTasks.Add(task1);
            TODOTasks.Add(task2);
        }
    }
}

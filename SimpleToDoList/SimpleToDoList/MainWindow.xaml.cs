using SimpleToDoList.Info;
using SimpleToDoList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace SimpleToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\toDoDataList.json";
        private BindingList<ToDoModel> _toDoDataList;
        private ReadAndWriteInfo _rAndwService;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _rAndwService = new ReadAndWriteInfo(PATH);
            _toDoDataList = new BindingList<ToDoModel>()
            {
                new ToDoModel{Text = "pew" }
            };
            try
            {
                _toDoDataList = _rAndwService.LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            DataGridToDo.ItemsSource = _toDoDataList;
            _toDoDataList.ListChanged += _toDoDataList_ListChanged;
        }

        private void _toDoDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted
                || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _rAndwService.WriteData(sender);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }
    }
}

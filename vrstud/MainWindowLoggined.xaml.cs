using System;
using System.Collections.Generic;
using System.Windows;

namespace vrstud
{
    public partial class MainWindowLoggined : Window
    {
        public int CountGroups { get; set; } = 3;
        public MainWindowLoggined()
        {
            InitializeComponent();
            GroupsList.ItemsSource = CreateGroups();
            StudentsList.ItemsSource = CreateStudents();
        }

        private List<ToDoItem> CreateGroups()
        {
            var groups = new List<ToDoItem>();
            var dataGroups = GetGroupsData();
            for (var i = 0; i < CountGroups; i++)
            {
                groups.Add(new ToDoItem{Title = dataGroups[i].Item1, Id = dataGroups[i].Item2});
            }

            return groups;
        }

        private static (string, int)[] GetGroupsData()
        {
            return new[] {("РИ-280012", 0), ("РИ-280013", 1), ("РИ-280014", 2)};
        }
        
        private List<ToDoItem> CreateStudents()
        {
            var groups = new List<ToDoItem>();
            var dataGroups = GetStudentsData();
            for (var i = 0; i < CountGroups; i++)
            {
                groups.Add(new ToDoItem{Title = dataGroups[i].Item1, Id = dataGroups[i].Item2});
            }

            return groups;
        }

        private static (string, int)[] GetStudentsData()
        {
            return new[] {("Корабельников А. С.", 0), ("Плужник Е. А.", 1), ("Семенченко А. В.", 2)};
        }

        private void ShowChangeGroup(object sender, RoutedEventArgs e)
        {
            var form = new Students();
            form.Show();
        }
    }
}
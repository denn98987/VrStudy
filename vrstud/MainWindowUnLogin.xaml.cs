﻿using System.Windows;

namespace vrstud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Show(object sender, RoutedEventArgs e)
        {
            var LoginForm = new LogIn();
            LoginForm.ShowDialog();
        }
    }
}
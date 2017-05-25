﻿using System;
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

namespace TextAdventure
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Inventory i = new Inventory();
            BitmapImage lvl1 = new BitmapImage(new Uri("/TextAdventure;component/Images/AdventureLVL1.jpg", UriKind.Relative));
            string action = tbxAction.Text;
            if ((action.Contains("start") || action.Contains("Start")) && !tbxName.Text.Equals(""))
            {
                imgLevel.Source = lvl1;
            }
            else
            {
                tbxAction.Text = "Set Your Name";
            }
        }
    }
}

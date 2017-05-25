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
            game();
        }

        private void game()
        {
            Inventory i = new Inventory();
            BitmapImage title = new BitmapImage(new Uri("/TextAdventure;component/Images/Title.png", UriKind.Relative));
            BitmapImage lvl1 = new BitmapImage(new Uri("/TextAdventure;component/Images/AdventureLVL1.jpg", UriKind.Relative));
            BitmapImage chest = new BitmapImage(new Uri("/TextAdventure;component/Images/InsideChest.png", UriKind.Relative));
            string action = tbxAction.Text;
            if ((action.Equals("start") || action.Equals("Start")))
            {
                imgLevel.Source = lvl1;
                tbxlStory.Text = "You are in the bedroom, you see a chest in the room, it appears to be unlocked, the door on the other hand is not.";
            }
            else if (action.Equals("Open chest"))
            {
                imgLevel.Source = chest;
            }
            else if (action.Equals("Leave Chest"))
            {
                imgLevel.Source = lvl1;
            }

            if (action.Contains("Armor"))
            {
                lbxItems.Text =  i.generateInventory(action);
            }

            if (lbxItems.Text.Contains("Leather Armor"))
            {
                tbxDefense.Text = "3";
            }
            tbxAction.Text = "";
        }
    }
}

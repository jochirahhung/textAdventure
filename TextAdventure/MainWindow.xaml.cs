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
            Enemy e = new Enemy();
            BitmapImage title = new BitmapImage(new Uri("/TextAdventure;component/Images/Title.png", UriKind.Relative));
            BitmapImage lvl1 = new BitmapImage(new Uri("/TextAdventure;component/Images/AdventureLVL1.jpg", UriKind.Relative));
            BitmapImage chest = new BitmapImage(new Uri("/TextAdventure;component/Images/InsideChest.png", UriKind.Relative));
            BitmapImage livingroom = new BitmapImage(new Uri("/TextAdventure;component/Images/living-room.png", UriKind.Relative));
            BitmapImage hallway = new BitmapImage(new Uri("/TextAdventure;component/Images/Hallway.png", UriKind.Relative));


            BitmapImage dragon = new BitmapImage(new Uri("/TextAdventure;component/Images/dragon.png", UriKind.Relative));
            BitmapImage goblin = new BitmapImage(new Uri("/TextAdventure;component/Images/goblin.png", UriKind.Relative));
            BitmapImage Ogre = new BitmapImage(new Uri("/TextAdventure;component/Images/Ogre.png", UriKind.Relative));
            BitmapImage Orc = new BitmapImage(new Uri("/TextAdventure;component/Images/Orc.png", UriKind.Relative));
            BitmapImage Thug = new BitmapImage(new Uri("/TextAdventure;component/Images/thug.png", UriKind.Relative));
            string action = tbxAction.Text;
            if ((action.Equals("start") || action.Equals("Start")))
            {
                imgLevel.Source = lvl1;
                tbxlStory.Text = "You are in the bedroom, you see a chest in the room, it appears to be unlocked, the door on the other hand is not.";
                imgenemy.Source = dragon;
            }
            else if (action.Equals("Open chest"))
            {
                imgLevel.Source = chest;
            }
            else if (action.Equals("Leave chest"))
            {
                imgLevel.Source = lvl1;
            }

            if (action.Contains("Armor"))
            {
                tbxArmor.Text =  i.generateInventory(action);
            }

            if (tbxArmor.Text.Contains("Leather Armor"))
            {
                tbxDefense.Text = "6";
            }
            else if (tbxArmor.Text.Contains("Bronze Armor"))
            {
                tbxDefense.Text = "8";
            }
            else if (tbxArmor.Text.Contains("Iron Armor"))
            {
                tbxDefense.Text = "10";
            }
            else if (tbxArmor.Text.Contains("Steel Armor"))
            {
                tbxDefense.Text = "12";
            }

            if (action.Contains("Sword"))
            {
                tbxWeapon.Text = i.generateInventory(action);
            }

            if (tbxWeapon.Text.Contains("Bronze Sword"))
            {
                tbxDamage.Text = "6";
            }
            else if (tbxWeapon.Text.Contains("Iron Sword"))
            {
                tbxDamage.Text = "8";
            }
            else if (tbxWeapon.Text.Contains("Steel Sword"))
            {
                tbxDamage.Text = "10";
            }
            else if (tbxWeapon.Text.Contains("Titanium Sword"))
            {
                tbxDamage.Text = "12";
            }

            if (action.Contains("Key"))
            {
                tbxKey.Text = i.generateInventory(action);
            }

            if (action.Equals("Open Door", StringComparison.CurrentCultureIgnoreCase))
            {
                imgLevel.Source = hallway;
                tbxlStory.Text = "As you open up the door and walk through it you enter a hallway that is poorly lit.As you walk down the hall you see two doors without knobs,which leads you to go to the living room";
            }

            if (action.Contains("Fight"))
            {
                if (action.Contains("dragon") || action.Contains("Dragon"))
                {
                    e.setEnemy(EnemeyTypes.DRAGON, int.Parse(tbxLevel.Text));
                    tbxEnemyHeatlh.Text = e.getHealth().ToString();
                    tbxEnemyLVL.Text = e.getLevel().ToString();
                }

                if (action.Contains("goblin") || action.Contains("Goblin"))
                {
                    e.setEnemy(EnemeyTypes.ORC, int.Parse(tbxLevel.Text));
                    tbxEnemyHeatlh.Text = e.getHealth().ToString();
                    tbxEnemyLVL.Text = e.getLevel().ToString();
                }
                if (action.Contains("orc") || action.Contains("Orc"))
                {
                    e.setEnemy(EnemeyTypes.ORC, int.Parse(tbxLevel.Text));
                    tbxEnemyHeatlh.Text = e.getHealth().ToString();
                    tbxEnemyLVL.Text = e.getLevel().ToString();
                }
            }

            tbxAction.Text = "";
        }
    }
}

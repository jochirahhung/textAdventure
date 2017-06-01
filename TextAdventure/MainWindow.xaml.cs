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
            Random rnd = new Random();
            Inventory i = new Inventory();
            Enemy e = new Enemy();
            BitmapImage title = new BitmapImage(new Uri("/TextAdventure;component/Images/Title.png", UriKind.Relative));
            BitmapImage lvl1 = new BitmapImage(new Uri("/TextAdventure;component/Images/AdventureLVL1.jpg", UriKind.Relative));
            BitmapImage chest = new BitmapImage(new Uri("/TextAdventure;component/Images/InsideChest.png", UriKind.Relative));
            BitmapImage livingroom = new BitmapImage(new Uri("/TextAdventure;component/Images/living-room.png", UriKind.Relative));
            BitmapImage hallway = new BitmapImage(new Uri("/TextAdventure;component/Images/Hallway.png", UriKind.Relative));
            BitmapImage kitchen = new BitmapImage(new Uri("/TextAdventure;component/Images/Kitchen.png", UriKind.Relative));

            BitmapImage dragon = new BitmapImage(new Uri("/TextAdventure;component/Images/dragon.png", UriKind.Relative));
            BitmapImage goblin = new BitmapImage(new Uri("/TextAdventure;component/Images/goblin.png", UriKind.Relative));
            BitmapImage Ogre = new BitmapImage(new Uri("/TextAdventure;component/Images/Ogre.png", UriKind.Relative));
            BitmapImage Orc = new BitmapImage(new Uri("/TextAdventure;component/Images/Orc.png", UriKind.Relative));
            BitmapImage Thug = new BitmapImage(new Uri("/TextAdventure;component/Images/thug.png", UriKind.Relative));

            BitmapImage Key = new BitmapImage(new Uri("/TextAdventure;component/Images/Key.png", UriKind.Relative));
            BitmapImage Leather = new BitmapImage(new Uri("/TextAdventure;component/Images/leatherarmor.png", UriKind.Relative));

            BitmapImage bronzeSword = new BitmapImage(new Uri("/TextAdventure;component/Images/bronzesword.png", UriKind.Relative));
            string action = tbxAction.Text;
            if ((action.Equals("start") || action.Equals("Start")))
            {
                imgLevel.Source = lvl1;
                tbxlStory.Text = "You are in the bedroom, you see a chest in the room, it appears to be unlocked, the door on the other hand is not.";
            }
            else if (action.Equals("Open chest", StringComparison.CurrentCultureIgnoreCase))
            {
                tbxlStory.Text = "You open the chest and inside is the leather armor, and a key";
                imgLevel.Source = chest;
                imgArmor.Source = Leather;
                imgKey.Source = Key;
            }
            else if (action.Equals("Leave chest"))
            {
                imgLevel.Source = lvl1;
                tbxlStory.Text = "You are in the bedroom, you see a chest in the room, it appears to be unlocked, the door on the other hand is not.";
            }

            if (action.Contains("Armor"))
            {
                tbxArmor.Text =  i.generateInventory(action);
            }

            if (tbxArmor.Text.Contains("Leather Armor"))
            {
                tbxDefense.Text = "6";
                imgArmor.Source = null;
            }
            else if (tbxArmor.Text.Contains("Bronze Armor"))
            {
                tbxDefense.Text = "8";
                imgArmor.Source = null;
            }
            else if (tbxArmor.Text.Contains("Iron Armor"))
            {
                tbxDefense.Text = "10";
                imgArmor.Source = null;
            }
            else if (tbxArmor.Text.Contains("Steel Armor"))
            {
                tbxDefense.Text = "12";
                imgArmor.Source = null;
            }

            if (action.Contains("Sword"))
            {
                tbxWeapon.Text = i.generateInventory(action);
            }

            if (tbxWeapon.Text.Contains("Bronze Sword"))
            {
                tbxDamage.Text = "6";
                imgSword.Source = null;
            }
            else if (tbxWeapon.Text.Contains("Iron Sword"))
            {
                tbxDamage.Text = "8";
                imgSword.Source = null;
            }
            else if (tbxWeapon.Text.Contains("Steel Sword"))
            {
                tbxDamage.Text = "10";
                imgSword.Source = null;
            }
            else if (tbxWeapon.Text.Contains("Titanium Sword"))
            {
                tbxDamage.Text = "12";
                imgSword.Source = null;
            }

            if (action.Contains("Key"))
            {
                tbxKey.Text = i.generateInventory(action);
                imgKey.Source = null;
            }

            if (action.Equals("Open Door", StringComparison.CurrentCultureIgnoreCase) && tbxKey.Text.Equals("Key"))
            {
                imgLevel.Source = hallway;
                imgSword.Source = bronzeSword;
                tbxKey.Text = "";
                tbxlStory.Text = "As you open up the door and walk through it you enter a hallway that is poorly lit.As you walk down the hall you see two doors without knobs,which leads you to go to the living room, there is also a bronze sword stuck in the wall, you may take it.";
            }

            if (action.Contains("Go") || action.Contains("go"))
            {
                if (action.Contains("kitchen") || action.Contains("Kitchen"))
                {

                }
                else if (action.Contains("dining room") || action.Contains("Dining room"))
                {

                }
                else if (action.Contains("Storage") || action.Contains("storage"))
                {

                }
                else if (action.Contains("basement") || action.Contains("Basement"))
                {

                }
                else if (action.Contains("Outside") || action.Contains("outside"))
                {

                }
                else if (action.Contains("hallway") || action.Contains("Hallway"))
                {

                }
                else if (action.Contains("bedroom") || action.Contains("Bedroom"))
                {

                }
                else if (action.Contains("living room") || action.Contains("Living room"))
                {
                    imgLevel.Source = livingroom;
                    tbxlStory.Text = "You enter the living room to find an orc in the area, you have to fight him to pass!";
                    imgenemy.Source = Orc;
                    tbxEnemy.Text = "Orc";
                }
                else
                {
                    tbxlStory.Text = "Sorry this room does not exist, please try another room";
                }
            }

            if (action.Contains("Fight"))
            {
                if (action.Contains("dragon") || action.Contains("Dragon"))
                {
                    e.setEnemy(EnemeyTypes.DRAGON, int.Parse(tbxLevel.Text));
                    tbxEnemyHeatlh.Text = e.getHealth().ToString();
                    tbxEnemyLVL.Text = e.getLevel().ToString();
                }

                else if (action.Contains("goblin") || action.Contains("Goblin"))
                {
                    e.setEnemy(EnemeyTypes.ORC, int.Parse(tbxLevel.Text));
                    tbxEnemyHeatlh.Text = e.getHealth().ToString();
                    tbxEnemyLVL.Text = e.getLevel().ToString();
                }
                else if (action.Contains("orc") || action.Contains("Orc"))
                {
                    e.setEnemy(EnemeyTypes.ORC, int.Parse(tbxLevel.Text));
                    tbxEnemyHeatlh.Text = e.getHealth().ToString();
                    tbxEnemyLVL.Text = e.getLevel().ToString();
                }
                else if (action.Contains("ogre") || action.Contains("Ogre"))
                {
                    e.setEnemy(EnemeyTypes.OGRE, int.Parse(tbxLevel.Text));
                    tbxEnemyHeatlh.Text = e.getHealth().ToString();
                    tbxEnemyLVL.Text = e.getLevel().ToString();
                }
                else if (action.Contains("thug") || action.Contains("Thug"))
                {
                    e.setEnemy(EnemeyTypes.THUG, int.Parse(tbxLevel.Text));
                    tbxEnemyHeatlh.Text = e.getHealth().ToString();
                    tbxEnemyLVL.Text = e.getLevel().ToString();
                }
            }

            if (action.Equals("Attack", StringComparison.CurrentCultureIgnoreCase))
            {
                int healthLoss = int.Parse(tbxEnemyHeatlh.Text);
                healthLoss = healthLoss - int.Parse(tbxDamage.Text);
                if (healthLoss <= 0)
                {
                    imgenemy.Source = null;
                    int exp = int.Parse(tbxEXP.Text);
                    exp = exp + e.getEXP();
                    tbxEXP.Text = exp.ToString();
                    tbxEnemyHeatlh.Text = "0";
                    tbxEnemyLVL.Text = "0";
                    tbxEnemy.Text = "";
                }
                else
                {
                    tbxEnemyHeatlh.Text = healthLoss.ToString();
                    int chance = rnd.Next(1, 4);
                    if (chance >= 3)
                    {
                        int health = int.Parse(tbxHealth.Text);
                        health = health - e.getDamage();
                        tbxHealth.Text = health.ToString();
                    }
                }
            }
            int trueHealth = int.Parse(tbxHealth.Text);
            if (trueHealth <= 0)
            {
                tbxlStory.Text = "GAME OVER!!!!!";
            }
            int lvlUP = int.Parse(tbxEXP.Text);
            if (lvlUP >= 25)
            {
                int lvl = int.Parse(tbxLevel.Text);
                lvl = lvl+1;
                tbxLevel.Text = lvl.ToString();
                tbxEXP.Text = "0";
            }

            tbxAction.Text = "";
        }
    }
}

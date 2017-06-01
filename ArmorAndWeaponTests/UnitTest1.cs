using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextAdventure;

namespace ArmorAndWeaponTests
{
    [TestClass]
    public class ArmorAndWeapons
    {
        [TestMethod]
        public void generateAWeapon()
        {
            string weapon = "bronze sword";
            Inventory i = new Inventory();
            Assert.IsNotNull(i.generateInventory(weapon));
            
        }

        [TestMethod]
        public void generateArmor()
        {
            string weapon = "steel armor";
            Inventory i = new Inventory();
            Assert.IsNotNull(i.generateInventory(weapon));
        }
        [TestMethod]
        public void generateAWeaponWrong()
        {
            string weapon = "Plastic Sword";
            Inventory i = new Inventory();
            Assert.IsNull(i.generateInventory(weapon));

        }

        [TestMethod]
        public void generateArmorWrong()
        {
            string weapon = "Plastic Armor";
            Inventory i = new Inventory();
            Assert.IsNull(i.generateInventory(weapon));
        }
    }
}

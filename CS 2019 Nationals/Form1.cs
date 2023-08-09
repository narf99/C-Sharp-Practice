using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS_2019_Nationals
{
    public partial class Form1 : Form
    {
        static readonly Random rnd = new Random();

        static readonly List<Item> allItems = new List<Item> {
            new Item("Bag of Holding", 1, 200, "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 Nationals/Images/bag_of_holding.png"),
            new Weapon("1d8", "Battle-Axe", 7, 80, "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 Nationals/Images/battleaxe.png"),
            new Armor("18", "Blue Dragon Armor", 45, 150, "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 Nationals/Images/blue_dragon_armor.png"),
            new Weapon("2d6", "Greatsword", 15, 100, "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 Nationals/Images/greatsword.png"),
            new Item("Potion", 1, 50, "C:/Users/TUCKDL2/OneDrive - Idaho National Laboratory/programing/CS 2019 Nationals/Images/potion.png")
        };

        readonly Character player = new Character(rnd.Next(200, 400), new List<Item> { allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)] });

        Character shop = new Character(rnd.Next(1000, 1200), new List<Item> { allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)] });


        public Form1()
        {
            InitializeComponent();
            updatePlayer(player);
            updateShop(shop);
        }


        private void loadBtn_Click(object sender, EventArgs e)
        {
            // this loads a save file

            // open the save
            OpenFileDialog loadSave = new OpenFileDialog
            {
                InitialDirectory = "C://",
                Filter = "Text files (*.xml)|*.xml|All files (*.*)|*.*"
            };

            // if opening the save was succesfull
            if (loadSave.ShowDialog() == DialogResult.OK)
            {
                // load and update the player
                player.LoadSave(loadSave.FileName, allItems);
                updatePlayer(player);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // get and save the save
            File.WriteAllText("player_save.xml", player.GetSave(allItems));

            // confirm to the user
            MessageBox.Show("Player save saved in game path.", "File Saved", MessageBoxButtons.OK);
        }

        private void questBtn_Click(object sender, EventArgs e)
        {
            // this takes care of auto questing
            player.Gold += rnd.Next(20, 41);
            updatePlayer(player);
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            // this handles about a third of the logic behind buying items

            int selectedItemIndex = getSelectedItem(shopBox);

            // if an item is selected
            if (selectedItemIndex != -1)
            {
                // if the player can buy the item have the shop sell it and update both the shop and the player
                if (player.Buy(allItems[selectedItemIndex]))
                {
                    shop.Sell(allItems[selectedItemIndex]);
                    updateShop(shop);
                    updatePlayer(player);
                }
            }
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            // this handles about a third of the logic of selling items

            int selectedItemIndex = getSelectedItem(playerBox);

            // if an item has been selected
            if (selectedItemIndex != -1)
            {
                // if the shop can afford the item have the player sell it and update the shop and player
                if (shop.Buy(allItems[selectedItemIndex]))
                {
                    player.Sell(allItems[selectedItemIndex]);
                    updateShop(shop);
                    updatePlayer(player);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // confirm that the user wants to exit
            if (MessageBox.Show("Are you sure you wish to exit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            // create and update a new shop
            shop = new Character(rnd.Next(1000, 1200), new List<Item> { allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)], allItems[rnd.Next(5)] });
            updateShop(shop);
        }

        private void playerBox_SelectedIndexChanged(object sender, EventArgs e) => getSelectedItem(playerBox);
        
        private void shopBox_SelectedIndexChanged(object sender, EventArgs e) => getSelectedItem(shopBox);

        private int getSelectedItem(ListBox box)
        {
            // this function gets and returns the selected index of the selected item within the all items list. return -1 if nothing is selected
            // this handles a third of the logic of buying and selling items

            // this try catch block makes sure something is selected
            try
            {
                // go through every item
                for (int i = 0; i < allItems.Count(); i++)
                {
                    // check to see if the selected items name matches the name of another item
                    if (allItems[i].Name == box.SelectedItem.ToString())
                    {
                        // update the center screen
                        itemInfo.Text = allItems[i].GetInformationString();
                        pictureBox1.ImageLocation = allItems[i].Image;

                        // return the index
                        return i;
                    }
                }
                return -1;
            }
            // if there is nothing selected return that there is nothing selected
            catch (NullReferenceException)
            {
                Console.WriteLine("Nothing is selected");
                return -1;
            }
        }
    }

    public class Item
    {
        // these are protected so that other classes can inherit from them but they aren't public
        protected string name;
        protected double weight;
        protected double value;
        protected string image;
        

        public Item(string name, double weight, double value, string image)
        {
            this.name = name;
            this.weight = weight;
            this.value = value;
            this.image = image;
        }

        // this returns the string to be used in the center of the screen
        public virtual string GetInformationString() => "Name: " + name + "\n Weight: " + weight + "\n Value: " + value;

        // properties
        public string Image => image;

        public string Name => name;

        public double Value => value;
    }

    public class Weapon : Item
    {
        readonly string baseDamage;

        public Weapon(string baseDamage, string name, double weight, double value, string image) : base(name, weight, value, image)
        {
            this.baseDamage = baseDamage;
        }

        public override string GetInformationString() => base.GetInformationString() + "\n Damage: " + baseDamage;
    }

    public class Armor : Item
    {
        readonly string baseArmor;

        public Armor(string baseArmor, string name, double weight, double value, string image) : base(name, weight, value, image)
        {
            this.baseArmor = baseArmor;
        }

        public override string GetInformationString() => base.GetInformationString() + "\n Armor: " + baseArmor;
    }

    public class Character
    {
        double gold;
        List<Item> items;

        public Character(double gold, List<Item> items)
        {
            this.gold = gold;
            this.items = items;
        }

        public bool Buy(Item item)
        {
            // this handles a third of the logic of buying items

            // this checks to see if the character can afford the item and if it can it adds the item to the inventory and subtracts the gold from the characters gold
            if (item.Value <= gold)
            {
                items.Add(item);
                gold -= item.Value;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void Sell(Item item)
        {
            // This handles a third of the logic of selling items

            // it removes the item from the characters inventory and adds the items value to the characters gold
            items.Remove(item);
            gold += item.Value;
        }

        public string GetSave(List<Item> allItems)
        {
            // this generates the save string

            string save = string.Empty;

            // save the gold. we are preforming some math to make it less obvious what the gold is in the save
            double savedGold = ((gold*10)/2) - 27;
            save += savedGold + " ";

            // save the items. we are saving their indexs as read in the program to make loading a save easier
            for (int i = items.Count - 1; i >= 0; i--)
            {
                for (int I = 4; I >= 0; I--)
                {
                    if (allItems[I].Name == items[i].Name)
                    {
                        save += I + " ";
                    }
                }
            }

            return save;
        }

        public void LoadSave(string save, List<Item> allItems)
        {
            // this loads a save

            string saveData = File.ReadAllText(save);
            string tempGold = string.Empty;

            // gold
            // this while loop reads the save until it runs into a space which is the divider between the gold and the items
            int i = 0;
            while (saveData[i] != ' ')
            {
                tempGold += saveData[i];
                i++;
            }
            gold = ((Convert.ToDouble(tempGold) + 27)*2)/10;

            // items
            items = new List<Item> { };
            for (i++;  i < saveData.Length; i += 2)
            {
                items.Add(allItems[Convert.ToInt32(saveData[i].ToString())]); // this line of code is stupid XD
            }
        }
        
        // properties
        public double Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        public List<Item> Items => items;
    }
}

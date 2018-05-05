using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStripMenuItemssample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_MenuToolStripMenuItem();
        }

        private void Load_MenuToolStripMenuItem()
        {
            //create count to retrieved tag or id of clicked item
            int id = 0;

            //retrieve all menu items
            foreach (String items in Get_Item_For_Menu())
            {
                //Create ToolStripMenuItem to asign values
                ToolStripMenuItem item = new ToolStripMenuItem(items);
                item.Tag = id;

                //incremente id to make it "unique"
                id++;

                //add ToolStripMenuItem to toolStripMenuItem1 we added in form 1
                toolStripMenuItem1.DropDownItems.Add(item);

                //set up click event for each clicked item. 
                item.Click += new EventHandler(Item_click);

            }
        }

        //triggers every time an item is clicked. 
        private void Item_click(Object sender, EventArgs e)
        {

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            MessageBox.Show(item.Text + " " + item.Tag);

        }


        //create list of items used in menu. 
        private List<String> Get_Item_For_Menu()
        {

            List<String> menu_items = new List<String>();

            menu_items.Add("ALABAMA");
            menu_items.Add("ALASKA");
            menu_items.Add("ARKANSAS");
            menu_items.Add("CALIFORNIA");
            menu_items.Add("COLORADO");
            menu_items.Add("CONNECTICUT");
            menu_items.Add("DELAWARE");
            menu_items.Add("FLORIDA");
            menu_items.Add("ALABAMA");

            return menu_items;

        }
    }
}

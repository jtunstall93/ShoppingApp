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

namespace Shopping_App
{
	public partial class EditList_Window : Form
	{
		DataTypes.ShoppingList currList = new DataTypes.ShoppingList();

		public EditList_Window()
		{
			InitializeComponent();
		}

		private void SaveItemButton_Click(object sender, EventArgs e)
		{
			currList.GetList()[EditList_ListBox.SelectedIndex].itemName = ItemNameEntryBox.Text;
			currList.GetList()[EditList_ListBox.SelectedIndex].purchaseLocation = ItemLocationEntryBox.Text;
			currList.GetList()[EditList_ListBox.SelectedIndex].itemCost = (float)ItemCostEntryBox.Value;
			currList.GetList()[EditList_ListBox.SelectedIndex].itemQuantity = (int)ItemQuantityEntryBox.Value;
			currList.GetList()[EditList_ListBox.SelectedIndex].itemMaxQuantity = (int)ItemMaxQuantityEntryBox.Value;
		}

		private void LoadListButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog log = new OpenFileDialog();
			string filePath = "";

			if (log.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				filePath = log.FileName;

				//Order: Name, price, location, quantity, max quantity
				StreamReader reader = new StreamReader(filePath);
				DataTypes.ShoppingList list = new DataTypes.ShoppingList();

				list.SetListName(reader.ReadLine());
				
				while (!reader.EndOfStream)
				{
					DataTypes.ListItem item;
					string name = "";
					string location = "";
					double price = 0;
					int quantity = 0;
					int maxQuantity = 0;

					name = reader.ReadLine();
					price = Convert.ToDouble(reader.ReadLine());
					location = reader.ReadLine();
					quantity = Convert.ToInt32(reader.ReadLine());
					maxQuantity = Convert.ToInt32(reader.ReadLine());

					item = new DataTypes.ListItem(name, location, quantity, maxQuantity, (float)price);
					list.AddItem(item);
				}

				reader.Close();

				currList = list;
				EditList_ListBox.Items.Clear();
				EditList_ListBox.Items.AddRange(currList.GetNameList().ToArray());
				ListBoxLabel.Text = currList.GetListName();

				#region Visibility toggles
				ItemNameLabel.Visible = true;
				ItemNameEntryBox.Visible = true;

				ItemLocationLabel.Visible = true;
				ItemLocationEntryBox.Visible = true;

				ItemCostLabel.Visible = true;
				ItemCostEntryBox.Visible = true;

				ItemQuantityLabel.Visible = true;
				ItemQuantityEntryBox.Visible = true;

				ItemMaxQuantityLabel.Visible = true;
				ItemMaxQuantityEntryBox.Visible = true;

				ListBoxLabel.Visible = true;
				EditList_ListBox.Visible = true;

				SaveItemButton.Visible = true;
				DeleteItemButton.Visible = true;
				LoadListButton.Visible = true;
				SaveListButton.Visible = true;
				AddItemButton.Visible = true;
				#endregion
			}
		}

		private void SaveListButton_Click(object sender, EventArgs e)
		{
			if (currList.GetList().Count == 0)
				return;

			string specialPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string fileName = currList.GetListName() + ".txt";
			string filePath = specialPath + @"\" + fileName;
			//Order: Name, price, location, quantity, max quantity
			StreamWriter writer = new StreamWriter(filePath);

			writer.WriteLine(currList.GetListName());

			for (int i = 0; i < currList.GetList().Count; i++)
			{
				//writer.WriteLine("#");
				writer.WriteLine(currList.GetList()[i].itemName);
				writer.WriteLine(currList.GetList()[i].itemCost);
				writer.WriteLine(currList.GetList()[i].purchaseLocation);
				writer.WriteLine(currList.GetList()[i].itemQuantity);
				writer.WriteLine(currList.GetList()[i].itemMaxQuantity);
			}

			writer.Close();
		}

		private void EditList_ListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (currList.GetList().Count == 0 || EditList_ListBox.SelectedIndex == -1)
				return;

			ItemNameEntryBox.Text = currList.GetList()[EditList_ListBox.SelectedIndex].itemName;
			ItemLocationEntryBox.Text = currList.GetList()[EditList_ListBox.SelectedIndex].purchaseLocation;
			ItemCostEntryBox.Value = (decimal)currList.GetList()[EditList_ListBox.SelectedIndex].itemCost;
			ItemQuantityEntryBox.Value = currList.GetList()[EditList_ListBox.SelectedIndex].itemQuantity;
			ItemMaxQuantityEntryBox.Value = currList.GetList()[EditList_ListBox.SelectedIndex].itemMaxQuantity;
		}

		private void DeleteItemButton_Click(object sender, EventArgs e)
		{
			currList.RemoveItem(EditList_ListBox.SelectedIndex);
			EditList_ListBox.Items.RemoveAt(EditList_ListBox.SelectedIndex);
		}

		private void AddItemButton_Click(object sender, EventArgs e)
		{
			if (ItemNameEntryBox.Text == "The name of the item" || ItemLocationEntryBox.Text == "The location of purchase"
				|| ItemCostEntryBox.Value == 0 || ItemMaxQuantityEntryBox.Value == 0)
				return;
			else if (ItemNameEntryBox.Text == "" || ItemLocationEntryBox.Text == "" || ItemQuantityEntryBox.Value.ToString() == ""
				|| ItemCostEntryBox.Value.ToString() == "" || ItemMaxQuantityEntryBox.Value.ToString() == "")
				return;

			DataTypes.ListItem item = new DataTypes.ListItem(ItemNameEntryBox.Text, ItemLocationEntryBox.Text,
				(int)ItemQuantityEntryBox.Value, (int)ItemMaxQuantityEntryBox.Value, (float)ItemCostEntryBox.Value);

			currList.AddItem(item);

			SaveListButton.Visible = true;
			DeleteItemButton.Visible = true;
			EditList_ListBox.Items.Clear();
			EditList_ListBox.Items.AddRange(currList.GetNameList().ToArray());
		}
	}
}

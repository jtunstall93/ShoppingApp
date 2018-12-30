using System;
using System.Windows.Forms;
using System.IO;

namespace Shopping_App
{
	public partial class NewList_Window : Form
	{
		DataTypes.ShoppingList newList = new DataTypes.ShoppingList();

		public NewList_Window()
		{
			InitializeComponent();
		}

		private void CreateList_Click(object sender, EventArgs e)
		{
			if (ListNameBox.Text == "Name of the list")
				return;

			newList.SetListName(ListNameBox.Text);

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

			ListBoxLabel.Text = ListNameBox.Text;
			ListBoxLabel.Visible = true;

			NewList_ListBox.Visible = true;

			ItemDetails.Text = "Item details will appear here when clicked.";
			ItemDetails.Visible = true;

			AddItemButton.Visible = true;
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

			newList.AddItem(item);

			SaveListButton.Visible = true;
			DeleteItemButton.Visible = true;
			NewList_ListBox.Items.Clear();
			NewList_ListBox.Items.AddRange(newList.GetNameList().ToArray());
		}

		private void NewList_ListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (newList.GetList().Count == 0 || NewList_ListBox.SelectedIndex == -1)
				return;

			ItemDetails.Text = "Item Price: " + newList.GetList()[NewList_ListBox.SelectedIndex].itemCost + "\n"
				+ "Item Purchase Location: " + newList.GetList()[NewList_ListBox.SelectedIndex].purchaseLocation + "\n"
				+ "Item Quantity: " + newList.GetList()[NewList_ListBox.SelectedIndex].itemQuantity + "\n"
				+ "Max Quantity: " + newList.GetList()[NewList_ListBox.SelectedIndex].itemMaxQuantity + "\n";
		}

		private void DeleteItemButton_Click(object sender, EventArgs e)
		{
			newList.RemoveItem(NewList_ListBox.SelectedIndex);
			NewList_ListBox.Items.RemoveAt(NewList_ListBox.SelectedIndex);
			ItemDetails.Text = "";
		}

		private void SaveListButton_Click(object sender, EventArgs e)
		{
			if (newList.GetList().Count == 0)
				return;

			string specialPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string fileName = newList.GetListName() + ".txt";
			string filePath = specialPath + @"\" + fileName;
			//Order: Name, price, location, quantity, max quantity
			StreamWriter writer = new StreamWriter(filePath);

			writer.WriteLine(newList.GetListName());

			for (int i = 0; i < newList.GetList().Count; i++)
			{
				//writer.WriteLine("#");
				writer.WriteLine(newList.GetList()[i].itemName);
				writer.WriteLine(newList.GetList()[i].itemCost);
				writer.WriteLine(newList.GetList()[i].purchaseLocation);
				writer.WriteLine(newList.GetList()[i].itemQuantity);
				writer.WriteLine(newList.GetList()[i].itemMaxQuantity);
			}

			writer.Close();
		}
	}
}

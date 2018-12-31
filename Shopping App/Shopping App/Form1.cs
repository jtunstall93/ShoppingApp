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
using System.Drawing.Printing;
using Twilio;


namespace Shopping_App
{
	public partial class PrimaryWIndow : Form
	{
		DataTypes.ShoppingList currList = new DataTypes.ShoppingList();
		DataTypes.ShoppingList buyList = new DataTypes.ShoppingList();
		string listPath = "";
		bool printPreview = true;

		public PrimaryWIndow()
		{
			InitializeComponent();
		}

		private void NewList_Click(object sender, EventArgs e)
		{
			Form newListWindow = new NewList_Window();
			newListWindow.Show();
		}

		private void EditListButton_Click(object sender, EventArgs e)
		{
			Form editListWindow = new EditList_Window();
			editListWindow.Show();
		}

		private void LoadList_Click(object sender, EventArgs e)
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
				FullListBox.Items.Clear();
				FullListBox.Items.AddRange(currList.GetNameList().ToArray());
			}
		}

		private void BuyListButton_Click(object sender, EventArgs e)
		{
			DataTypes.ShoppingList list = new DataTypes.ShoppingList();

			for (int i = 0; i < currList.GetList().Count; i++)
			{
				if (currList.GetList()[i].itemQuantity < currList.GetList()[i].itemMaxQuantity)
					list.AddItem(currList.GetList()[i]);
			}

			buyList = list;
			BuyListBox.Items.Clear();
			BuyListBox.Items.AddRange(buyList.GetNameList().ToArray());

			if (buyList.GetList().Count == 0)
				return;

			string specialPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string fileName = "BuyList.txt";
			string filePath = specialPath + @"\" + fileName;
			listPath = filePath;
			//Order: Name, price, location, quantity, max quantity
			StreamWriter writer = new StreamWriter(filePath);
			buyList.GetList().Sort((x, y) => x.purchaseLocation.CompareTo(y.purchaseLocation));

			for (int i = 0; i < buyList.GetList().Count; i++)
			{
				int qty = buyList.GetList()[i].itemMaxQuantity - buyList.GetList()[i].itemQuantity;
				int spaceCount = 20 - buyList.GetList()[i].itemName.Length;

				writer.Write(buyList.GetList()[i].itemName);

				for (int j = 0; j < spaceCount; j++)
					writer.Write(" ");

				spaceCount = 9 - buyList.GetList()[i].itemCost.ToString().Length;

				for (int j = 0; j < spaceCount; j++)
					writer.Write(" ");

				writer.Write(buyList.GetList()[i].itemCost);
				writer.WriteLine(" x" + qty + "      " + buyList.GetList()[i].purchaseLocation);
			}

			writer.WriteLine("");
			writer.WriteLine("Estimated cost pre-tax: " + buyList.Truncate(buyList.GetTotalCost(), 2));

			writer.Close();
		}

		private void FullListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (currList.GetList().Count == 0 || FullListBox.SelectedIndex == -1)
				return;

			FullListItemDetails.Text = "Item Price: " + currList.GetList()[FullListBox.SelectedIndex].itemCost + "\n"
				+ "Item Purchase Location: " + currList.GetList()[FullListBox.SelectedIndex].purchaseLocation + "\n"
				+ "Item Quantity: " + currList.GetList()[FullListBox.SelectedIndex].itemQuantity + "\n"
				+ "Max Quantity: " + currList.GetList()[FullListBox.SelectedIndex].itemMaxQuantity + "\n";
		}

		private void BuyListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (buyList.GetList().Count == 0 || BuyListBox.SelectedIndex == -1)
				return;

			BuyListItemDetails.Text = "Item Price: " + buyList.GetList()[BuyListBox.SelectedIndex].itemCost + "\n"
				+ "Item Purchase Location: " + buyList.GetList()[BuyListBox.SelectedIndex].purchaseLocation + "\n"
				+ "Item Quantity: " + buyList.GetList()[BuyListBox.SelectedIndex].itemQuantity + "\n"
				+ "Max Quantity: " + buyList.GetList()[BuyListBox.SelectedIndex].itemMaxQuantity + "\n";
		}

		private void PrintList_Click(object sender, EventArgs e)
		{
			if (listPath == "")
				return;

			PrintDocument pd = new PrintDocument();
			PrintPreviewDialog ppd = new PrintPreviewDialog();
			pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
			pd.Print();
			#region Print Preview Options
			//string docName = "BuyList.txt";
			//string documentContents = "";
			//string stringToPrint = "";
			//
			//pd.DocumentName = docName;
			//using (FileStream stream = new FileStream(listPath, FileMode.Open))
			//using (StreamReader reader = new StreamReader(stream))
			//{
			//	documentContents = reader.ReadToEnd();
			//}
			//stringToPrint = documentContents;
			//
			//ppd.Document = pd;
			//ppd.ShowDialog();
			#endregion
		}

		private void TextListButton_Click(object sender, EventArgs e)
		{
			Form textListWindow = new TextMessage_Window();
			textListWindow.Show();
		}

		private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
		{

			StreamReader reader = new StreamReader(listPath);
			//Proper formatting requires a monospaced font like the one being used
			Font font = new Font("Courier New", 16.0f);
			StringFormat drawFormat = new StringFormat();

			//Get the Graphics object  
			Graphics g = ppeArgs.Graphics;
			float linesPerPage = 0;
			float yPos = 0;
			int count = 0;
			//Read margins from PrintPageEventArgs  
			float leftMargin = ppeArgs.MarginBounds.Left;
			float topMargin = ppeArgs.MarginBounds.Top;
			string line = null;
			//Calculate the lines per page on the basis of the height of the page and the height of the font  
			linesPerPage = ppeArgs.MarginBounds.Height / font.GetHeight(g);
			//Now read lines one by one, using StreamReader  
			while (count < linesPerPage && ((line = reader.ReadLine()) != null))
			{
				//Calculate the starting position  
				yPos = topMargin + (count * font.GetHeight(g));
				//Draw text  
				g.DrawString(line, font, Brushes.Black, leftMargin, yPos, drawFormat);
				//Move to next line  
				count++;
			}
			//If PrintPageEventArgs has more pages to print  
			if (line != null)
				ppeArgs.HasMorePages = true;
			else
				ppeArgs.HasMorePages = false;

			reader.Close();
		}
	}
}

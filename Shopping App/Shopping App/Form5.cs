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
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Shopping_App
{
	public partial class LoadType_Window : Form
	{
		PrimaryWIndow parent;

		public LoadType_Window(PrimaryWIndow prnt)
		{
			InitializeComponent();
			parent = prnt;
		}

		private void LoadTextButton_Click(object sender, EventArgs e)
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

				parent.currList = list;
				parent.FullListBox.Items.Clear();
				parent.FullListBox.Items.AddRange(parent.currList.GetNameList().ToArray());
			}
		}

		private void LoadXL_Button_Click(object sender, EventArgs e)
		{
			OpenFileDialog log = new OpenFileDialog();
			string filePath = "";

			if (log.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				filePath = log.FileName;

				//Order: Name, price, location, quantity, max quantity
				//StreamReader reader = new StreamReader(filePath);
				DataTypes.ShoppingList list = new DataTypes.ShoppingList();

				//Excel stuff
				Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
				Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
				_Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Range xlRange = xlWorksheet.UsedRange;

				list.SetListName("Loaded Excel List");
				int rowCount = xlRange.Rows.Count;

				for (int i = 1; i <= rowCount; i++)
				{
					DataTypes.ListItem item;
					string name = "";
					string location = "";
					double price = 0;
					int quantity = 0;
					int maxQuantity = 0;

					if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
						name = Convert.ToString(xlRange.Cells[i, 1].Value2);

					if (xlRange.Cells[i, 2] != null && xlRange.Cells[i, 2].Value2 != null)
						price = Convert.ToDouble(xlRange.Cells[i, 2].Value2);

					if (xlRange.Cells[i, 3] != null && xlRange.Cells[i, 3].Value2 != null)
						location = Convert.ToString(xlRange.Cells[i, 3].Value2);

					if (xlRange.Cells[i, 4] != null && xlRange.Cells[i, 4].Value2 != null)
						quantity = Convert.ToInt32(xlRange.Cells[i, 4].Value2);

					if (xlRange.Cells[i, 5] != null && xlRange.Cells[i, 5].Value2 != null)
						maxQuantity = Convert.ToInt32(xlRange.Cells[i, 5].Value2);

					item = new DataTypes.ListItem(name, location, quantity, maxQuantity, (float)price);
					list.AddItem(item);
				}

				//reader.Close();

				parent.currList = list;
				parent.FullListBox.Items.Clear();
				parent.FullListBox.Items.AddRange(parent.currList.GetNameList().ToArray());
			}
		}
	}
}

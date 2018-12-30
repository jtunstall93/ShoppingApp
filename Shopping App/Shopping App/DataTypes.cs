using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shopping_App
{
	class DataTypes
	{
		public enum ItemInfo
		{
			iName,
			iLocation,
			iQuantity,
			iMaxQuantity,
			iCost
		};

		public class ListItem
		{
			public string itemName = "";
			public string purchaseLocation = "";

			public int itemQuantity = 0;
			public int itemMaxQuantity = 0;

			public float itemCost = 0;

			public ListItem(string itemName, string purchaseLocation, int itemQuantity, int itemMaxQuantity, float itemCost)
			{
				this.itemName = itemName;
				this.purchaseLocation = purchaseLocation;
				this.itemQuantity = itemQuantity;
				this.itemMaxQuantity = itemMaxQuantity;
				this.itemCost = itemCost;
			}
		}

		public class Contact
		{
			private string contactName = "";
			private string contactNumber = "";

			public void SetContactName(string n) { contactName = n; }
			public string GetContactName() { return contactName; }

			public void SetContactNumber(string n) { contactNumber = n; }
			public string GetContactNumber() { return contactNumber; }
		}

		public class ContactList
		{
			private List<Contact> list = new List<Contact>();
			private List<string> nameList = new List<string>();

			int numContacts = 0;

			public void AddContact(string name, string number)
			{
				Contact n = new Contact();
				nameList.Add(name);
				n.SetContactName(name);
				n.SetContactNumber(number);
				list.Add(n);
				numContacts++;
			}

			public void RemoveContact(int i)
			{
				list.RemoveAt(i);
				nameList.RemoveAt(i);
				numContacts--;

				if (numContacts < 0)
					numContacts = 0;
			}

			public void EditContact(string name, string number, int i)
			{
				list[i].SetContactName(name);
				list[i].SetContactNumber(number);
				nameList[i] = name;
			}

			public int GetNumContacts() { return numContacts; }
			public List<string> GetNameList() { return nameList; }
			public List<Contact> GetContacts() { return list; }
		}

		public class ShoppingList
		{
			private readonly List<ListItem> list = new List<ListItem>();
			private List<string> nameList = new List<string>();

			private string listName = "";
			private float totalCost = 0;
			private float maxTotalCost = 0;

			public List<ListItem> GetList() { return list; }

			public float Truncate(float value, int digits)
			{
				double mult = Math.Pow(10.0, digits);
				double result = Math.Truncate(mult * value) / mult;
				return (float)result;
			}

			public void AddItem(ListItem item)
			{
				list.Add(item);
				nameList.Add(item.itemName);
			}

			public void RemoveItem(int i)
			{
				list.RemoveAt(i);
				nameList.Remove(nameList[i]);
			}

			public void SetListName(string n) { listName = n; }
			public string GetListName() { return listName; }

			public List<string> GetNameList() { return nameList; }

			public float GetTotalCost()
			{
				float cost = 0;

				for (int i = 0; i < list.Count; i++)
				{
					int loopVal = list[i].itemMaxQuantity - list[i].itemQuantity;

					for (int j = 0; j < loopVal; j++)
					{
						cost += list[i].itemCost;
					}
				}

				totalCost = cost;

				return Truncate(totalCost, 2);
			}

			public float GetMaxTotalCost()
			{
				float cost = 0;

				for (int i = 0; i < list.Count; i++)
				{
					for (int j = 0; j < list[i].itemMaxQuantity; j++)
					{
						cost += list[i].itemCost;
					}
				}

				maxTotalCost = cost;

				return Truncate(maxTotalCost, 2);
			}

			/// <summary>
			/// Edits an item in the list at index i based on the infotype passed in. 
			/// </summary>
			/// <param name="i">The index in the list to modify.</param>
			/// <param name="infoType">The type of item information passed in.</param>
			/// <param name="sParam">For passing string parameters.</param>
			/// <param name="iParam">For passing integer parameters.</param>
			public void EditItem(int i, ItemInfo infoType, string sParam, float iParam)
			{
				if (list.Capacity >= i)
				{
					switch (infoType)
					{
						case ItemInfo.iName:
							list[i].itemName = sParam;
							break;

						case ItemInfo.iLocation:
							list[i].purchaseLocation = sParam;
							break;

						case ItemInfo.iQuantity:
							list[i].itemQuantity = (int)iParam;
							break;

						case ItemInfo.iMaxQuantity:
							list[i].itemMaxQuantity = (int)iParam;
							break;

						case ItemInfo.iCost:
							list[i].itemCost = iParam;
							break;

						default:
							break;
					}
				}
			}
		}
	}
}

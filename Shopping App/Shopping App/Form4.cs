using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Twilio;
//using Twilio.Rest.Api.V2010.Account;

namespace Shopping_App
{
	public partial class TextMessage_Window : Form
	{
		DataTypes.ContactList cList = new DataTypes.ContactList();
		bool editContact = false;
		//string twilioSID = "(Twilio-generated SID)";
		//string twilioAuthToken = "(Twilio-generated Auth token)";

		public TextMessage_Window()
		{
			InitializeComponent();
		}

		private void AddContactButton_Click(object sender, EventArgs e)
		{
			ContactNameEntryBox.Text = "The name of the contact";
			ContactNumberEntryBox.Text = "The number of the contact";

			#region Visibility toggles
			ContactNameLabel.Visible = true;
			ContactNameEntryBox.Visible = true;
			ContactNumberLabel.Visible = true;
			ContactNumberEntryBox.Visible = true;

			SaveContactButton.Visible = true;
			TextListConfirmButton.Visible = false;
			#endregion
		}

		private void SaveContactButton_Click(object sender, EventArgs e)
		{
			if (ContactNameEntryBox.Text == "The name of the contact" || ContactNumberEntryBox.Text == "The number of the contact" || (ContactListBox.SelectedIndex < 0 && editContact))
				return;

			if (!editContact)
				cList.AddContact(ContactNameEntryBox.Text, ContactNumberEntryBox.Text);
			else
			{
				cList.EditContact(ContactNameEntryBox.Text, ContactNumberEntryBox.Text, ContactListBox.SelectedIndex);
				editContact = false;
			}

			ContactListBox.Items.Clear();
			ContactListBox.Items.AddRange(cList.GetNameList().ToArray());
			ContactNameEntryBox.Text = "The name of the contact";
			ContactNumberEntryBox.Text = "The number of the contact";
			ContactListBox.Text = cList.GetNameList()[0];

			#region Visibility toggles
			ContactNameLabel.Visible = false;
			ContactNameEntryBox.Visible = false;
			ContactNumberLabel.Visible = false;
			ContactNumberEntryBox.Visible = false;

			SaveContactButton.Visible = false;
			DeleteContactButton.Visible = false;
			ContactListBox.Visible = false;
			#endregion
		}

		private void EditContactsButton_Click(object sender, EventArgs e)
		{
			if (cList.GetNumContacts() <= 0)
				return;

			editContact = true;

			#region Visibility toggles
			ContactNameLabel.Visible = true;
			ContactNameEntryBox.Visible = true;
			ContactNumberLabel.Visible = true;
			ContactNumberEntryBox.Visible = true;

			SaveContactButton.Visible = true;
			DeleteContactButton.Visible = true;
			ContactListBox.Visible = true;
			TextListConfirmButton.Visible = false;
			#endregion
		}

		private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ContactNameEntryBox.Text = cList.GetContacts()[ContactListBox.SelectedIndex].GetContactName();
			ContactNumberEntryBox.Text = cList.GetContacts()[ContactListBox.SelectedIndex].GetContactNumber();
		}

		private void DeleteContactButton_Click(object sender, EventArgs e)
		{
			cList.RemoveContact(ContactListBox.SelectedIndex);
			ContactListBox.Items.Clear();
			ContactListBox.Items.AddRange(cList.GetNameList().ToArray());
			ContactNameEntryBox.Text = "The name of the contact";
			ContactNumberEntryBox.Text = "The number of the contact";
			ContactListBox.Text = cList.GetNameList()[0];

			#region Visibility toggles
			ContactNameLabel.Visible = false;
			ContactNameEntryBox.Visible = false;
			ContactNumberLabel.Visible = false;
			ContactNumberEntryBox.Visible = false;

			SaveContactButton.Visible = false;
			DeleteContactButton.Visible = false;
			ContactListBox.Visible = false;
			#endregion
		}

		private void TextListButton_Click(object sender, EventArgs e)
		{
			#region Visibility toggles
			ContactNameLabel.Visible = true;
			ContactNameEntryBox.Visible = true;
			ContactNumberLabel.Visible = true;
			ContactNumberEntryBox.Visible = true;

			TextListConfirmButton.Visible = true;
			ContactListBox.Visible = true;
			#endregion
		}

		private void TextListConfirmButton_Click(object sender, EventArgs e)
		{
			//TwilioClient.Init(twilioSID, twilioAuthToken);
			
			//MessageResource message = MessageResource.Create(
			//	body: "This is a test.",									// The message you want to send
			//	from: new Twilio.Types.PhoneNumber("+1(Twilio number)"),			// This needs to be your Twilio user-generated phone number.
			//	to: new Twilio.Types.PhoneNumber("+" + cList.GetContacts()[ContactListBox.SelectedIndex].GetContactNumber())
			//	);

			// THIS WORKS. Just requires payment. So this portion was abandoned.
		}
	}
}

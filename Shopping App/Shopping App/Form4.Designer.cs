namespace Shopping_App
{
	partial class TextMessage_Window
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextMessage_Window));
			this.EditContactsButton = new System.Windows.Forms.Button();
			this.AddContactButton = new System.Windows.Forms.Button();
			this.TextListButton = new System.Windows.Forms.Button();
			this.ContactNameLabel = new System.Windows.Forms.Label();
			this.ContactNumberLabel = new System.Windows.Forms.Label();
			this.ContactNameEntryBox = new System.Windows.Forms.RichTextBox();
			this.ContactNumberEntryBox = new System.Windows.Forms.RichTextBox();
			this.SaveContactButton = new System.Windows.Forms.Button();
			this.DeleteContactButton = new System.Windows.Forms.Button();
			this.ContactListBox = new System.Windows.Forms.ComboBox();
			this.TextListConfirmButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EditContactsButton
			// 
			this.EditContactsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditContactsButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.EditContactsButton.Location = new System.Drawing.Point(12, 57);
			this.EditContactsButton.Name = "EditContactsButton";
			this.EditContactsButton.Size = new System.Drawing.Size(100, 35);
			this.EditContactsButton.TabIndex = 33;
			this.EditContactsButton.Text = "Edit Contact";
			this.EditContactsButton.UseVisualStyleBackColor = true;
			this.EditContactsButton.Click += new System.EventHandler(this.EditContactsButton_Click);
			// 
			// AddContactButton
			// 
			this.AddContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddContactButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.AddContactButton.Location = new System.Drawing.Point(12, 16);
			this.AddContactButton.Name = "AddContactButton";
			this.AddContactButton.Size = new System.Drawing.Size(100, 35);
			this.AddContactButton.TabIndex = 34;
			this.AddContactButton.Text = "Add Contact";
			this.AddContactButton.UseVisualStyleBackColor = true;
			this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
			// 
			// TextListButton
			// 
			this.TextListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextListButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.TextListButton.Location = new System.Drawing.Point(12, 98);
			this.TextListButton.Name = "TextListButton";
			this.TextListButton.Size = new System.Drawing.Size(100, 35);
			this.TextListButton.TabIndex = 35;
			this.TextListButton.Text = "Text List";
			this.TextListButton.UseVisualStyleBackColor = true;
			this.TextListButton.Click += new System.EventHandler(this.TextListButton_Click);
			// 
			// ContactNameLabel
			// 
			this.ContactNameLabel.AutoSize = true;
			this.ContactNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ContactNameLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ContactNameLabel.Location = new System.Drawing.Point(139, 66);
			this.ContactNameLabel.Name = "ContactNameLabel";
			this.ContactNameLabel.Size = new System.Drawing.Size(104, 18);
			this.ContactNameLabel.TabIndex = 36;
			this.ContactNameLabel.Text = "Contact Name";
			this.ContactNameLabel.Visible = false;
			// 
			// ContactNumberLabel
			// 
			this.ContactNumberLabel.AutoSize = true;
			this.ContactNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ContactNumberLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ContactNumberLabel.Location = new System.Drawing.Point(139, 107);
			this.ContactNumberLabel.Name = "ContactNumberLabel";
			this.ContactNumberLabel.Size = new System.Drawing.Size(117, 18);
			this.ContactNumberLabel.TabIndex = 37;
			this.ContactNumberLabel.Text = "Contact Number";
			this.ContactNumberLabel.Visible = false;
			// 
			// ContactNameEntryBox
			// 
			this.ContactNameEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ContactNameEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ContactNameEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ContactNameEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ContactNameEntryBox.Location = new System.Drawing.Point(274, 66);
			this.ContactNameEntryBox.Name = "ContactNameEntryBox";
			this.ContactNameEntryBox.Size = new System.Drawing.Size(188, 20);
			this.ContactNameEntryBox.TabIndex = 38;
			this.ContactNameEntryBox.Text = "The name of contact";
			this.ContactNameEntryBox.Visible = false;
			// 
			// ContactNumberEntryBox
			// 
			this.ContactNumberEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ContactNumberEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ContactNumberEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ContactNumberEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ContactNumberEntryBox.Location = new System.Drawing.Point(274, 107);
			this.ContactNumberEntryBox.Name = "ContactNumberEntryBox";
			this.ContactNumberEntryBox.Size = new System.Drawing.Size(188, 20);
			this.ContactNumberEntryBox.TabIndex = 39;
			this.ContactNumberEntryBox.Text = "The number of the contact";
			this.ContactNumberEntryBox.Visible = false;
			// 
			// SaveContactButton
			// 
			this.SaveContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveContactButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.SaveContactButton.Location = new System.Drawing.Point(142, 143);
			this.SaveContactButton.Name = "SaveContactButton";
			this.SaveContactButton.Size = new System.Drawing.Size(100, 31);
			this.SaveContactButton.TabIndex = 40;
			this.SaveContactButton.Text = "Save Contact";
			this.SaveContactButton.UseVisualStyleBackColor = true;
			this.SaveContactButton.Visible = false;
			this.SaveContactButton.Click += new System.EventHandler(this.SaveContactButton_Click);
			// 
			// DeleteContactButton
			// 
			this.DeleteContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteContactButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.DeleteContactButton.Location = new System.Drawing.Point(362, 143);
			this.DeleteContactButton.Name = "DeleteContactButton";
			this.DeleteContactButton.Size = new System.Drawing.Size(100, 31);
			this.DeleteContactButton.TabIndex = 41;
			this.DeleteContactButton.Text = "Delete";
			this.DeleteContactButton.UseVisualStyleBackColor = true;
			this.DeleteContactButton.Visible = false;
			this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
			// 
			// ContactListBox
			// 
			this.ContactListBox.FormattingEnabled = true;
			this.ContactListBox.Location = new System.Drawing.Point(193, 24);
			this.ContactListBox.Name = "ContactListBox";
			this.ContactListBox.Size = new System.Drawing.Size(224, 21);
			this.ContactListBox.TabIndex = 42;
			this.ContactListBox.Visible = false;
			this.ContactListBox.SelectedIndexChanged += new System.EventHandler(this.ContactListBox_SelectedIndexChanged);
			// 
			// TextListConfirmButton
			// 
			this.TextListConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextListConfirmButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.TextListConfirmButton.Location = new System.Drawing.Point(252, 143);
			this.TextListConfirmButton.Name = "TextListConfirmButton";
			this.TextListConfirmButton.Size = new System.Drawing.Size(100, 31);
			this.TextListConfirmButton.TabIndex = 43;
			this.TextListConfirmButton.Text = "Send List";
			this.TextListConfirmButton.UseVisualStyleBackColor = true;
			this.TextListConfirmButton.Visible = false;
			this.TextListConfirmButton.Click += new System.EventHandler(this.TextListConfirmButton_Click);
			// 
			// TextMessage_Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(484, 401);
			this.Controls.Add(this.TextListConfirmButton);
			this.Controls.Add(this.ContactListBox);
			this.Controls.Add(this.DeleteContactButton);
			this.Controls.Add(this.SaveContactButton);
			this.Controls.Add(this.ContactNumberEntryBox);
			this.Controls.Add(this.ContactNameEntryBox);
			this.Controls.Add(this.ContactNumberLabel);
			this.Controls.Add(this.ContactNameLabel);
			this.Controls.Add(this.TextListButton);
			this.Controls.Add(this.AddContactButton);
			this.Controls.Add(this.EditContactsButton);
			this.ForeColor = System.Drawing.SystemColors.Menu;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TextMessage_Window";
			this.Text = "Text List Options";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button EditContactsButton;
		private System.Windows.Forms.Button AddContactButton;
		private System.Windows.Forms.Button TextListButton;
		private System.Windows.Forms.Label ContactNameLabel;
		private System.Windows.Forms.Label ContactNumberLabel;
		private System.Windows.Forms.RichTextBox ContactNameEntryBox;
		private System.Windows.Forms.RichTextBox ContactNumberEntryBox;
		private System.Windows.Forms.Button SaveContactButton;
		private System.Windows.Forms.Button DeleteContactButton;
		private System.Windows.Forms.ComboBox ContactListBox;
		private System.Windows.Forms.Button TextListConfirmButton;
	}
}
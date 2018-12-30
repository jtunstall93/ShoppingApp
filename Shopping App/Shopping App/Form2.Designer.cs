namespace Shopping_App
{
	partial class NewList_Window
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewList_Window));
			this.label1 = new System.Windows.Forms.Label();
			this.NewList_ListBox = new System.Windows.Forms.ListBox();
			this.ListBoxLabel = new System.Windows.Forms.Label();
			this.CreateList = new System.Windows.Forms.Button();
			this.ItemDetails = new System.Windows.Forms.RichTextBox();
			this.ListNameBox = new System.Windows.Forms.RichTextBox();
			this.ItemNameEntryBox = new System.Windows.Forms.RichTextBox();
			this.ItemNameLabel = new System.Windows.Forms.Label();
			this.ItemLocationLabel = new System.Windows.Forms.Label();
			this.ItemLocationEntryBox = new System.Windows.Forms.RichTextBox();
			this.ItemCostLabel = new System.Windows.Forms.Label();
			this.ItemQuantityLabel = new System.Windows.Forms.Label();
			this.ItemMaxQuantityLabel = new System.Windows.Forms.Label();
			this.AddItemButton = new System.Windows.Forms.Button();
			this.DeleteItemButton = new System.Windows.Forms.Button();
			this.SaveListButton = new System.Windows.Forms.Button();
			this.ItemCostEntryBox = new System.Windows.Forms.NumericUpDown();
			this.ItemQuantityEntryBox = new System.Windows.Forms.NumericUpDown();
			this.ItemMaxQuantityEntryBox = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.ItemCostEntryBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemQuantityEntryBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemMaxQuantityEntryBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Menu;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "List Name";
			// 
			// NewList_ListBox
			// 
			this.NewList_ListBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.NewList_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NewList_ListBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.NewList_ListBox.FormattingEnabled = true;
			this.NewList_ListBox.Location = new System.Drawing.Point(250, 28);
			this.NewList_ListBox.Name = "NewList_ListBox";
			this.NewList_ListBox.Size = new System.Drawing.Size(224, 208);
			this.NewList_ListBox.TabIndex = 2;
			this.NewList_ListBox.Visible = false;
			this.NewList_ListBox.SelectedIndexChanged += new System.EventHandler(this.NewList_ListBox_SelectedIndexChanged);
			// 
			// ListBoxLabel
			// 
			this.ListBoxLabel.AutoSize = true;
			this.ListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListBoxLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ListBoxLabel.Location = new System.Drawing.Point(337, 5);
			this.ListBoxLabel.Name = "ListBoxLabel";
			this.ListBoxLabel.Size = new System.Drawing.Size(46, 18);
			this.ListBoxLabel.TabIndex = 3;
			this.ListBoxLabel.Text = "label2";
			this.ListBoxLabel.Visible = false;
			// 
			// CreateList
			// 
			this.CreateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateList.Location = new System.Drawing.Point(21, 38);
			this.CreateList.Name = "CreateList";
			this.CreateList.Size = new System.Drawing.Size(100, 35);
			this.CreateList.TabIndex = 3;
			this.CreateList.Text = "Create List";
			this.CreateList.UseVisualStyleBackColor = true;
			this.CreateList.Click += new System.EventHandler(this.CreateList_Click);
			// 
			// ItemDetails
			// 
			this.ItemDetails.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemDetails.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemDetails.Location = new System.Drawing.Point(250, 242);
			this.ItemDetails.Name = "ItemDetails";
			this.ItemDetails.Size = new System.Drawing.Size(224, 144);
			this.ItemDetails.TabIndex = 5;
			this.ItemDetails.Text = "";
			this.ItemDetails.Visible = false;
			// 
			// ListNameBox
			// 
			this.ListNameBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ListNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ListNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListNameBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ListNameBox.Location = new System.Drawing.Point(93, 7);
			this.ListNameBox.Name = "ListNameBox";
			this.ListNameBox.Size = new System.Drawing.Size(151, 25);
			this.ListNameBox.TabIndex = 2;
			this.ListNameBox.Text = "Name of the list";
			// 
			// ItemNameEntryBox
			// 
			this.ItemNameEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemNameEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemNameEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemNameEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemNameEntryBox.Location = new System.Drawing.Point(31, 100);
			this.ItemNameEntryBox.Name = "ItemNameEntryBox";
			this.ItemNameEntryBox.Size = new System.Drawing.Size(188, 20);
			this.ItemNameEntryBox.TabIndex = 5;
			this.ItemNameEntryBox.Text = "The name of the item";
			this.ItemNameEntryBox.Visible = false;
			// 
			// ItemNameLabel
			// 
			this.ItemNameLabel.AutoSize = true;
			this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemNameLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemNameLabel.Location = new System.Drawing.Point(79, 79);
			this.ItemNameLabel.Name = "ItemNameLabel";
			this.ItemNameLabel.Size = new System.Drawing.Size(80, 18);
			this.ItemNameLabel.TabIndex = 8;
			this.ItemNameLabel.Text = "Item Name";
			this.ItemNameLabel.Visible = false;
			// 
			// ItemLocationLabel
			// 
			this.ItemLocationLabel.AutoSize = true;
			this.ItemLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemLocationLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemLocationLabel.Location = new System.Drawing.Point(70, 129);
			this.ItemLocationLabel.Name = "ItemLocationLabel";
			this.ItemLocationLabel.Size = new System.Drawing.Size(97, 18);
			this.ItemLocationLabel.TabIndex = 10;
			this.ItemLocationLabel.Text = "Item Location";
			this.ItemLocationLabel.Visible = false;
			// 
			// ItemLocationEntryBox
			// 
			this.ItemLocationEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemLocationEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemLocationEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemLocationEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemLocationEntryBox.Location = new System.Drawing.Point(31, 150);
			this.ItemLocationEntryBox.Name = "ItemLocationEntryBox";
			this.ItemLocationEntryBox.Size = new System.Drawing.Size(188, 20);
			this.ItemLocationEntryBox.TabIndex = 6;
			this.ItemLocationEntryBox.Text = "The location of purchase";
			this.ItemLocationEntryBox.Visible = false;
			// 
			// ItemCostLabel
			// 
			this.ItemCostLabel.AutoSize = true;
			this.ItemCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemCostLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemCostLabel.Location = new System.Drawing.Point(83, 181);
			this.ItemCostLabel.Name = "ItemCostLabel";
			this.ItemCostLabel.Size = new System.Drawing.Size(72, 18);
			this.ItemCostLabel.TabIndex = 12;
			this.ItemCostLabel.Text = "Item Cost";
			this.ItemCostLabel.Visible = false;
			// 
			// ItemQuantityLabel
			// 
			this.ItemQuantityLabel.AutoSize = true;
			this.ItemQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemQuantityLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemQuantityLabel.Location = new System.Drawing.Point(74, 233);
			this.ItemQuantityLabel.Name = "ItemQuantityLabel";
			this.ItemQuantityLabel.Size = new System.Drawing.Size(94, 18);
			this.ItemQuantityLabel.TabIndex = 14;
			this.ItemQuantityLabel.Text = "Item Quantity";
			this.ItemQuantityLabel.Visible = false;
			// 
			// ItemMaxQuantityLabel
			// 
			this.ItemMaxQuantityLabel.AutoSize = true;
			this.ItemMaxQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemMaxQuantityLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemMaxQuantityLabel.Location = new System.Drawing.Point(60, 286);
			this.ItemMaxQuantityLabel.Name = "ItemMaxQuantityLabel";
			this.ItemMaxQuantityLabel.Size = new System.Drawing.Size(126, 18);
			this.ItemMaxQuantityLabel.TabIndex = 16;
			this.ItemMaxQuantityLabel.Text = "Item Max Quantity";
			this.ItemMaxQuantityLabel.Visible = false;
			// 
			// AddItemButton
			// 
			this.AddItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddItemButton.Location = new System.Drawing.Point(21, 342);
			this.AddItemButton.Name = "AddItemButton";
			this.AddItemButton.Size = new System.Drawing.Size(100, 35);
			this.AddItemButton.TabIndex = 10;
			this.AddItemButton.Text = "Add Item";
			this.AddItemButton.UseVisualStyleBackColor = true;
			this.AddItemButton.Visible = false;
			this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
			// 
			// DeleteItemButton
			// 
			this.DeleteItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteItemButton.Location = new System.Drawing.Point(127, 342);
			this.DeleteItemButton.Name = "DeleteItemButton";
			this.DeleteItemButton.Size = new System.Drawing.Size(100, 35);
			this.DeleteItemButton.TabIndex = 11;
			this.DeleteItemButton.Text = "Delete Item";
			this.DeleteItemButton.UseVisualStyleBackColor = true;
			this.DeleteItemButton.Visible = false;
			this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
			// 
			// SaveListButton
			// 
			this.SaveListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveListButton.Location = new System.Drawing.Point(127, 38);
			this.SaveListButton.Name = "SaveListButton";
			this.SaveListButton.Size = new System.Drawing.Size(100, 35);
			this.SaveListButton.TabIndex = 4;
			this.SaveListButton.Text = "Save List";
			this.SaveListButton.UseVisualStyleBackColor = true;
			this.SaveListButton.Visible = false;
			this.SaveListButton.Click += new System.EventHandler(this.SaveListButton_Click);
			// 
			// ItemCostEntryBox
			// 
			this.ItemCostEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemCostEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemCostEntryBox.DecimalPlaces = 2;
			this.ItemCostEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemCostEntryBox.Location = new System.Drawing.Point(31, 202);
			this.ItemCostEntryBox.Name = "ItemCostEntryBox";
			this.ItemCostEntryBox.Size = new System.Drawing.Size(188, 16);
			this.ItemCostEntryBox.TabIndex = 7;
			this.ItemCostEntryBox.ThousandsSeparator = true;
			this.ItemCostEntryBox.Visible = false;
			// 
			// ItemQuantityEntryBox
			// 
			this.ItemQuantityEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemQuantityEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemQuantityEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemQuantityEntryBox.Location = new System.Drawing.Point(31, 254);
			this.ItemQuantityEntryBox.Name = "ItemQuantityEntryBox";
			this.ItemQuantityEntryBox.Size = new System.Drawing.Size(188, 16);
			this.ItemQuantityEntryBox.TabIndex = 8;
			this.ItemQuantityEntryBox.Visible = false;
			// 
			// ItemMaxQuantityEntryBox
			// 
			this.ItemMaxQuantityEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemMaxQuantityEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemMaxQuantityEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemMaxQuantityEntryBox.Location = new System.Drawing.Point(31, 307);
			this.ItemMaxQuantityEntryBox.Name = "ItemMaxQuantityEntryBox";
			this.ItemMaxQuantityEntryBox.Size = new System.Drawing.Size(188, 16);
			this.ItemMaxQuantityEntryBox.TabIndex = 9;
			this.ItemMaxQuantityEntryBox.Visible = false;
			// 
			// NewList_Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(484, 401);
			this.Controls.Add(this.ItemMaxQuantityEntryBox);
			this.Controls.Add(this.ItemQuantityEntryBox);
			this.Controls.Add(this.ItemCostEntryBox);
			this.Controls.Add(this.SaveListButton);
			this.Controls.Add(this.DeleteItemButton);
			this.Controls.Add(this.AddItemButton);
			this.Controls.Add(this.ItemMaxQuantityLabel);
			this.Controls.Add(this.ItemQuantityLabel);
			this.Controls.Add(this.ItemCostLabel);
			this.Controls.Add(this.ItemLocationLabel);
			this.Controls.Add(this.ItemLocationEntryBox);
			this.Controls.Add(this.ItemNameLabel);
			this.Controls.Add(this.ItemNameEntryBox);
			this.Controls.Add(this.ListNameBox);
			this.Controls.Add(this.ItemDetails);
			this.Controls.Add(this.CreateList);
			this.Controls.Add(this.ListBoxLabel);
			this.Controls.Add(this.NewList_ListBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NewList_Window";
			this.Text = "New List";
			((System.ComponentModel.ISupportInitialize)(this.ItemCostEntryBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemQuantityEntryBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemMaxQuantityEntryBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox NewList_ListBox;
		private System.Windows.Forms.Label ListBoxLabel;
		private System.Windows.Forms.Button CreateList;
		private System.Windows.Forms.RichTextBox ItemDetails;
		private System.Windows.Forms.RichTextBox ListNameBox;
		private System.Windows.Forms.RichTextBox ItemNameEntryBox;
		private System.Windows.Forms.Label ItemNameLabel;
		private System.Windows.Forms.Label ItemLocationLabel;
		private System.Windows.Forms.RichTextBox ItemLocationEntryBox;
		private System.Windows.Forms.Label ItemCostLabel;
		private System.Windows.Forms.Label ItemQuantityLabel;
		private System.Windows.Forms.Label ItemMaxQuantityLabel;
		private System.Windows.Forms.Button AddItemButton;
		private System.Windows.Forms.Button DeleteItemButton;
		private System.Windows.Forms.Button SaveListButton;
		private System.Windows.Forms.NumericUpDown ItemCostEntryBox;
		private System.Windows.Forms.NumericUpDown ItemQuantityEntryBox;
		private System.Windows.Forms.NumericUpDown ItemMaxQuantityEntryBox;
	}
}
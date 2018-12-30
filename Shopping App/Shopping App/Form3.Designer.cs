namespace Shopping_App
{
	partial class EditList_Window
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditList_Window));
			this.ListNameBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ItemMaxQuantityEntryBox = new System.Windows.Forms.NumericUpDown();
			this.ItemQuantityEntryBox = new System.Windows.Forms.NumericUpDown();
			this.ItemCostEntryBox = new System.Windows.Forms.NumericUpDown();
			this.ItemMaxQuantityLabel = new System.Windows.Forms.Label();
			this.ItemQuantityLabel = new System.Windows.Forms.Label();
			this.ItemCostLabel = new System.Windows.Forms.Label();
			this.ItemLocationLabel = new System.Windows.Forms.Label();
			this.ItemLocationEntryBox = new System.Windows.Forms.RichTextBox();
			this.ItemNameLabel = new System.Windows.Forms.Label();
			this.ItemNameEntryBox = new System.Windows.Forms.RichTextBox();
			this.ListBoxLabel = new System.Windows.Forms.Label();
			this.EditList_ListBox = new System.Windows.Forms.ListBox();
			this.SaveItemButton = new System.Windows.Forms.Button();
			this.DeleteItemButton = new System.Windows.Forms.Button();
			this.LoadListButton = new System.Windows.Forms.Button();
			this.SaveListButton = new System.Windows.Forms.Button();
			this.AddItemButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ItemMaxQuantityEntryBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemQuantityEntryBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemCostEntryBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ListNameBox
			// 
			this.ListNameBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ListNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ListNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListNameBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ListNameBox.Location = new System.Drawing.Point(80, 8);
			this.ListNameBox.Name = "ListNameBox";
			this.ListNameBox.Size = new System.Drawing.Size(151, 25);
			this.ListNameBox.TabIndex = 4;
			this.ListNameBox.Text = "Name of the list";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Menu;
			this.label1.Location = new System.Drawing.Point(4, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "List Name";
			// 
			// ItemMaxQuantityEntryBox
			// 
			this.ItemMaxQuantityEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemMaxQuantityEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemMaxQuantityEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemMaxQuantityEntryBox.Location = new System.Drawing.Point(24, 320);
			this.ItemMaxQuantityEntryBox.Name = "ItemMaxQuantityEntryBox";
			this.ItemMaxQuantityEntryBox.Size = new System.Drawing.Size(188, 16);
			this.ItemMaxQuantityEntryBox.TabIndex = 22;
			this.ItemMaxQuantityEntryBox.Visible = false;
			// 
			// ItemQuantityEntryBox
			// 
			this.ItemQuantityEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemQuantityEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemQuantityEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemQuantityEntryBox.Location = new System.Drawing.Point(24, 267);
			this.ItemQuantityEntryBox.Name = "ItemQuantityEntryBox";
			this.ItemQuantityEntryBox.Size = new System.Drawing.Size(188, 16);
			this.ItemQuantityEntryBox.TabIndex = 20;
			this.ItemQuantityEntryBox.Visible = false;
			// 
			// ItemCostEntryBox
			// 
			this.ItemCostEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemCostEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemCostEntryBox.DecimalPlaces = 2;
			this.ItemCostEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemCostEntryBox.Location = new System.Drawing.Point(24, 215);
			this.ItemCostEntryBox.Name = "ItemCostEntryBox";
			this.ItemCostEntryBox.Size = new System.Drawing.Size(188, 16);
			this.ItemCostEntryBox.TabIndex = 19;
			this.ItemCostEntryBox.ThousandsSeparator = true;
			this.ItemCostEntryBox.Visible = false;
			// 
			// ItemMaxQuantityLabel
			// 
			this.ItemMaxQuantityLabel.AutoSize = true;
			this.ItemMaxQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemMaxQuantityLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemMaxQuantityLabel.Location = new System.Drawing.Point(53, 299);
			this.ItemMaxQuantityLabel.Name = "ItemMaxQuantityLabel";
			this.ItemMaxQuantityLabel.Size = new System.Drawing.Size(126, 18);
			this.ItemMaxQuantityLabel.TabIndex = 26;
			this.ItemMaxQuantityLabel.Text = "Item Max Quantity";
			this.ItemMaxQuantityLabel.Visible = false;
			// 
			// ItemQuantityLabel
			// 
			this.ItemQuantityLabel.AutoSize = true;
			this.ItemQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemQuantityLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemQuantityLabel.Location = new System.Drawing.Point(67, 246);
			this.ItemQuantityLabel.Name = "ItemQuantityLabel";
			this.ItemQuantityLabel.Size = new System.Drawing.Size(94, 18);
			this.ItemQuantityLabel.TabIndex = 25;
			this.ItemQuantityLabel.Text = "Item Quantity";
			this.ItemQuantityLabel.Visible = false;
			// 
			// ItemCostLabel
			// 
			this.ItemCostLabel.AutoSize = true;
			this.ItemCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemCostLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemCostLabel.Location = new System.Drawing.Point(76, 194);
			this.ItemCostLabel.Name = "ItemCostLabel";
			this.ItemCostLabel.Size = new System.Drawing.Size(72, 18);
			this.ItemCostLabel.TabIndex = 24;
			this.ItemCostLabel.Text = "Item Cost";
			this.ItemCostLabel.Visible = false;
			// 
			// ItemLocationLabel
			// 
			this.ItemLocationLabel.AutoSize = true;
			this.ItemLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemLocationLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemLocationLabel.Location = new System.Drawing.Point(63, 142);
			this.ItemLocationLabel.Name = "ItemLocationLabel";
			this.ItemLocationLabel.Size = new System.Drawing.Size(97, 18);
			this.ItemLocationLabel.TabIndex = 23;
			this.ItemLocationLabel.Text = "Item Location";
			this.ItemLocationLabel.Visible = false;
			// 
			// ItemLocationEntryBox
			// 
			this.ItemLocationEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemLocationEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemLocationEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemLocationEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemLocationEntryBox.Location = new System.Drawing.Point(24, 163);
			this.ItemLocationEntryBox.Name = "ItemLocationEntryBox";
			this.ItemLocationEntryBox.Size = new System.Drawing.Size(188, 20);
			this.ItemLocationEntryBox.TabIndex = 18;
			this.ItemLocationEntryBox.Text = "The location of purchase";
			this.ItemLocationEntryBox.Visible = false;
			// 
			// ItemNameLabel
			// 
			this.ItemNameLabel.AutoSize = true;
			this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemNameLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemNameLabel.Location = new System.Drawing.Point(72, 92);
			this.ItemNameLabel.Name = "ItemNameLabel";
			this.ItemNameLabel.Size = new System.Drawing.Size(80, 18);
			this.ItemNameLabel.TabIndex = 21;
			this.ItemNameLabel.Text = "Item Name";
			this.ItemNameLabel.Visible = false;
			// 
			// ItemNameEntryBox
			// 
			this.ItemNameEntryBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.ItemNameEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemNameEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemNameEntryBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.ItemNameEntryBox.Location = new System.Drawing.Point(24, 113);
			this.ItemNameEntryBox.Name = "ItemNameEntryBox";
			this.ItemNameEntryBox.Size = new System.Drawing.Size(188, 20);
			this.ItemNameEntryBox.TabIndex = 17;
			this.ItemNameEntryBox.Text = "The name of the item";
			this.ItemNameEntryBox.Visible = false;
			// 
			// ListBoxLabel
			// 
			this.ListBoxLabel.AutoSize = true;
			this.ListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListBoxLabel.ForeColor = System.Drawing.SystemColors.Menu;
			this.ListBoxLabel.Location = new System.Drawing.Point(335, 8);
			this.ListBoxLabel.Name = "ListBoxLabel";
			this.ListBoxLabel.Size = new System.Drawing.Size(46, 18);
			this.ListBoxLabel.TabIndex = 28;
			this.ListBoxLabel.Text = "label2";
			this.ListBoxLabel.Visible = false;
			// 
			// EditList_ListBox
			// 
			this.EditList_ListBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.EditList_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EditList_ListBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.EditList_ListBox.FormattingEnabled = true;
			this.EditList_ListBox.Items.AddRange(new object[] {
            "The list being edited will appear here."});
			this.EditList_ListBox.Location = new System.Drawing.Point(248, 29);
			this.EditList_ListBox.Name = "EditList_ListBox";
			this.EditList_ListBox.Size = new System.Drawing.Size(224, 208);
			this.EditList_ListBox.TabIndex = 27;
			this.EditList_ListBox.Visible = false;
			this.EditList_ListBox.SelectedIndexChanged += new System.EventHandler(this.EditList_ListBox_SelectedIndexChanged);
			// 
			// SaveItemButton
			// 
			this.SaveItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveItemButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.SaveItemButton.Location = new System.Drawing.Point(122, 39);
			this.SaveItemButton.Name = "SaveItemButton";
			this.SaveItemButton.Size = new System.Drawing.Size(100, 35);
			this.SaveItemButton.TabIndex = 29;
			this.SaveItemButton.Text = "Save Item";
			this.SaveItemButton.UseVisualStyleBackColor = true;
			this.SaveItemButton.Visible = false;
			this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
			// 
			// DeleteItemButton
			// 
			this.DeleteItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteItemButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.DeleteItemButton.Location = new System.Drawing.Point(122, 354);
			this.DeleteItemButton.Name = "DeleteItemButton";
			this.DeleteItemButton.Size = new System.Drawing.Size(100, 35);
			this.DeleteItemButton.TabIndex = 30;
			this.DeleteItemButton.Text = "Delete Item";
			this.DeleteItemButton.UseVisualStyleBackColor = true;
			this.DeleteItemButton.Visible = false;
			this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
			// 
			// LoadListButton
			// 
			this.LoadListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadListButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.LoadListButton.Location = new System.Drawing.Point(12, 39);
			this.LoadListButton.Name = "LoadListButton";
			this.LoadListButton.Size = new System.Drawing.Size(100, 35);
			this.LoadListButton.TabIndex = 32;
			this.LoadListButton.Text = "Load List";
			this.LoadListButton.UseVisualStyleBackColor = true;
			this.LoadListButton.Click += new System.EventHandler(this.LoadListButton_Click);
			// 
			// SaveListButton
			// 
			this.SaveListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveListButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.SaveListButton.Location = new System.Drawing.Point(307, 246);
			this.SaveListButton.Name = "SaveListButton";
			this.SaveListButton.Size = new System.Drawing.Size(100, 35);
			this.SaveListButton.TabIndex = 31;
			this.SaveListButton.Text = "Save List";
			this.SaveListButton.UseVisualStyleBackColor = true;
			this.SaveListButton.Visible = false;
			this.SaveListButton.Click += new System.EventHandler(this.SaveListButton_Click);
			// 
			// AddItemButton
			// 
			this.AddItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddItemButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.AddItemButton.Location = new System.Drawing.Point(12, 354);
			this.AddItemButton.Name = "AddItemButton";
			this.AddItemButton.Size = new System.Drawing.Size(100, 35);
			this.AddItemButton.TabIndex = 33;
			this.AddItemButton.Text = "Add Item";
			this.AddItemButton.UseVisualStyleBackColor = true;
			this.AddItemButton.Visible = false;
			this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
			// 
			// EditList_Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(484, 401);
			this.Controls.Add(this.AddItemButton);
			this.Controls.Add(this.LoadListButton);
			this.Controls.Add(this.SaveListButton);
			this.Controls.Add(this.DeleteItemButton);
			this.Controls.Add(this.SaveItemButton);
			this.Controls.Add(this.ListBoxLabel);
			this.Controls.Add(this.EditList_ListBox);
			this.Controls.Add(this.ItemMaxQuantityEntryBox);
			this.Controls.Add(this.ItemQuantityEntryBox);
			this.Controls.Add(this.ItemCostEntryBox);
			this.Controls.Add(this.ItemMaxQuantityLabel);
			this.Controls.Add(this.ItemQuantityLabel);
			this.Controls.Add(this.ItemCostLabel);
			this.Controls.Add(this.ItemLocationLabel);
			this.Controls.Add(this.ItemLocationEntryBox);
			this.Controls.Add(this.ItemNameLabel);
			this.Controls.Add(this.ItemNameEntryBox);
			this.Controls.Add(this.ListNameBox);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.Menu;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditList_Window";
			this.Text = "Edit List";
			((System.ComponentModel.ISupportInitialize)(this.ItemMaxQuantityEntryBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemQuantityEntryBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemCostEntryBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox ListNameBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown ItemMaxQuantityEntryBox;
		private System.Windows.Forms.NumericUpDown ItemQuantityEntryBox;
		private System.Windows.Forms.NumericUpDown ItemCostEntryBox;
		private System.Windows.Forms.Label ItemMaxQuantityLabel;
		private System.Windows.Forms.Label ItemQuantityLabel;
		private System.Windows.Forms.Label ItemCostLabel;
		private System.Windows.Forms.Label ItemLocationLabel;
		private System.Windows.Forms.RichTextBox ItemLocationEntryBox;
		private System.Windows.Forms.Label ItemNameLabel;
		private System.Windows.Forms.RichTextBox ItemNameEntryBox;
		private System.Windows.Forms.Label ListBoxLabel;
		private System.Windows.Forms.ListBox EditList_ListBox;
		private System.Windows.Forms.Button SaveItemButton;
		private System.Windows.Forms.Button DeleteItemButton;
		private System.Windows.Forms.Button LoadListButton;
		private System.Windows.Forms.Button SaveListButton;
		private System.Windows.Forms.Button AddItemButton;
	}
}
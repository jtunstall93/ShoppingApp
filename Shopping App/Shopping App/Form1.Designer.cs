namespace Shopping_App
{
	partial class PrimaryWIndow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryWIndow));
			this.NewList = new System.Windows.Forms.Button();
			this.LoadList = new System.Windows.Forms.Button();
			this.PrintList = new System.Windows.Forms.Button();
			this.BuyListButton = new System.Windows.Forms.Button();
			this.BuyListBox = new System.Windows.Forms.ListBox();
			this.FullListBox = new System.Windows.Forms.ListBox();
			this.FullListItemDetails = new System.Windows.Forms.RichTextBox();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.BuyListItemDetails = new System.Windows.Forms.RichTextBox();
			this.EditListButton = new System.Windows.Forms.Button();
			this.TextListButton = new System.Windows.Forms.Button();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.SuspendLayout();
			// 
			// NewList
			// 
			this.NewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewList.Location = new System.Drawing.Point(12, 12);
			this.NewList.Name = "NewList";
			this.NewList.Size = new System.Drawing.Size(100, 35);
			this.NewList.TabIndex = 0;
			this.NewList.Text = "New List";
			this.NewList.UseVisualStyleBackColor = true;
			this.NewList.Click += new System.EventHandler(this.NewList_Click);
			// 
			// LoadList
			// 
			this.LoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadList.Location = new System.Drawing.Point(12, 53);
			this.LoadList.Name = "LoadList";
			this.LoadList.Size = new System.Drawing.Size(100, 35);
			this.LoadList.TabIndex = 1;
			this.LoadList.Text = "Load List";
			this.LoadList.UseVisualStyleBackColor = true;
			this.LoadList.Click += new System.EventHandler(this.LoadList_Click);
			// 
			// PrintList
			// 
			this.PrintList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrintList.Location = new System.Drawing.Point(12, 176);
			this.PrintList.Name = "PrintList";
			this.PrintList.Size = new System.Drawing.Size(100, 35);
			this.PrintList.TabIndex = 2;
			this.PrintList.Text = "Print List";
			this.PrintList.UseVisualStyleBackColor = true;
			this.PrintList.Click += new System.EventHandler(this.PrintList_Click);
			// 
			// BuyListButton
			// 
			this.BuyListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuyListButton.Location = new System.Drawing.Point(12, 135);
			this.BuyListButton.Name = "BuyListButton";
			this.BuyListButton.Size = new System.Drawing.Size(100, 35);
			this.BuyListButton.TabIndex = 4;
			this.BuyListButton.Text = "Show Buy List";
			this.BuyListButton.UseVisualStyleBackColor = true;
			this.BuyListButton.Click += new System.EventHandler(this.BuyListButton_Click);
			// 
			// BuyListBox
			// 
			this.BuyListBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.BuyListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BuyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuyListBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.BuyListBox.FormattingEnabled = true;
			this.BuyListBox.ItemHeight = 16;
			this.BuyListBox.Items.AddRange(new object[] {
            "Items in your buy list will appear here."});
			this.BuyListBox.Location = new System.Drawing.Point(306, 12);
			this.BuyListBox.Name = "BuyListBox";
			this.BuyListBox.Size = new System.Drawing.Size(250, 304);
			this.BuyListBox.TabIndex = 5;
			this.BuyListBox.SelectedIndexChanged += new System.EventHandler(this.BuyListBox_SelectedIndexChanged);
			// 
			// FullListBox
			// 
			this.FullListBox.BackColor = System.Drawing.SystemColors.GrayText;
			this.FullListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FullListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FullListBox.ForeColor = System.Drawing.SystemColors.Menu;
			this.FullListBox.FormattingEnabled = true;
			this.FullListBox.ItemHeight = 16;
			this.FullListBox.Items.AddRange(new object[] {
            "The full shopping list will appear here."});
			this.FullListBox.Location = new System.Drawing.Point(573, 12);
			this.FullListBox.Name = "FullListBox";
			this.FullListBox.Size = new System.Drawing.Size(250, 304);
			this.FullListBox.TabIndex = 6;
			this.FullListBox.SelectedIndexChanged += new System.EventHandler(this.FullListBox_SelectedIndexChanged);
			// 
			// FullListItemDetails
			// 
			this.FullListItemDetails.BackColor = System.Drawing.SystemColors.GrayText;
			this.FullListItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FullListItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FullListItemDetails.ForeColor = System.Drawing.SystemColors.Menu;
			this.FullListItemDetails.Location = new System.Drawing.Point(573, 322);
			this.FullListItemDetails.Name = "FullListItemDetails";
			this.FullListItemDetails.Size = new System.Drawing.Size(250, 152);
			this.FullListItemDetails.TabIndex = 7;
			this.FullListItemDetails.Text = "Item details will appear here.";
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.BackColor = System.Drawing.SystemColors.GrayText;
			this.monthCalendar1.ForeColor = System.Drawing.SystemColors.Menu;
			this.monthCalendar1.Location = new System.Drawing.Point(12, 312);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 8;
			this.monthCalendar1.TitleForeColor = System.Drawing.Color.DarkTurquoise;
			// 
			// BuyListItemDetails
			// 
			this.BuyListItemDetails.BackColor = System.Drawing.SystemColors.GrayText;
			this.BuyListItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BuyListItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuyListItemDetails.ForeColor = System.Drawing.SystemColors.Menu;
			this.BuyListItemDetails.Location = new System.Drawing.Point(306, 322);
			this.BuyListItemDetails.Name = "BuyListItemDetails";
			this.BuyListItemDetails.Size = new System.Drawing.Size(250, 152);
			this.BuyListItemDetails.TabIndex = 9;
			this.BuyListItemDetails.Text = "Item details will appear here.";
			// 
			// EditListButton
			// 
			this.EditListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditListButton.Location = new System.Drawing.Point(12, 94);
			this.EditListButton.Name = "EditListButton";
			this.EditListButton.Size = new System.Drawing.Size(100, 35);
			this.EditListButton.TabIndex = 10;
			this.EditListButton.Text = "Edit List";
			this.EditListButton.UseVisualStyleBackColor = true;
			this.EditListButton.Click += new System.EventHandler(this.EditListButton_Click);
			// 
			// TextListButton
			// 
			this.TextListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextListButton.Location = new System.Drawing.Point(12, 217);
			this.TextListButton.Name = "TextListButton";
			this.TextListButton.Size = new System.Drawing.Size(100, 35);
			this.TextListButton.TabIndex = 11;
			this.TextListButton.Text = "Text List";
			this.TextListButton.UseVisualStyleBackColor = true;
			this.TextListButton.Visible = false;
			this.TextListButton.Click += new System.EventHandler(this.TextListButton_Click);
			// 
			// PrimaryWIndow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(834, 486);
			this.Controls.Add(this.TextListButton);
			this.Controls.Add(this.EditListButton);
			this.Controls.Add(this.BuyListItemDetails);
			this.Controls.Add(this.FullListItemDetails);
			this.Controls.Add(this.FullListBox);
			this.Controls.Add(this.BuyListBox);
			this.Controls.Add(this.BuyListButton);
			this.Controls.Add(this.PrintList);
			this.Controls.Add(this.LoadList);
			this.Controls.Add(this.NewList);
			this.Controls.Add(this.monthCalendar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PrimaryWIndow";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button NewList;
		private System.Windows.Forms.Button LoadList;
		private System.Windows.Forms.Button PrintList;
		private System.Windows.Forms.Button BuyListButton;
		private System.Windows.Forms.ListBox BuyListBox;
		private System.Windows.Forms.RichTextBox FullListItemDetails;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.RichTextBox BuyListItemDetails;
		private System.Windows.Forms.Button EditListButton;
		private System.Windows.Forms.Button TextListButton;
		private System.Drawing.Printing.PrintDocument printDocument;
		public System.Windows.Forms.ListBox FullListBox;
	}
}


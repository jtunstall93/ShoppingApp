namespace Shopping_App
{
	partial class LoadType_Window
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadType_Window));
			this.LoadXL_Button = new System.Windows.Forms.Button();
			this.LoadTextButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LoadXL_Button
			// 
			this.LoadXL_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadXL_Button.ForeColor = System.Drawing.SystemColors.InfoText;
			this.LoadXL_Button.Location = new System.Drawing.Point(127, 12);
			this.LoadXL_Button.Name = "LoadXL_Button";
			this.LoadXL_Button.Size = new System.Drawing.Size(100, 35);
			this.LoadXL_Button.TabIndex = 35;
			this.LoadXL_Button.Text = "Load excel";
			this.LoadXL_Button.UseVisualStyleBackColor = true;
			this.LoadXL_Button.Click += new System.EventHandler(this.LoadXL_Button_Click);
			// 
			// LoadTextButton
			// 
			this.LoadTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadTextButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.LoadTextButton.Location = new System.Drawing.Point(12, 12);
			this.LoadTextButton.Name = "LoadTextButton";
			this.LoadTextButton.Size = new System.Drawing.Size(100, 35);
			this.LoadTextButton.TabIndex = 36;
			this.LoadTextButton.Text = "Load .txt";
			this.LoadTextButton.UseVisualStyleBackColor = true;
			this.LoadTextButton.Click += new System.EventHandler(this.LoadTextButton_Click);
			// 
			// LoadType_Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(239, 61);
			this.Controls.Add(this.LoadTextButton);
			this.Controls.Add(this.LoadXL_Button);
			this.ForeColor = System.Drawing.SystemColors.Menu;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoadType_Window";
			this.Text = "Form5";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button LoadXL_Button;
		private System.Windows.Forms.Button LoadTextButton;
	}
}
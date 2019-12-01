namespace UserMaintenance
{
	partial class Form1
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.txtBoxLastName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtBoxFirstName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(12, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(332, 404);
			this.listBox1.TabIndex = 0;
			// 
			// txtBoxLastName
			// 
			this.txtBoxLastName.Location = new System.Drawing.Point(495, 32);
			this.txtBoxLastName.Name = "txtBoxLastName";
			this.txtBoxLastName.Size = new System.Drawing.Size(264, 26);
			this.txtBoxLastName.TabIndex = 1;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(362, 94);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(51, 20);
			this.lblFirstName.TabIndex = 3;
			this.lblFirstName.Text = "label1";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(362, 32);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(51, 20);
			this.lblLastName.TabIndex = 4;
			this.lblLastName.Text = "label2";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(644, 201);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(115, 37);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "button1";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// txtBoxFirstName
			// 
			this.txtBoxFirstName.Location = new System.Drawing.Point(495, 94);
			this.txtBoxFirstName.Name = "txtBoxFirstName";
			this.txtBoxFirstName.Size = new System.Drawing.Size(264, 26);
			this.txtBoxFirstName.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtBoxFirstName);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtBoxLastName);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox txtBoxLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtBoxFirstName;
	}
}


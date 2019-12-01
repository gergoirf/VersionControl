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
			this.listUsers = new System.Windows.Forms.ListBox();
			this.txtBoxFullName = new System.Windows.Forms.TextBox();
			this.lblFullName = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listUsers
			// 
			this.listUsers.FormattingEnabled = true;
			this.listUsers.ItemHeight = 20;
			this.listUsers.Location = new System.Drawing.Point(12, 32);
			this.listUsers.Name = "listUsers";
			this.listUsers.Size = new System.Drawing.Size(332, 404);
			this.listUsers.TabIndex = 0;
			// 
			// txtBoxFullName
			// 
			this.txtBoxFullName.Location = new System.Drawing.Point(495, 32);
			this.txtBoxFullName.Name = "txtBoxFullName";
			this.txtBoxFullName.Size = new System.Drawing.Size(264, 26);
			this.txtBoxFullName.TabIndex = 1;
			// 
			// lblFullName
			// 
			this.lblFullName.AutoSize = true;
			this.lblFullName.Location = new System.Drawing.Point(362, 32);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(51, 20);
			this.lblFullName.TabIndex = 4;
			this.lblFullName.Text = "label2";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(644, 201);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(115, 37);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "button1";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(644, 367);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(115, 37);
			this.btnExport.TabIndex = 6;
			this.btnExport.Text = "button1";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(508, 201);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(115, 37);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "button1";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblFullName);
			this.Controls.Add(this.txtBoxFullName);
			this.Controls.Add(this.listUsers);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listUsers;
		private System.Windows.Forms.TextBox txtBoxFullName;
		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnDelete;
	}
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
	public partial class Form1 : Form
	{
		BindingList<Entities.User> users = new BindingList<Entities.User>();
		public Form1()
		{
			InitializeComponent();
			lblFullName.Text = Resource1.FullName;
			btnAdd.Text = Resource1.Add;
			btnExport.Text = Resource1.Export;
			btnDelete.Text = Resource1.Delete;

			listUsers.DataSource = users;
			listUsers.ValueMember = "ID";
			listUsers.DisplayMember = "FullName";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var u = new Entities.User()
			{
				FullName = txtBoxFullName.Text,
			};
			users.Add(u);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.FileName = "nevsor";
			sfd.DefaultExt = "txt";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter(sfd.OpenFile()))
				{
					sw.WriteLine("ID;Név");
					foreach (var User in users)
					{
						sw.WriteLine(User.ID + ";" + User.FullName);
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			users.RemoveAt(listUsers.SelectedIndex);
			listUsers.Refresh();
		}
	}
}

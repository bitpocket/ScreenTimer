using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ScreenTimeClient
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		//screentimer_dbEntities db = new screentimer_dbEntities();

		private void bRegisterTimeChunk_Click(object sender, EventArgs e)
		{
			DateTime dt1 = DateTime.Now.AddHours(-1);
			DateTime dt2 = DateTime.Now;
		}

		//AspNetUser CurrentUser = null;

		private void bLogin_Click(object sender, EventArgs e)
		{
			//this.aspNetUserBindingSource.DataSource = db.AspNetUsers;

			//string user = "screentimer_db1";
			//string pass = "qwQW12!@";
			string email = "a@b.c";

			//AspNetUser user = DB.GetUser(email);

			//if (user != null)
			//{

			//}

		}
	}
}

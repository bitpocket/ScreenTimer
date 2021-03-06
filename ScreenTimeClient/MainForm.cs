﻿using Bitpocket.ScreenTimer.Data;
using Bitpocket.ScreenTimer.Entity;
using Bitpocket.ScreenTimer.Test;
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
			Initialize();
		}

		private IRepository _repository;

		public void Initialize()
		{
			_repository = new ScreenTimerRepository();
		}

		private void bRegisterTimeChunk_Click(object sender, EventArgs e)
		{
			if (CurrentUser != null) { 
				DateTime dt1 = DateTime.Now.AddHours(-1);
				DateTime dt2 = DateTime.Now;

				Time ts = new Time();
				ts.Id = Guid.NewGuid().ToString();
                ts.UserId = CurrentUser.Id;
				ts.From = DateTime.Now.AddHours(-1);
				ts.To = DateTime.Now;

				_repository.AddTimeChunk<Time>(ts);
            }
		}

		AspNetUser CurrentUser = null;


		private void bLogin_Click(object sender, EventArgs e)
		{
			string name = "a@b.c";

			CurrentUser = _repository.AllIncluding<AspNetUser>()
				.First<AspNetUser>(x => x.UserName == name);

			if (CurrentUser != null)
			{
				this.lHello.Text = string.Format("Hello {0}", CurrentUser.UserName);
				this.bRegisterTimeChunk.Enabled = true;
			}
		}
	}
}

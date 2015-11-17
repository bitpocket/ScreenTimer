using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bitpocket.ScreenTimer.Data;
using Bitpocket.ScreenTimer.Entity;
using System.Diagnostics;
using System.Linq;

namespace Bitpocket.ScreenTimer.Test
{
	[TestClass]
	public class ConsumerTests
	{
		private IRepository _repository;

		[TestInitialize]
		public void Initialize()
		{
			_repository = new ScreenTimerRepository();
		}

		[TestMethod]
		public void Query_AllUsers_NoException()
		{
			var list = _repository.All<AspNetUser>();

			foreach (var item in list)
			{
				Trace.TraceInformation("User Name: {0}", item.UserName);
			}
		}

		[TestMethod]
		public void GetSpecificUserId()
		{
			string name = "a@b.c";

			var list = _repository.AllIncluding<AspNetUser>()
				.Where<AspNetUser>(x => x.UserName == name);

			foreach (var item in list)
			{
				Trace.TraceInformation("User Name: {0}", item.Id);
			}
		}

		[TestMethod]
		public void NoUserForFailedName()
		{
			string name = "someFailedName";

			var list = _repository.AllIncluding<AspNetUser>()
				.Where<AspNetUser>(x => x.UserName == name);

			foreach (var item in list)
			{
				throw new Exception("should return no value");
			}
		}
	}
}

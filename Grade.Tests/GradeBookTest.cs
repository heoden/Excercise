using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Tests
{
	[TestClass]
	public class GradeBookTest
	{
		[TestMethod]
		public void ComputeHighestGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(50);
			book.AddGrade(70.5f);

			GradeStatistics result = new GradeStatistics();
			result = book.ComputeStatistics();
			Assert.AreEqual(70.50, result.HighestGrade);
		}

		[TestMethod]
		public void ComputeLowestGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(80);
			book.AddGrade(90);

			GradeStatistics result = book.ComputeStatistics();
			Assert.AreEqual(80, result.LowestGrade);
		}
	}
}

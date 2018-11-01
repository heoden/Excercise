using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
	public class GradeBook
	{
		List<float> grades = new List<float>();
		public void AddGrade(float grade)
		{
			grades.Add(grade);

		}
		public GradeStatistics ComputeStatistics()
		{
			GradeStatistics stat = new GradeStatistics();
			float sum = 0;
			foreach (float grade in grades)
			{
				sum = sum + grade;
				stat.AverageGrade = sum / grades.Count();
				stat.HighestGrade = Math.Max(grade, stat.HighestGrade);
				stat.LowestGrade = Math.Min(grade, stat.LowestGrade);
			}
			return stat;
			asfasfsfsafs
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
	class Program
	{
		static void Main(string[] args)
		{
			GradeStatistics stat = new GradeStatistics();
			SpeechSynthesizer sync = new SpeechSynthesizer();
			sync.Speak("hello, my name is Uyen");


			GradeBook book = new GradeBook();
			book.AddGrade(91);
			book.AddGrade(89.5f);
			stat = book.ComputeStatistics();
			Console.WriteLine(stat.AverageGrade);
			Console.WriteLine(stat.HighestGrade);
			Console.WriteLine(stat.AverageGrade);
		}
	}
}

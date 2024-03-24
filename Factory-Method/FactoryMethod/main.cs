using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ReportFactory reportFactory = new PdfReportFactory(); 
			IReport report = reportFactory.CreateReport();
			report.Generate(); 

			reportFactory = new TextReportFactory(); 
			report = reportFactory.CreateReport();
			report.Generate(); 
		}
	}

}

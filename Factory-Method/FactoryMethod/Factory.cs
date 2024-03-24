using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public abstract class ReportFactory
	{
		public abstract IReport CreateReport();
	}

	public class PdfReportFactory : ReportFactory
	{
		public override IReport CreateReport()
		{
			
				return new PdfReport();
			
		}
	}
	public class TextReportFactory : ReportFactory
	{
		public override IReport CreateReport()
		{
			
				return new TextReport();
			
		}
	}

}


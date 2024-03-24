

namespace FactoryMethod
{
	public interface IReport
	{
		void Generate();
	}
	public class PdfReport : IReport
	{
		public void Generate()
		{
			Console.WriteLine("Generating PDF report...");
		}
	}
	public class TextReport : IReport
	{
		public void Generate()
		{
			Console.WriteLine("Generating Text report...");
		}
	}

}

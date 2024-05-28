using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class Book : IElement
	{
		public string Title { get; set; }
		public double Price { get; set; }

		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class Fruit : IElement
	{
		public string Name { get; set; }
		public double PricePerKg { get; set; }
		public double Weight { get; set; }

		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

}

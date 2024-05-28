﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	public class PriceVisitor : IVisitor
	{
		public double TotalPrice { get; private set; }

		public void Visit(Book book)
		{
			TotalPrice += book.Price;
		}

		public void Visit(Fruit fruit)
		{
			TotalPrice += fruit.PricePerKg * fruit.Weight;
		}
	}

}

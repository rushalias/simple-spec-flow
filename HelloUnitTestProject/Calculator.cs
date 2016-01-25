using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloUnitTestProject
{
	class Calculator
	{
		public int FirstNumber { set; private get; }
		public int SecondNumber { set; private get; }
		public int Add()
		{
			return FirstNumber + SecondNumber;
		}
	}
}

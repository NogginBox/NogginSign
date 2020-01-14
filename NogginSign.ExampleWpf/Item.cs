using System;
using System.Collections.Generic;
using System.Text;

namespace NogginSign.ExampleWpf
{
	public class Item<T>
	{
		public Item(string name, T value)
		{
			Name = name;
			Value = value;
		}

		public string Name { get; }

		public T Value { get; }
	}
}

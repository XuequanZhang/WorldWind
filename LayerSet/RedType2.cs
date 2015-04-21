//
// RedType2.cs.cs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace LayerSet
{

	public class RedType2 : SchemaInt
	{

		public RedType2() : base()
		{
		}

		public RedType2(string newValue) : base(newValue)
		{
			Validate();
		}

		public RedType2(SchemaInt newValue) : base(newValue)
		{
			Validate();
		}

		public void Validate()
		{

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Out of range");

			if (CompareTo(GetMaxInclusive()) > 0)
				throw new System.Exception("Out of range");
		}
		public SchemaInt GetMinInclusive()
		{
			return new SchemaInt("0");
		}
		public SchemaInt GetMaxInclusive()
		{
			return new SchemaInt("255");
		}
	}
}
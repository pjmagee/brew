//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace datadomain
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public enum Suit
	{
		SPADES,
		HEARTS,
		DIAMONDS,
		CLUBS,
	}
	public partial class Person : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Person\",\"namespace\":\"datadomain\",\"fields\":[{\"name\":\"Name" +
				"\",\"type\":\"string\"},{\"name\":\"Age\",\"type\":\"long\"}]}");
		private string _Name;
		private long _Age;
		public virtual Schema Schema
		{
			get
			{
				return Person._SCHEMA;
			}
		}
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}
		public long Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				this._Age = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Name;
			case 1: return this.Age;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Name = (System.String)fieldValue; break;
			case 1: this.Age = (System.Int64)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

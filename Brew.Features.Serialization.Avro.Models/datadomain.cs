//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
	using global::Avro;
	using global::Avro.Specific;
	
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Brew.Console", "1.11.3")]
	public enum Suit
	{
		SPADES,
		HEARTS,
		DIAMONDS,
		CLUBS,
	}
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Brew.Console", "1.11.3")]
	public partial class Person : global::Avro.Specific.ISpecificRecord
	{
		public static global::Avro.Schema _SCHEMA = global::Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Person\",\"namespace\":\"datadomain\",\"fields\":[{\"name\":\"Name" +
				"\",\"type\":\"string\"},{\"name\":\"Age\",\"type\":\"long\"}]}");
		private string _Name;
		private long _Age;
		public virtual global::Avro.Schema Schema
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
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Name = (System.String)fieldValue; break;
			case 1: this.Age = (System.Int64)fieldValue; break;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using DataAccessModel;

namespace DataAccessModel	
{
	public partial class Customer
	{
		private int _idCustomer;
		public virtual int IdCustomer
		{
			get
			{
				return this._idCustomer;
			}
			set
			{
				this._idCustomer = value;
			}
		}
		
		private string _name;
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		private string _location;
		public virtual string Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}
		
		private IList<Transaction> _transactions = new List<Transaction>();
		public virtual IList<Transaction> Transactions
		{
			get
			{
				return this._transactions;
			}
		}
		
	}
}
#pragma warning restore 1591

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQDemo
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LogInOnlySample")]
	public partial class LoginSampleDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public LoginSampleDataContext() : 
				base(global::LINQDemo.Properties.Settings.Default.LogInOnlySampleConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LoginSampleDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginSampleDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginSampleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginSampleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.uspActualLogin")]
		public ISingleResult<uspActualLoginResult> uspActualLogin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UID", DbType="VarChar(50)")] string uID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UPass", DbType="NChar(16)")] string uPass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), uID, uPass);
			return ((ISingleResult<uspActualLoginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.uspActualInsertLog")]
		public int uspActualInsertLog([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UID", DbType="NVarChar(50)")] string uID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> logType, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string logMessage)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), uID, logType, logMessage);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.uspActualUpdateLastLog")]
		public int uspActualUpdateLastLog([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UID", DbType="NVarChar(50)")] string uID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), uID);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class uspActualLoginResult
	{
		
		private string _UID;
		
		private string _ULastName;
		
		private string _UFirstName;
		
		private System.DateTime _ULastLogin;
		
		public uspActualLoginResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UID
		{
			get
			{
				return this._UID;
			}
			set
			{
				if ((this._UID != value))
				{
					this._UID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ULastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ULastName
		{
			get
			{
				return this._ULastName;
			}
			set
			{
				if ((this._ULastName != value))
				{
					this._ULastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UFirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UFirstName
		{
			get
			{
				return this._UFirstName;
			}
			set
			{
				if ((this._UFirstName != value))
				{
					this._UFirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ULastLogin", DbType="DateTime NOT NULL")]
		public System.DateTime ULastLogin
		{
			get
			{
				return this._ULastLogin;
			}
			set
			{
				if ((this._ULastLogin != value))
				{
					this._ULastLogin = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

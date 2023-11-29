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

namespace midterm
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="midtermLogin")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTable_Product(Table_Product instance);
    partial void UpdateTable_Product(Table_Product instance);
    partial void DeleteTable_Product(Table_Product instance);
    partial void InsertTable_Transaction(Table_Transaction instance);
    partial void UpdateTable_Transaction(Table_Transaction instance);
    partial void DeleteTable_Transaction(Table_Transaction instance);
    partial void InsertTable_User(Table_User instance);
    partial void UpdateTable_User(Table_User instance);
    partial void DeleteTable_User(Table_User instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::midterm.Properties.Settings.Default.midtermLoginConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Table_Product> Table_Products
		{
			get
			{
				return this.GetTable<Table_Product>();
			}
		}
		
		public System.Data.Linq.Table<Table_Transaction> Table_Transactions
		{
			get
			{
				return this.GetTable<Table_Transaction>();
			}
		}
		
		public System.Data.Linq.Table<Table_User> Table_Users
		{
			get
			{
				return this.GetTable<Table_User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_Product")]
	public partial class Table_Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _Name;
		
		private string _Description;
		
		private System.Nullable<int> _No_of_Stock;
		
		private System.Nullable<decimal> _Cost;
		
		private System.Nullable<decimal> _Selling_Price;
		
		private EntitySet<Table_Transaction> _Table_Transactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnNo_of_StockChanging(System.Nullable<int> value);
    partial void OnNo_of_StockChanged();
    partial void OnCostChanging(System.Nullable<decimal> value);
    partial void OnCostChanged();
    partial void OnSelling_PriceChanging(System.Nullable<decimal> value);
    partial void OnSelling_PriceChanged();
    #endregion
		
		public Table_Product()
		{
			this._Table_Transactions = new EntitySet<Table_Transaction>(new Action<Table_Transaction>(this.attach_Table_Transactions), new Action<Table_Transaction>(this.detach_Table_Transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[No of Stock]", Storage="_No_of_Stock", DbType="Int")]
		public System.Nullable<int> No_of_Stock
		{
			get
			{
				return this._No_of_Stock;
			}
			set
			{
				if ((this._No_of_Stock != value))
				{
					this.OnNo_of_StockChanging(value);
					this.SendPropertyChanging();
					this._No_of_Stock = value;
					this.SendPropertyChanged("No_of_Stock");
					this.OnNo_of_StockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Money")]
		public System.Nullable<decimal> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Selling Price]", Storage="_Selling_Price", DbType="Money")]
		public System.Nullable<decimal> Selling_Price
		{
			get
			{
				return this._Selling_Price;
			}
			set
			{
				if ((this._Selling_Price != value))
				{
					this.OnSelling_PriceChanging(value);
					this.SendPropertyChanging();
					this._Selling_Price = value;
					this.SendPropertyChanged("Selling_Price");
					this.OnSelling_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_Product_Table_Transaction", Storage="_Table_Transactions", ThisKey="ProductID", OtherKey="ProductID")]
		public EntitySet<Table_Transaction> Table_Transactions
		{
			get
			{
				return this._Table_Transactions;
			}
			set
			{
				this._Table_Transactions.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Table_Transactions(Table_Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Table_Product = this;
		}
		
		private void detach_Table_Transactions(Table_Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Table_Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_Transaction")]
	public partial class Table_Transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TransactionID;
		
		private int _ProductID;
		
		private string _UserID;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<decimal> _Price;
		
		private string _TransactionType;
		
		private System.Nullable<System.DateTime> _Timestamp;
		
		private EntityRef<Table_Product> _Table_Product;
		
		private EntityRef<Table_User> _Table_User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIDChanging(int value);
    partial void OnTransactionIDChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnTransactionTypeChanging(string value);
    partial void OnTransactionTypeChanged();
    partial void OnTimestampChanging(System.Nullable<System.DateTime> value);
    partial void OnTimestampChanged();
    #endregion
		
		public Table_Transaction()
		{
			this._Table_Product = default(EntityRef<Table_Product>);
			this._Table_User = default(EntityRef<Table_User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TransactionID
		{
			get
			{
				return this._TransactionID;
			}
			set
			{
				if ((this._TransactionID != value))
				{
					this.OnTransactionIDChanging(value);
					this.SendPropertyChanging();
					this._TransactionID = value;
					this.SendPropertyChanged("TransactionID");
					this.OnTransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL")]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					if (this._Table_Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(20)")]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._Table_User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionType", DbType="NVarChar(50)")]
		public string TransactionType
		{
			get
			{
				return this._TransactionType;
			}
			set
			{
				if ((this._TransactionType != value))
				{
					this.OnTransactionTypeChanging(value);
					this.SendPropertyChanging();
					this._TransactionType = value;
					this.SendPropertyChanged("TransactionType");
					this.OnTransactionTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				if ((this._Timestamp != value))
				{
					this.OnTimestampChanging(value);
					this.SendPropertyChanging();
					this._Timestamp = value;
					this.SendPropertyChanged("Timestamp");
					this.OnTimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_Product_Table_Transaction", Storage="_Table_Product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
		public Table_Product Table_Product
		{
			get
			{
				return this._Table_Product.Entity;
			}
			set
			{
				Table_Product previousValue = this._Table_Product.Entity;
				if (((previousValue != value) 
							|| (this._Table_Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Table_Product.Entity = null;
						previousValue.Table_Transactions.Remove(this);
					}
					this._Table_Product.Entity = value;
					if ((value != null))
					{
						value.Table_Transactions.Add(this);
						this._ProductID = value.ProductID;
					}
					else
					{
						this._ProductID = default(int);
					}
					this.SendPropertyChanged("Table_Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_User_Table_Transaction", Storage="_Table_User", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
		public Table_User Table_User
		{
			get
			{
				return this._Table_User.Entity;
			}
			set
			{
				Table_User previousValue = this._Table_User.Entity;
				if (((previousValue != value) 
							|| (this._Table_User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Table_User.Entity = null;
						previousValue.Table_Transactions.Remove(this);
					}
					this._Table_User.Entity = value;
					if ((value != null))
					{
						value.Table_Transactions.Add(this);
						this._UserID = value.UserID;
					}
					else
					{
						this._UserID = default(string);
					}
					this.SendPropertyChanged("Table_User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_User")]
	public partial class Table_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private string _Password;
		
		private string _UserType;
		
		private EntitySet<Table_Transaction> _Table_Transactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    #endregion
		
		public Table_User()
		{
			this._Table_Transactions = new EntitySet<Table_Transaction>(new Action<Table_Transaction>(this.attach_Table_Transactions), new Action<Table_Transaction>(this.detach_Table_Transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(16)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="NVarChar(20)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_User_Table_Transaction", Storage="_Table_Transactions", ThisKey="UserID", OtherKey="UserID")]
		public EntitySet<Table_Transaction> Table_Transactions
		{
			get
			{
				return this._Table_Transactions;
			}
			set
			{
				this._Table_Transactions.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Table_Transactions(Table_Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Table_User = this;
		}
		
		private void detach_Table_Transactions(Table_Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Table_User = null;
		}
	}
}
#pragma warning restore 1591
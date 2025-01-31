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

namespace webQuyTuThien.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TuThien")]
	public partial class FundDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTheLoai(TheLoai instance);
    partial void UpdateTheLoai(TheLoai instance);
    partial void DeleteTheLoai(TheLoai instance);
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertPhanQuyen(PhanQuyen instance);
    partial void UpdatePhanQuyen(PhanQuyen instance);
    partial void DeletePhanQuyen(PhanQuyen instance);
    partial void InsertDonate(Donate instance);
    partial void UpdateDonate(Donate instance);
    partial void DeleteDonate(Donate instance);
    partial void InsertFund(Fund instance);
    partial void UpdateFund(Fund instance);
    partial void DeleteFund(Fund instance);
        #endregion
        public FundDataDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TuThienConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
        public FundDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FundDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FundDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FundDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TheLoai> TheLoais
		{
			get
			{
				return this.GetTable<TheLoai>();
			}
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<PhanQuyen> PhanQuyens
		{
			get
			{
				return this.GetTable<PhanQuyen>();
			}
		}
		
		public System.Data.Linq.Table<Donate> Donates
		{
			get
			{
				return this.GetTable<Donate>();
			}
		}
		
		public System.Data.Linq.Table<Fund> Funds
		{
			get
			{
				return this.GetTable<Fund>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TheLoai")]
	public partial class TheLoai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maloai;
		
		private string _tenloai;
		
		private EntitySet<Fund> _Funds;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaloaiChanging(int value);
    partial void OnmaloaiChanged();
    partial void OntenloaiChanging(string value);
    partial void OntenloaiChanged();
    #endregion
		
		public TheLoai()
		{
			this._Funds = new EntitySet<Fund>(new Action<Fund>(this.attach_Funds), new Action<Fund>(this.detach_Funds));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenloai", DbType="NVarChar(30)")]
		public string tenloai
		{
			get
			{
				return this._tenloai;
			}
			set
			{
				if ((this._tenloai != value))
				{
					this.OntenloaiChanging(value);
					this.SendPropertyChanging();
					this._tenloai = value;
					this.SendPropertyChanged("tenloai");
					this.OntenloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai_Fund", Storage="_Funds", ThisKey="maloai", OtherKey="maloai")]
		public EntitySet<Fund> Funds
		{
			get
			{
				return this._Funds;
			}
			set
			{
				this._Funds.Assign(value);
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
		
		private void attach_Funds(Fund entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai = this;
		}
		
		private void detach_Funds(Fund entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
		private EntitySet<PhanQuyen> _PhanQuyens;
		
		private EntitySet<Fund> _Funds;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public Account()
		{
			this._PhanQuyens = new EntitySet<PhanQuyen>(new Action<PhanQuyen>(this.attach_PhanQuyens), new Action<PhanQuyen>(this.detach_PhanQuyens));
			this._Funds = new EntitySet<Fund>(new Action<Fund>(this.attach_Funds), new Action<Fund>(this.detach_Funds));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="NChar(20)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NChar(30)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_PhanQuyen", Storage="_PhanQuyens", ThisKey="ID", OtherKey="idTaiKhoan")]
		public EntitySet<PhanQuyen> PhanQuyens
		{
			get
			{
				return this._PhanQuyens;
			}
			set
			{
				this._PhanQuyens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Fund", Storage="_Funds", ThisKey="ID", OtherKey="id")]
		public EntitySet<Fund> Funds
		{
			get
			{
				return this._Funds;
			}
			set
			{
				this._Funds.Assign(value);
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
		
		private void attach_PhanQuyens(PhanQuyen entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_PhanQuyens(PhanQuyen entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
		
		private void attach_Funds(Fund entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Funds(Fund entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhanQuyen")]
	public partial class PhanQuyen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _idTaiKhoan;
		
		private string _Quyen;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidTaiKhoanChanging(System.Nullable<int> value);
    partial void OnidTaiKhoanChanged();
    partial void OnQuyenChanging(string value);
    partial void OnQuyenChanged();
    #endregion
		
		public PhanQuyen()
		{
			this._Account = default(EntityRef<Account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTaiKhoan", DbType="Int")]
		public System.Nullable<int> idTaiKhoan
		{
			get
			{
				return this._idTaiKhoan;
			}
			set
			{
				if ((this._idTaiKhoan != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._idTaiKhoan = value;
					this.SendPropertyChanged("idTaiKhoan");
					this.OnidTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quyen", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Quyen
		{
			get
			{
				return this._Quyen;
			}
			set
			{
				if ((this._Quyen != value))
				{
					this.OnQuyenChanging(value);
					this.SendPropertyChanging();
					this._Quyen = value;
					this.SendPropertyChanged("Quyen");
					this.OnQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_PhanQuyen", Storage="_Account", ThisKey="idTaiKhoan", OtherKey="ID", IsForeignKey=true, DeleteRule="CASCADE")]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.PhanQuyens.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.PhanQuyens.Add(this);
						this._idTaiKhoan = value.ID;
					}
					else
					{
						this._idTaiKhoan = default(Nullable<int>);
					}
					this.SendPropertyChanged("Account");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Donate")]
	public partial class Donate : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdDonate;
		
		private string _congratulation;
		
		private string _name;
		
		private System.Nullable<int> _amount;
		
		private EntitySet<Fund> _Funds;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdDonateChanging(int value);
    partial void OnIdDonateChanged();
    partial void OncongratulationChanging(string value);
    partial void OncongratulationChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnamountChanging(System.Nullable<int> value);
    partial void OnamountChanged();
    #endregion
		
		public Donate()
		{
			this._Funds = new EntitySet<Fund>(new Action<Fund>(this.attach_Funds), new Action<Fund>(this.detach_Funds));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDonate", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdDonate
		{
			get
			{
				return this._IdDonate;
			}
			set
			{
				if ((this._IdDonate != value))
				{
					this.OnIdDonateChanging(value);
					this.SendPropertyChanging();
					this._IdDonate = value;
					this.SendPropertyChanged("IdDonate");
					this.OnIdDonateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_congratulation", DbType="NChar(100)")]
		public string congratulation
		{
			get
			{
				return this._congratulation;
			}
			set
			{
				if ((this._congratulation != value))
				{
					this.OncongratulationChanging(value);
					this.SendPropertyChanging();
					this._congratulation = value;
					this.SendPropertyChanged("congratulation");
					this.OncongratulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(20)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int")]
		public System.Nullable<int> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Donate_Fund", Storage="_Funds", ThisKey="IdDonate", OtherKey="id")]
		public EntitySet<Fund> Funds
		{
			get
			{
				return this._Funds;
			}
			set
			{
				this._Funds.Assign(value);
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
		
		private void attach_Funds(Fund entity)
		{
			this.SendPropertyChanging();
			entity.Donate = this;
		}
		
		private void detach_Funds(Fund entity)
		{
			this.SendPropertyChanging();
			entity.Donate = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fund")]
	public partial class Fund : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _maloai;
		
		private string _name;
		
		private string _description;
		
		private string _content;
		
		private string _hinh;
		
		private System.Nullable<int> _expected_result;
		
		private string _status;
		
		private System.Nullable<System.DateTime> _created_date;
		
		private System.Nullable<System.DateTime> _end_date;
		
		private System.Nullable<int> _full_amount;
		
		private EntityRef<TheLoai> _TheLoai;
		
		private EntityRef<Donate> _Donate;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnmaloaiChanging(System.Nullable<int> value);
    partial void OnmaloaiChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OncontentChanging(string value);
    partial void OncontentChanged();
    partial void OnhinhChanging(string value);
    partial void OnhinhChanged();
    partial void Onexpected_resultChanging(System.Nullable<int> value);
    partial void Onexpected_resultChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void Oncreated_dateChanging(System.Nullable<System.DateTime> value);
    partial void Oncreated_dateChanged();
    partial void Onend_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onend_dateChanged();
    partial void Onfull_amountChanging(System.Nullable<int> value);
    partial void Onfull_amountChanged();
    #endregion
		
		public Fund()
		{
			this._TheLoai = default(EntityRef<TheLoai>);
			this._Donate = default(EntityRef<Donate>);
			this._Account = default(EntityRef<Account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					if ((this._Donate.HasLoadedOrAssignedValue || this._Account.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", DbType="Int")]
		public System.Nullable<int> maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					if (this._TheLoai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_content", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string content
		{
			get
			{
				return this._content;
			}
			set
			{
				if ((this._content != value))
				{
					this.OncontentChanging(value);
					this.SendPropertyChanging();
					this._content = value;
					this.SendPropertyChanged("content");
					this.OncontentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh", DbType="VarChar(50)")]
		public string hinh
		{
			get
			{
				return this._hinh;
			}
			set
			{
				if ((this._hinh != value))
				{
					this.OnhinhChanging(value);
					this.SendPropertyChanging();
					this._hinh = value;
					this.SendPropertyChanged("hinh");
					this.OnhinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expected_result", DbType="Int")]
		public System.Nullable<int> expected_result
		{
			get
			{
				return this._expected_result;
			}
			set
			{
				if ((this._expected_result != value))
				{
					this.Onexpected_resultChanging(value);
					this.SendPropertyChanging();
					this._expected_result = value;
					this.SendPropertyChanged("expected_result");
					this.Onexpected_resultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(50)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_date", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> created_date
		{
			get
			{
				return this._created_date;
			}
			set
			{
				if ((this._created_date != value))
				{
					this.Oncreated_dateChanging(value);
					this.SendPropertyChanging();
					this._created_date = value;
					this.SendPropertyChanged("created_date");
					this.Oncreated_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_date", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> end_date
		{
			get
			{
				return this._end_date;
			}
			set
			{
				if ((this._end_date != value))
				{
					this.Onend_dateChanging(value);
					this.SendPropertyChanging();
					this._end_date = value;
					this.SendPropertyChanged("end_date");
					this.Onend_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_full_amount", DbType="Int")]
		public System.Nullable<int> full_amount
		{
			get
			{
				return this._full_amount;
			}
			set
			{
				if ((this._full_amount != value))
				{
					this.Onfull_amountChanging(value);
					this.SendPropertyChanging();
					this._full_amount = value;
					this.SendPropertyChanged("full_amount");
					this.Onfull_amountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai_Fund", Storage="_TheLoai", ThisKey="maloai", OtherKey="maloai", IsForeignKey=true)]
		public TheLoai TheLoai
		{
			get
			{
				return this._TheLoai.Entity;
			}
			set
			{
				TheLoai previousValue = this._TheLoai.Entity;
				if (((previousValue != value) 
							|| (this._TheLoai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TheLoai.Entity = null;
						previousValue.Funds.Remove(this);
					}
					this._TheLoai.Entity = value;
					if ((value != null))
					{
						value.Funds.Add(this);
						this._maloai = value.maloai;
					}
					else
					{
						this._maloai = default(Nullable<int>);
					}
					this.SendPropertyChanged("TheLoai");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Donate_Fund", Storage="_Donate", ThisKey="id", OtherKey="IdDonate", IsForeignKey=true)]
		public Donate Donate
		{
			get
			{
				return this._Donate.Entity;
			}
			set
			{
				Donate previousValue = this._Donate.Entity;
				if (((previousValue != value) 
							|| (this._Donate.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Donate.Entity = null;
						previousValue.Funds.Remove(this);
					}
					this._Donate.Entity = value;
					if ((value != null))
					{
						value.Funds.Add(this);
						this._id = value.IdDonate;
					}
					else
					{
						this._id = default(int);
					}
					this.SendPropertyChanged("Donate");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Fund", Storage="_Account", ThisKey="id", OtherKey="ID", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Funds.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Funds.Add(this);
						this._id = value.ID;
					}
					else
					{
						this._id = default(int);
					}
					this.SendPropertyChanged("Account");
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
}
#pragma warning restore 1591

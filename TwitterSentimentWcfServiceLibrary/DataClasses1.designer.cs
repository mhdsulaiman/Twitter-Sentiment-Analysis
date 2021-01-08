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

namespace TwitterSentimentWcfServiceLibrary
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TwitterSentiment2")]
	public partial class TwitterDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcase(@case instance);
    partial void Updatecase(@case instance);
    partial void Deletecase(@case instance);
    partial void Inserttwit(twit instance);
    partial void Updatetwit(twit instance);
    partial void Deletetwit(twit instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public TwitterDataContext() : 
				base(global::TwitterSentimentWcfServiceLibrary.Properties.Settings.Default.TwitterSentiment2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TwitterDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TwitterDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TwitterDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TwitterDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<@case> cases
		{
			get
			{
				return this.GetTable<@case>();
			}
		}
		
		public System.Data.Linq.Table<twit> twits
		{
			get
			{
				return this.GetTable<twit>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cases")]
	public partial class @case : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _text;
		
		private string _dol;
		
		private int _overall_sentiment;
		
		private EntitySet<twit> _twits;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void OndolChanging(string value);
    partial void OndolChanged();
    partial void Onoverall_sentimentChanging(int value);
    partial void Onoverall_sentimentChanged();
    #endregion
		
		public @case()
		{
			this._twits = new EntitySet<twit>(new Action<twit>(this.attach_twits), new Action<twit>(this.detach_twits));
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
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dol", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string dol
		{
			get
			{
				return this._dol;
			}
			set
			{
				if ((this._dol != value))
				{
					this.OndolChanging(value);
					this.SendPropertyChanging();
					this._dol = value;
					this.SendPropertyChanged("dol");
					this.OndolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_overall_sentiment", DbType="Int NOT NULL")]
		public int overall_sentiment
		{
			get
			{
				return this._overall_sentiment;
			}
			set
			{
				if ((this._overall_sentiment != value))
				{
					this.Onoverall_sentimentChanging(value);
					this.SendPropertyChanging();
					this._overall_sentiment = value;
					this.SendPropertyChanged("overall_sentiment");
					this.Onoverall_sentimentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="case_twit", Storage="_twits", ThisKey="id", OtherKey="case_id")]
		public EntitySet<twit> twits
		{
			get
			{
				return this._twits;
			}
			set
			{
				this._twits.Assign(value);
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
		
		private void attach_twits(twit entity)
		{
			this.SendPropertyChanging();
			entity.@case = this;
		}
		
		private void detach_twits(twit entity)
		{
			this.SendPropertyChanging();
			entity.@case = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.twits")]
	public partial class twit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _text;
		
		private int _user_id;
		
		private int _sentiment;
		
		private string _date;
		
		private System.Nullable<int> _case_id;
		
		private EntityRef<@case> _case;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void OnsentimentChanging(int value);
    partial void OnsentimentChanged();
    partial void OndateChanging(string value);
    partial void OndateChanged();
    partial void Oncase_idChanging(System.Nullable<int> value);
    partial void Oncase_idChanged();
    #endregion
		
		public twit()
		{
			this._case = default(EntityRef<@case>);
			this._user = default(EntityRef<user>);
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
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NChar(70) NOT NULL", CanBeNull=false)]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sentiment", DbType="Int NOT NULL")]
		public int sentiment
		{
			get
			{
				return this._sentiment;
			}
			set
			{
				if ((this._sentiment != value))
				{
					this.OnsentimentChanging(value);
					this.SendPropertyChanging();
					this._sentiment = value;
					this.SendPropertyChanged("sentiment");
					this.OnsentimentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_case_id", DbType="Int")]
		public System.Nullable<int> case_id
		{
			get
			{
				return this._case_id;
			}
			set
			{
				if ((this._case_id != value))
				{
					if (this._case.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncase_idChanging(value);
					this.SendPropertyChanging();
					this._case_id = value;
					this.SendPropertyChanged("case_id");
					this.Oncase_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="case_twit", Storage="_case", ThisKey="case_id", OtherKey="id", IsForeignKey=true)]
		public @case @case
		{
			get
			{
				return this._case.Entity;
			}
			set
			{
				@case previousValue = this._case.Entity;
				if (((previousValue != value) 
							|| (this._case.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._case.Entity = null;
						previousValue.twits.Remove(this);
					}
					this._case.Entity = value;
					if ((value != null))
					{
						value.twits.Add(this);
						this._case_id = value.id;
					}
					else
					{
						this._case_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("@case");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_twit", Storage="_user", ThisKey="user_id", OtherKey="id", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.twits.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.twits.Add(this);
						this._user_id = value.id;
					}
					else
					{
						this._user_id = default(int);
					}
					this.SendPropertyChanged("user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _dob;
		
		private EntitySet<twit> _twits;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void OndobChanging(string value);
    partial void OndobChanged();
    #endregion
		
		public user()
		{
			this._twits = new EntitySet<twit>(new Action<twit>(this.attach_twits), new Action<twit>(this.detach_twits));
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
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this.OndobChanging(value);
					this.SendPropertyChanging();
					this._dob = value;
					this.SendPropertyChanged("dob");
					this.OndobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_twit", Storage="_twits", ThisKey="id", OtherKey="user_id")]
		public EntitySet<twit> twits
		{
			get
			{
				return this._twits;
			}
			set
			{
				this._twits.Assign(value);
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
		
		private void attach_twits(twit entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_twits(twit entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
}
#pragma warning restore 1591

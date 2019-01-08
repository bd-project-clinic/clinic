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

namespace DataLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Clinic")]
	public partial class DataClassesClinicDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPatient(Patient instance);
    partial void UpdatePatient(Patient instance);
    partial void DeletePatient(Patient instance);
    partial void InsertVisit(Visit instance);
    partial void UpdateVisit(Visit instance);
    partial void DeleteVisit(Visit instance);
    partial void InsertDoctor(Doctor instance);
    partial void UpdateDoctor(Doctor instance);
    partial void DeleteDoctor(Doctor instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertLab(Lab instance);
    partial void UpdateLab(Lab instance);
    partial void DeleteLab(Lab instance);
    partial void InsertRegister(Register instance);
    partial void UpdateRegister(Register instance);
    partial void DeleteRegister(Register instance);
    #endregion
		
		public DataClassesClinicDataContext() : 
				base(global::DataLayer.Properties.Settings.Default.Przych_mock_01ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesClinicDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesClinicDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesClinicDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesClinicDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Patient> Patients
		{
			get
			{
				return this.GetTable<Patient>();
			}
		}
		
		public System.Data.Linq.Table<Visit> Visits
		{
			get
			{
				return this.GetTable<Visit>();
			}
		}
		
		public System.Data.Linq.Table<Doctor> Doctors
		{
			get
			{
				return this.GetTable<Doctor>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Lab> Lab
		{
			get
			{
				return this.GetTable<Lab>();
			}
		}
		
		public System.Data.Linq.Table<Register> Register
		{
			get
			{
				return this.GetTable<Register>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Patient")]
	public partial class Patient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Pat;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _PESEL;
		
		private EntitySet<Visit> _Visits;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_PatChanging(int value);
    partial void OnId_PatChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnPESELChanging(string value);
    partial void OnPESELChanged();
    #endregion
		
		public Patient()
		{
			this._Visits = new EntitySet<Visit>(new Action<Visit>(this.attach_Visits), new Action<Visit>(this.detach_Visits));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Pat", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Pat
		{
			get
			{
				return this._Id_Pat;
			}
			set
			{
				if ((this._Id_Pat != value))
				{
					this.OnId_PatChanging(value);
					this.SendPropertyChanging();
					this._Id_Pat = value;
					this.SendPropertyChanged("Id_Pat");
					this.OnId_PatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PESEL", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string PESEL
		{
			get
			{
				return this._PESEL;
			}
			set
			{
				if ((this._PESEL != value))
				{
					this.OnPESELChanging(value);
					this.SendPropertyChanging();
					this._PESEL = value;
					this.SendPropertyChanged("PESEL");
					this.OnPESELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Patient_Visit", Storage="_Visits", ThisKey="Id_Pat", OtherKey="Id_Pat")]
		public EntitySet<Visit> Visits
		{
			get
			{
				return this._Visits;
			}
			set
			{
				this._Visits.Assign(value);
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
		
		private void attach_Visits(Visit entity)
		{
			this.SendPropertyChanging();
			entity.Patient = this;
		}
		
		private void detach_Visits(Visit entity)
		{
			this.SendPropertyChanging();
			entity.Patient = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Visit")]
	public partial class Visit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Vis;
		
		private string _Diagnosis;
		
		private string _Status;
		
		private System.DateTime _DT_Reg;
		
		private string _Description;
		
		private int _Id_Pat;
		
		private System.Nullable<int> _Id_Doc;
		
		private System.Nullable<int> _Id_Reg;
		
		private System.Nullable<System.DateTime> _DT_Complete;
		
		private EntityRef<Patient> _Patient;
		
		private EntityRef<Doctor> _Doctor;
		
		private EntityRef<Register> _Register;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_VisChanging(int value);
    partial void OnId_VisChanged();
    partial void OnDiagnosisChanging(string value);
    partial void OnDiagnosisChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnDT_RegChanging(System.DateTime value);
    partial void OnDT_RegChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnId_PatChanging(int value);
    partial void OnId_PatChanged();
    partial void OnId_DocChanging(System.Nullable<int> value);
    partial void OnId_DocChanged();
    partial void OnId_RegChanging(System.Nullable<int> value);
    partial void OnId_RegChanged();
    partial void OnDT_CompleteChanging(System.Nullable<System.DateTime> value);
    partial void OnDT_CompleteChanged();
    #endregion
		
		public Visit()
		{
			this._Patient = default(EntityRef<Patient>);
			this._Doctor = default(EntityRef<Doctor>);
			this._Register = default(EntityRef<Register>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Vis", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Vis
		{
			get
			{
				return this._Id_Vis;
			}
			set
			{
				if ((this._Id_Vis != value))
				{
					this.OnId_VisChanging(value);
					this.SendPropertyChanging();
					this._Id_Vis = value;
					this.SendPropertyChanged("Id_Vis");
					this.OnId_VisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diagnosis", DbType="NVarChar(1000)")]
		public string Diagnosis
		{
			get
			{
				return this._Diagnosis;
			}
			set
			{
				if ((this._Diagnosis != value))
				{
					this.OnDiagnosisChanging(value);
					this.SendPropertyChanging();
					this._Diagnosis = value;
					this.SendPropertyChanged("Diagnosis");
					this.OnDiagnosisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DT_Reg", DbType="DateTime NOT NULL")]
		public System.DateTime DT_Reg
		{
			get
			{
				return this._DT_Reg;
			}
			set
			{
				if ((this._DT_Reg != value))
				{
					this.OnDT_RegChanging(value);
					this.SendPropertyChanging();
					this._DT_Reg = value;
					this.SendPropertyChanged("DT_Reg");
					this.OnDT_RegChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Pat", DbType="Int NOT NULL")]
		public int Id_Pat
		{
			get
			{
				return this._Id_Pat;
			}
			set
			{
				if ((this._Id_Pat != value))
				{
					if (this._Patient.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_PatChanging(value);
					this.SendPropertyChanging();
					this._Id_Pat = value;
					this.SendPropertyChanged("Id_Pat");
					this.OnId_PatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Doc", DbType="Int")]
		public System.Nullable<int> Id_Doc
		{
			get
			{
				return this._Id_Doc;
			}
			set
			{
				if ((this._Id_Doc != value))
				{
					if (this._Doctor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_DocChanging(value);
					this.SendPropertyChanging();
					this._Id_Doc = value;
					this.SendPropertyChanged("Id_Doc");
					this.OnId_DocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Reg", DbType="Int")]
		public System.Nullable<int> Id_Reg
		{
			get
			{
				return this._Id_Reg;
			}
			set
			{
				if ((this._Id_Reg != value))
				{
					if (this._Register.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_RegChanging(value);
					this.SendPropertyChanging();
					this._Id_Reg = value;
					this.SendPropertyChanged("Id_Reg");
					this.OnId_RegChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DT_Complete", DbType="DateTime")]
		public System.Nullable<System.DateTime> DT_Complete
		{
			get
			{
				return this._DT_Complete;
			}
			set
			{
				if ((this._DT_Complete != value))
				{
					this.OnDT_CompleteChanging(value);
					this.SendPropertyChanging();
					this._DT_Complete = value;
					this.SendPropertyChanged("DT_Complete");
					this.OnDT_CompleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Patient_Visit", Storage="_Patient", ThisKey="Id_Pat", OtherKey="Id_Pat", IsForeignKey=true)]
		public Patient Patient
		{
			get
			{
				return this._Patient.Entity;
			}
			set
			{
				Patient previousValue = this._Patient.Entity;
				if (((previousValue != value) 
							|| (this._Patient.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Patient.Entity = null;
						previousValue.Visits.Remove(this);
					}
					this._Patient.Entity = value;
					if ((value != null))
					{
						value.Visits.Add(this);
						this._Id_Pat = value.Id_Pat;
					}
					else
					{
						this._Id_Pat = default(int);
					}
					this.SendPropertyChanged("Patient");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_Visit", Storage="_Doctor", ThisKey="Id_Doc", OtherKey="Id_Doc", IsForeignKey=true)]
		public Doctor Doctor
		{
			get
			{
				return this._Doctor.Entity;
			}
			set
			{
				Doctor previousValue = this._Doctor.Entity;
				if (((previousValue != value) 
							|| (this._Doctor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Doctor.Entity = null;
						previousValue.Visits.Remove(this);
					}
					this._Doctor.Entity = value;
					if ((value != null))
					{
						value.Visits.Add(this);
						this._Id_Doc = value.Id_Doc;
					}
					else
					{
						this._Id_Doc = default(Nullable<int>);
					}
					this.SendPropertyChanged("Doctor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Register_Visit", Storage="_Register", ThisKey="Id_Reg", OtherKey="Id_Reg", IsForeignKey=true)]
		public Register Register
		{
			get
			{
				return this._Register.Entity;
			}
			set
			{
				Register previousValue = this._Register.Entity;
				if (((previousValue != value) 
							|| (this._Register.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Register.Entity = null;
						previousValue.Visit.Remove(this);
					}
					this._Register.Entity = value;
					if ((value != null))
					{
						value.Visit.Add(this);
						this._Id_Reg = value.Id_Reg;
					}
					else
					{
						this._Id_Reg = default(Nullable<int>);
					}
					this.SendPropertyChanged("Register");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Doctor")]
	public partial class Doctor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Doc;
		
		private string _Name;
		
		private string _Surname;
		
		private string _NPWZ;
		
		private string _uname;
		
		private EntitySet<Visit> _Visits;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_DocChanging(int value);
    partial void OnId_DocChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnNPWZChanging(string value);
    partial void OnNPWZChanged();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    #endregion
		
		public Doctor()
		{
			this._Visits = new EntitySet<Visit>(new Action<Visit>(this.attach_Visits), new Action<Visit>(this.detach_Visits));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Doc", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Doc
		{
			get
			{
				return this._Id_Doc;
			}
			set
			{
				if ((this._Id_Doc != value))
				{
					this.OnId_DocChanging(value);
					this.SendPropertyChanging();
					this._Id_Doc = value;
					this.SendPropertyChanged("Id_Doc");
					this.OnId_DocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NPWZ", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string NPWZ
		{
			get
			{
				return this._NPWZ;
			}
			set
			{
				if ((this._NPWZ != value))
				{
					this.OnNPWZChanging(value);
					this.SendPropertyChanging();
					this._NPWZ = value;
					this.SendPropertyChanged("NPWZ");
					this.OnNPWZChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_Visit", Storage="_Visits", ThisKey="Id_Doc", OtherKey="Id_Doc")]
		public EntitySet<Visit> Visits
		{
			get
			{
				return this._Visits;
			}
			set
			{
				this._Visits.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Doctor", Storage="_User", ThisKey="uname", OtherKey="uname", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Doctors.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Doctors.Add(this);
						this._uname = value.uname;
					}
					else
					{
						this._uname = default(string);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_Visits(Visit entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = this;
		}
		
		private void detach_Visits(Visit entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _uname;
		
		private string _pass;
		
		private System.Nullable<System.DateTime> _DT_retire;
		
		private string _role;
		
		private EntitySet<Doctor> _Doctors;
		
		private EntitySet<Lab> _Lab;
		
		private EntitySet<Register> _Register;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnDT_retireChanging(System.Nullable<System.DateTime> value);
    partial void OnDT_retireChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    #endregion
		
		public User()
		{
			this._Doctors = new EntitySet<Doctor>(new Action<Doctor>(this.attach_Doctors), new Action<Doctor>(this.detach_Doctors));
			this._Lab = new EntitySet<Lab>(new Action<Lab>(this.attach_Lab), new Action<Lab>(this.detach_Lab));
			this._Register = new EntitySet<Register>(new Action<Register>(this.attach_Register), new Action<Register>(this.detach_Register));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DT_retire", DbType="DateTime")]
		public System.Nullable<System.DateTime> DT_retire
		{
			get
			{
				return this._DT_retire;
			}
			set
			{
				if ((this._DT_retire != value))
				{
					this.OnDT_retireChanging(value);
					this.SendPropertyChanging();
					this._DT_retire = value;
					this.SendPropertyChanged("DT_retire");
					this.OnDT_retireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Doctor", Storage="_Doctors", ThisKey="uname", OtherKey="uname")]
		public EntitySet<Doctor> Doctors
		{
			get
			{
				return this._Doctors;
			}
			set
			{
				this._Doctors.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Lab", Storage="_Lab", ThisKey="uname", OtherKey="uname")]
		public EntitySet<Lab> Lab
		{
			get
			{
				return this._Lab;
			}
			set
			{
				this._Lab.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Register", Storage="_Register", ThisKey="uname", OtherKey="uname")]
		public EntitySet<Register> Register
		{
			get
			{
				return this._Register;
			}
			set
			{
				this._Register.Assign(value);
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
		
		private void attach_Doctors(Doctor entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Doctors(Doctor entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Lab(Lab entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Lab(Lab entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Register(Register entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Register(Register entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lab")]
	public partial class Lab : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Lab;
		
		private string _Surname;
		
		private string _Name;
		
		private string _uname;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_LabChanging(int value);
    partial void OnId_LabChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    #endregion
		
		public Lab()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Lab", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Lab
		{
			get
			{
				return this._Id_Lab;
			}
			set
			{
				if ((this._Id_Lab != value))
				{
					this.OnId_LabChanging(value);
					this.SendPropertyChanging();
					this._Id_Lab = value;
					this.SendPropertyChanged("Id_Lab");
					this.OnId_LabChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Lab", Storage="_User", ThisKey="uname", OtherKey="uname", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Lab.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Lab.Add(this);
						this._uname = value.uname;
					}
					else
					{
						this._uname = default(string);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Register")]
	public partial class Register : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Reg;
		
		private string _Name;
		
		private string _Surname;
		
		private string _uname;
		
		private EntitySet<Visit> _Visit;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_RegChanging(int value);
    partial void OnId_RegChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    #endregion
		
		public Register()
		{
			this._Visit = new EntitySet<Visit>(new Action<Visit>(this.attach_Visit), new Action<Visit>(this.detach_Visit));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Reg", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Reg
		{
			get
			{
				return this._Id_Reg;
			}
			set
			{
				if ((this._Id_Reg != value))
				{
					this.OnId_RegChanging(value);
					this.SendPropertyChanging();
					this._Id_Reg = value;
					this.SendPropertyChanged("Id_Reg");
					this.OnId_RegChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Register_Visit", Storage="_Visit", ThisKey="Id_Reg", OtherKey="Id_Reg")]
		public EntitySet<Visit> Visit
		{
			get
			{
				return this._Visit;
			}
			set
			{
				this._Visit.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Register", Storage="_User", ThisKey="uname", OtherKey="uname", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Register.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Register.Add(this);
						this._uname = value.uname;
					}
					else
					{
						this._uname = default(string);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_Visit(Visit entity)
		{
			this.SendPropertyChanging();
			entity.Register = this;
		}
		
		private void detach_Visit(Visit entity)
		{
			this.SendPropertyChanging();
			entity.Register = null;
		}
	}
}
#pragma warning restore 1591

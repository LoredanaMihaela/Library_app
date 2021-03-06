#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Library.Models.DbObjects
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibrarySchool")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertBorrowedBook(BorrowedBook instance);
    partial void UpdateBorrowedBook(BorrowedBook instance);
    partial void DeleteBorrowedBook(BorrowedBook instance);
    partial void InsertBorrowedOnlineBook(BorrowedOnlineBook instance);
    partial void UpdateBorrowedOnlineBook(BorrowedOnlineBook instance);
    partial void DeleteBorrowedOnlineBook(BorrowedOnlineBook instance);
    partial void InsertOnlineBook(OnlineBook instance);
    partial void UpdateOnlineBook(OnlineBook instance);
    partial void DeleteOnlineBook(OnlineBook instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LibrarySchoolConnectionString"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<BorrowedBook> BorrowedBooks
		{
			get
			{
				return this.GetTable<BorrowedBook>();
			}
		}
		
		public System.Data.Linq.Table<BorrowedOnlineBook> BorrowedOnlineBooks
		{
			get
			{
				return this.GetTable<BorrowedOnlineBook>();
			}
		}
		
		public System.Data.Linq.Table<OnlineBook> OnlineBooks
		{
			get
			{
				return this.GetTable<OnlineBook>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdBook;
		
		private string _Name;
		
		private string _Author;
		
		private string _Field;
		
		private string _Description;
		
		private int _NumberOfBooks;
		
		private int _NumbeOfBooksAvaible;
		
		private EntitySet<BorrowedBook> _BorrowedBooks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdBookChanging(System.Guid value);
    partial void OnIdBookChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnFieldChanging(string value);
    partial void OnFieldChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnNumberOfBooksChanging(int value);
    partial void OnNumberOfBooksChanged();
    partial void OnNumbeOfBooksAvaibleChanging(int value);
    partial void OnNumbeOfBooksAvaibleChanged();
    #endregion
		
		public Book()
		{
			this._BorrowedBooks = new EntitySet<BorrowedBook>(new Action<BorrowedBook>(this.attach_BorrowedBooks), new Action<BorrowedBook>(this.detach_BorrowedBooks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBook", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdBook
		{
			get
			{
				return this._IdBook;
			}
			set
			{
				if ((this._IdBook != value))
				{
					this.OnIdBookChanging(value);
					this.SendPropertyChanging();
					this._IdBook = value;
					this.SendPropertyChanged("IdBook");
					this.OnIdBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Field", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Field
		{
			get
			{
				return this._Field;
			}
			set
			{
				if ((this._Field != value))
				{
					this.OnFieldChanging(value);
					this.SendPropertyChanging();
					this._Field = value;
					this.SendPropertyChanged("Field");
					this.OnFieldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(2000)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfBooks", DbType="Int NOT NULL")]
		public int NumberOfBooks
		{
			get
			{
				return this._NumberOfBooks;
			}
			set
			{
				if ((this._NumberOfBooks != value))
				{
					this.OnNumberOfBooksChanging(value);
					this.SendPropertyChanging();
					this._NumberOfBooks = value;
					this.SendPropertyChanged("NumberOfBooks");
					this.OnNumberOfBooksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumbeOfBooksAvaible", DbType="Int NOT NULL")]
		public int NumbeOfBooksAvaible
		{
			get
			{
				return this._NumbeOfBooksAvaible;
			}
			set
			{
				if ((this._NumbeOfBooksAvaible != value))
				{
					this.OnNumbeOfBooksAvaibleChanging(value);
					this.SendPropertyChanging();
					this._NumbeOfBooksAvaible = value;
					this.SendPropertyChanged("NumbeOfBooksAvaible");
					this.OnNumbeOfBooksAvaibleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_BorrowedBook", Storage="_BorrowedBooks", ThisKey="IdBook", OtherKey="IdBook")]
		public EntitySet<BorrowedBook> BorrowedBooks
		{
			get
			{
				return this._BorrowedBooks;
			}
			set
			{
				this._BorrowedBooks.Assign(value);
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
		
		private void attach_BorrowedBooks(BorrowedBook entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_BorrowedBooks(BorrowedBook entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdUser;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.DateTime _RegistrationDate;
		
		private string _PhoneNr;
		
		private string _Email;
		
		private string _Adress;
		
		private EntitySet<BorrowedBook> _BorrowedBooks;
		
		private EntitySet<BorrowedOnlineBook> _BorrowedOnlineBooks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdUserChanging(System.Guid value);
    partial void OnIdUserChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnRegistrationDateChanging(System.DateTime value);
    partial void OnRegistrationDateChanged();
    partial void OnPhoneNrChanging(string value);
    partial void OnPhoneNrChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    #endregion
		
		public User()
		{
			this._BorrowedBooks = new EntitySet<BorrowedBook>(new Action<BorrowedBook>(this.attach_BorrowedBooks), new Action<BorrowedBook>(this.detach_BorrowedBooks));
			this._BorrowedOnlineBooks = new EntitySet<BorrowedOnlineBook>(new Action<BorrowedOnlineBook>(this.attach_BorrowedOnlineBooks), new Action<BorrowedOnlineBook>(this.detach_BorrowedOnlineBooks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationDate", DbType="DateTime NOT NULL")]
		public System.DateTime RegistrationDate
		{
			get
			{
				return this._RegistrationDate;
			}
			set
			{
				if ((this._RegistrationDate != value))
				{
					this.OnRegistrationDateChanging(value);
					this.SendPropertyChanging();
					this._RegistrationDate = value;
					this.SendPropertyChanged("RegistrationDate");
					this.OnRegistrationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNr", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string PhoneNr
		{
			get
			{
				return this._PhoneNr;
			}
			set
			{
				if ((this._PhoneNr != value))
				{
					this.OnPhoneNrChanging(value);
					this.SendPropertyChanging();
					this._PhoneNr = value;
					this.SendPropertyChanged("PhoneNr");
					this.OnPhoneNrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_BorrowedBook", Storage="_BorrowedBooks", ThisKey="IdUser", OtherKey="IdUser")]
		public EntitySet<BorrowedBook> BorrowedBooks
		{
			get
			{
				return this._BorrowedBooks;
			}
			set
			{
				this._BorrowedBooks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_BorrowedOnlineBook", Storage="_BorrowedOnlineBooks", ThisKey="IdUser", OtherKey="IdUser")]
		public EntitySet<BorrowedOnlineBook> BorrowedOnlineBooks
		{
			get
			{
				return this._BorrowedOnlineBooks;
			}
			set
			{
				this._BorrowedOnlineBooks.Assign(value);
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
		
		private void attach_BorrowedBooks(BorrowedBook entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_BorrowedBooks(BorrowedBook entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_BorrowedOnlineBooks(BorrowedOnlineBook entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_BorrowedOnlineBooks(BorrowedOnlineBook entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BorrowedBooks")]
	public partial class BorrowedBook : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdBorrowedBook;
		
		private System.Guid _IdBook;
		
		private System.Guid _IdUser;
		
		private System.DateTime _ValildFrom;
		
		private System.DateTime _ValidTo;
		
		private bool _IsReturned;
		
		private EntityRef<Book> _Book;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdBorrowedBookChanging(System.Guid value);
    partial void OnIdBorrowedBookChanged();
    partial void OnIdBookChanging(System.Guid value);
    partial void OnIdBookChanged();
    partial void OnIdUserChanging(System.Guid value);
    partial void OnIdUserChanged();
    partial void OnValildFromChanging(System.DateTime value);
    partial void OnValildFromChanged();
    partial void OnValidToChanging(System.DateTime value);
    partial void OnValidToChanged();
    partial void OnIsReturnedChanging(bool value);
    partial void OnIsReturnedChanged();
    #endregion
		
		public BorrowedBook()
		{
			this._Book = default(EntityRef<Book>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBorrowedBook", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdBorrowedBook
		{
			get
			{
				return this._IdBorrowedBook;
			}
			set
			{
				if ((this._IdBorrowedBook != value))
				{
					this.OnIdBorrowedBookChanging(value);
					this.SendPropertyChanging();
					this._IdBorrowedBook = value;
					this.SendPropertyChanged("IdBorrowedBook");
					this.OnIdBorrowedBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBook", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdBook
		{
			get
			{
				return this._IdBook;
			}
			set
			{
				if ((this._IdBook != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdBookChanging(value);
					this.SendPropertyChanging();
					this._IdBook = value;
					this.SendPropertyChanged("IdBook");
					this.OnIdBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValildFrom", DbType="DateTime NOT NULL")]
		public System.DateTime ValildFrom
		{
			get
			{
				return this._ValildFrom;
			}
			set
			{
				if ((this._ValildFrom != value))
				{
					this.OnValildFromChanging(value);
					this.SendPropertyChanging();
					this._ValildFrom = value;
					this.SendPropertyChanged("ValildFrom");
					this.OnValildFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidTo", DbType="DateTime NOT NULL")]
		public System.DateTime ValidTo
		{
			get
			{
				return this._ValidTo;
			}
			set
			{
				if ((this._ValidTo != value))
				{
					this.OnValidToChanging(value);
					this.SendPropertyChanging();
					this._ValidTo = value;
					this.SendPropertyChanged("ValidTo");
					this.OnValidToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsReturned", DbType="Bit NOT NULL")]
		public bool IsReturned
		{
			get
			{
				return this._IsReturned;
			}
			set
			{
				if ((this._IsReturned != value))
				{
					this.OnIsReturnedChanging(value);
					this.SendPropertyChanging();
					this._IsReturned = value;
					this.SendPropertyChanged("IsReturned");
					this.OnIsReturnedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_BorrowedBook", Storage="_Book", ThisKey="IdBook", OtherKey="IdBook", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.BorrowedBooks.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.BorrowedBooks.Add(this);
						this._IdBook = value.IdBook;
					}
					else
					{
						this._IdBook = default(System.Guid);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_BorrowedBook", Storage="_User", ThisKey="IdUser", OtherKey="IdUser", IsForeignKey=true)]
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
						previousValue.BorrowedBooks.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.BorrowedBooks.Add(this);
						this._IdUser = value.IdUser;
					}
					else
					{
						this._IdUser = default(System.Guid);
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BorrowedOnlineBooks")]
	public partial class BorrowedOnlineBook : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdBorrowedOnlineBook;
		
		private System.Guid _IdOnlineBook;
		
		private System.Guid _IdUser;
		
		private System.DateTime _ValildFrom;
		
		private System.DateTime _ValidTo;
		
		private bool _IsAvable;
		
		private EntityRef<User> _User;
		
		private EntityRef<OnlineBook> _OnlineBook;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdBorrowedOnlineBookChanging(System.Guid value);
    partial void OnIdBorrowedOnlineBookChanged();
    partial void OnIdOnlineBookChanging(System.Guid value);
    partial void OnIdOnlineBookChanged();
    partial void OnIdUserChanging(System.Guid value);
    partial void OnIdUserChanged();
    partial void OnValildFromChanging(System.DateTime value);
    partial void OnValildFromChanged();
    partial void OnValidToChanging(System.DateTime value);
    partial void OnValidToChanged();
    partial void OnIsAvableChanging(bool value);
    partial void OnIsAvableChanged();
    #endregion
		
		public BorrowedOnlineBook()
		{
			this._User = default(EntityRef<User>);
			this._OnlineBook = default(EntityRef<OnlineBook>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBorrowedOnlineBook", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdBorrowedOnlineBook
		{
			get
			{
				return this._IdBorrowedOnlineBook;
			}
			set
			{
				if ((this._IdBorrowedOnlineBook != value))
				{
					this.OnIdBorrowedOnlineBookChanging(value);
					this.SendPropertyChanging();
					this._IdBorrowedOnlineBook = value;
					this.SendPropertyChanged("IdBorrowedOnlineBook");
					this.OnIdBorrowedOnlineBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdOnlineBook", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdOnlineBook
		{
			get
			{
				return this._IdOnlineBook;
			}
			set
			{
				if ((this._IdOnlineBook != value))
				{
					if (this._OnlineBook.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdOnlineBookChanging(value);
					this.SendPropertyChanging();
					this._IdOnlineBook = value;
					this.SendPropertyChanged("IdOnlineBook");
					this.OnIdOnlineBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValildFrom", DbType="DateTime NOT NULL")]
		public System.DateTime ValildFrom
		{
			get
			{
				return this._ValildFrom;
			}
			set
			{
				if ((this._ValildFrom != value))
				{
					this.OnValildFromChanging(value);
					this.SendPropertyChanging();
					this._ValildFrom = value;
					this.SendPropertyChanged("ValildFrom");
					this.OnValildFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidTo", DbType="DateTime NOT NULL")]
		public System.DateTime ValidTo
		{
			get
			{
				return this._ValidTo;
			}
			set
			{
				if ((this._ValidTo != value))
				{
					this.OnValidToChanging(value);
					this.SendPropertyChanging();
					this._ValidTo = value;
					this.SendPropertyChanged("ValidTo");
					this.OnValidToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAvable", DbType="Bit NOT NULL")]
		public bool IsAvable
		{
			get
			{
				return this._IsAvable;
			}
			set
			{
				if ((this._IsAvable != value))
				{
					this.OnIsAvableChanging(value);
					this.SendPropertyChanging();
					this._IsAvable = value;
					this.SendPropertyChanged("IsAvable");
					this.OnIsAvableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_BorrowedOnlineBook", Storage="_User", ThisKey="IdUser", OtherKey="IdUser", IsForeignKey=true)]
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
						previousValue.BorrowedOnlineBooks.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.BorrowedOnlineBooks.Add(this);
						this._IdUser = value.IdUser;
					}
					else
					{
						this._IdUser = default(System.Guid);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OnlineBook_BorrowedOnlineBook", Storage="_OnlineBook", ThisKey="IdOnlineBook", OtherKey="IdOnlineBook", IsForeignKey=true)]
		public OnlineBook OnlineBook
		{
			get
			{
				return this._OnlineBook.Entity;
			}
			set
			{
				OnlineBook previousValue = this._OnlineBook.Entity;
				if (((previousValue != value) 
							|| (this._OnlineBook.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._OnlineBook.Entity = null;
						previousValue.BorrowedOnlineBooks.Remove(this);
					}
					this._OnlineBook.Entity = value;
					if ((value != null))
					{
						value.BorrowedOnlineBooks.Add(this);
						this._IdOnlineBook = value.IdOnlineBook;
					}
					else
					{
						this._IdOnlineBook = default(System.Guid);
					}
					this.SendPropertyChanged("OnlineBook");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OnlineBooks")]
	public partial class OnlineBook : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdOnlineBook;
		
		private string _Name;
		
		private string _Author;
		
		private string _Field;
		
		private string _Description;
		
		private bool _IsAvaible;
		
		private EntitySet<BorrowedOnlineBook> _BorrowedOnlineBooks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdOnlineBookChanging(System.Guid value);
    partial void OnIdOnlineBookChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnFieldChanging(string value);
    partial void OnFieldChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnIsAvaibleChanging(bool value);
    partial void OnIsAvaibleChanged();
    #endregion
		
		public OnlineBook()
		{
			this._BorrowedOnlineBooks = new EntitySet<BorrowedOnlineBook>(new Action<BorrowedOnlineBook>(this.attach_BorrowedOnlineBooks), new Action<BorrowedOnlineBook>(this.detach_BorrowedOnlineBooks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdOnlineBook", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdOnlineBook
		{
			get
			{
				return this._IdOnlineBook;
			}
			set
			{
				if ((this._IdOnlineBook != value))
				{
					this.OnIdOnlineBookChanging(value);
					this.SendPropertyChanging();
					this._IdOnlineBook = value;
					this.SendPropertyChanged("IdOnlineBook");
					this.OnIdOnlineBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Field", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Field
		{
			get
			{
				return this._Field;
			}
			set
			{
				if ((this._Field != value))
				{
					this.OnFieldChanging(value);
					this.SendPropertyChanging();
					this._Field = value;
					this.SendPropertyChanged("Field");
					this.OnFieldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(2000)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAvaible", DbType="Bit NOT NULL")]
		public bool IsAvaible
		{
			get
			{
				return this._IsAvaible;
			}
			set
			{
				if ((this._IsAvaible != value))
				{
					this.OnIsAvaibleChanging(value);
					this.SendPropertyChanging();
					this._IsAvaible = value;
					this.SendPropertyChanged("IsAvaible");
					this.OnIsAvaibleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OnlineBook_BorrowedOnlineBook", Storage="_BorrowedOnlineBooks", ThisKey="IdOnlineBook", OtherKey="IdOnlineBook")]
		public EntitySet<BorrowedOnlineBook> BorrowedOnlineBooks
		{
			get
			{
				return this._BorrowedOnlineBooks;
			}
			set
			{
				this._BorrowedOnlineBooks.Assign(value);
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
		
		private void attach_BorrowedOnlineBooks(BorrowedOnlineBook entity)
		{
			this.SendPropertyChanging();
			entity.OnlineBook = this;
		}
		
		private void detach_BorrowedOnlineBooks(BorrowedOnlineBook entity)
		{
			this.SendPropertyChanging();
			entity.OnlineBook = null;
		}
	}
}
#pragma warning restore 1591

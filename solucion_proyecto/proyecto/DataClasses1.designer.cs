﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="proyecto")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertusuarios(usuarios instance);
    partial void Updateusuarios(usuarios instance);
    partial void Deleteusuarios(usuarios instance);
    partial void Insertrecambios(recambios instance);
    partial void Updaterecambios(recambios instance);
    partial void Deleterecambios(recambios instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::proyecto.Properties.Settings.Default.proyectoConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<usuarios> usuarios
		{
			get
			{
				return this.GetTable<usuarios>();
			}
		}
		
		public System.Data.Linq.Table<clientes> clientes
		{
			get
			{
				return this.GetTable<clientes>();
			}
		}
		
		public System.Data.Linq.Table<pedidos> pedidos
		{
			get
			{
				return this.GetTable<pedidos>();
			}
		}
		
		public System.Data.Linq.Table<recambios> recambios
		{
			get
			{
				return this.GetTable<recambios>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuarios")]
	public partial class usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _usuario;
		
		private string _contrasena;
		
		private System.Nullable<bool> _administrador;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusuarioChanging(string value);
    partial void OnusuarioChanged();
    partial void OncontrasenaChanging(string value);
    partial void OncontrasenaChanged();
    partial void OnadministradorChanging(System.Nullable<bool> value);
    partial void OnadministradorChanged();
    #endregion
		
		public usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this.OnusuarioChanging(value);
					this.SendPropertyChanging();
					this._usuario = value;
					this.SendPropertyChanged("usuario");
					this.OnusuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasena", DbType="VarChar(30)")]
		public string contrasena
		{
			get
			{
				return this._contrasena;
			}
			set
			{
				if ((this._contrasena != value))
				{
					this.OncontrasenaChanging(value);
					this.SendPropertyChanging();
					this._contrasena = value;
					this.SendPropertyChanged("contrasena");
					this.OncontrasenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_administrador", DbType="Bit")]
		public System.Nullable<bool> administrador
		{
			get
			{
				return this._administrador;
			}
			set
			{
				if ((this._administrador != value))
				{
					this.OnadministradorChanging(value);
					this.SendPropertyChanging();
					this._administrador = value;
					this.SendPropertyChanged("administrador");
					this.OnadministradorChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.clientes")]
	public partial class clientes
	{
		
		private System.Nullable<int> _id_cliente;
		
		private string _nombre;
		
		private string _primerapellido;
		
		private string _segundoapellido;
		
		public clientes()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cliente", DbType="Int")]
		public System.Nullable<int> id_cliente
		{
			get
			{
				return this._id_cliente;
			}
			set
			{
				if ((this._id_cliente != value))
				{
					this._id_cliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(39)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_primerapellido", DbType="VarChar(39)")]
		public string primerapellido
		{
			get
			{
				return this._primerapellido;
			}
			set
			{
				if ((this._primerapellido != value))
				{
					this._primerapellido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_segundoapellido", DbType="VarChar(39)")]
		public string segundoapellido
		{
			get
			{
				return this._segundoapellido;
			}
			set
			{
				if ((this._segundoapellido != value))
				{
					this._segundoapellido = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pedidos")]
	public partial class pedidos
	{
		
		private System.Nullable<int> _id_pedido;
		
		private System.Nullable<int> _id_cliente;
		
		private System.Nullable<int> _total_pedido;
		
		private System.Nullable<System.DateTime> _fecha;
		
		public pedidos()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pedido", DbType="Int")]
		public System.Nullable<int> id_pedido
		{
			get
			{
				return this._id_pedido;
			}
			set
			{
				if ((this._id_pedido != value))
				{
					this._id_pedido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cliente", DbType="Int")]
		public System.Nullable<int> id_cliente
		{
			get
			{
				return this._id_cliente;
			}
			set
			{
				if ((this._id_cliente != value))
				{
					this._id_cliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_pedido", DbType="Int")]
		public System.Nullable<int> total_pedido
		{
			get
			{
				return this._total_pedido;
			}
			set
			{
				if ((this._total_pedido != value))
				{
					this._total_pedido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="Date")]
		public System.Nullable<System.DateTime> fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this._fecha = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.recambios")]
	public partial class recambios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _producto;
		
		private System.Nullable<double> _precio;
		
		private System.Nullable<int> _unidades;
		
		private string _caracteristicas;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnproductoChanging(string value);
    partial void OnproductoChanged();
    partial void OnprecioChanging(System.Nullable<double> value);
    partial void OnprecioChanged();
    partial void OnunidadesChanging(System.Nullable<int> value);
    partial void OnunidadesChanged();
    partial void OncaracteristicasChanging(string value);
    partial void OncaracteristicasChanged();
    #endregion
		
		public recambios()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producto", DbType="VarChar(30)")]
		public string producto
		{
			get
			{
				return this._producto;
			}
			set
			{
				if ((this._producto != value))
				{
					this.OnproductoChanging(value);
					this.SendPropertyChanging();
					this._producto = value;
					this.SendPropertyChanged("producto");
					this.OnproductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Float")]
		public System.Nullable<double> precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this.OnprecioChanging(value);
					this.SendPropertyChanging();
					this._precio = value;
					this.SendPropertyChanged("precio");
					this.OnprecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unidades", DbType="Int")]
		public System.Nullable<int> unidades
		{
			get
			{
				return this._unidades;
			}
			set
			{
				if ((this._unidades != value))
				{
					this.OnunidadesChanging(value);
					this.SendPropertyChanging();
					this._unidades = value;
					this.SendPropertyChanged("unidades");
					this.OnunidadesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_caracteristicas", DbType="VarChar(49)")]
		public string caracteristicas
		{
			get
			{
				return this._caracteristicas;
			}
			set
			{
				if ((this._caracteristicas != value))
				{
					this.OncaracteristicasChanging(value);
					this.SendPropertyChanging();
					this._caracteristicas = value;
					this.SendPropertyChanged("caracteristicas");
					this.OncaracteristicasChanged();
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

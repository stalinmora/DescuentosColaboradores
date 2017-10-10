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

namespace com.sweetcoffee.LogicaData
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBFREST")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertTRASPALMACEN(TRASPALMACEN instance);
    partial void UpdateTRASPALMACEN(TRASPALMACEN instance);
    partial void DeleteTRASPALMACEN(TRASPALMACEN instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::com.sweetcoffee.Properties.Settings.Default.DBFRESTConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<TRASPALMACEN> TRASPALMACEN
		{
			get
			{
				return this.GetTable<TRASPALMACEN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TRASPALMACEN")]
	public partial class TRASPALMACEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _SERIE;
		
		private int _NUMERO;
		
		private int _LINEA;
		
		private string _CODALMORIG;
		
		private string _CODALMDEST;
		
		private System.Nullable<System.DateTime> _FECHA;
		
		private System.Nullable<int> _CODARTICULO;
		
		private string _REFERENCIA;
		
		private string _DESCRIPCION;
		
		private System.Nullable<double> _UNIDADES;
		
		private System.Nullable<double> _PRECIO;
		
		private System.Nullable<int> _USUARIO;
		
		private System.Nullable<int> _CAJA;
		
		private System.Nullable<int> _Z;
		
		private System.Nullable<double> _STOCK;
		
		private System.Nullable<char> _DESCARGADO;
		
		private System.Nullable<System.DateTime> _FECHACREACION;
		
		private System.Nullable<int> _IMPRESIONES;
		
		private System.Nullable<bool> _ESRECUENTO;
		
		private string _OBSERVACIONES;
		
		private System.Nullable<int> _IDMOTIVO;
		
		private string _DESCMOTIVO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSERIEChanging(string value);
    partial void OnSERIEChanged();
    partial void OnNUMEROChanging(int value);
    partial void OnNUMEROChanged();
    partial void OnLINEAChanging(int value);
    partial void OnLINEAChanged();
    partial void OnCODALMORIGChanging(string value);
    partial void OnCODALMORIGChanged();
    partial void OnCODALMDESTChanging(string value);
    partial void OnCODALMDESTChanged();
    partial void OnFECHAChanging(System.Nullable<System.DateTime> value);
    partial void OnFECHAChanged();
    partial void OnCODARTICULOChanging(System.Nullable<int> value);
    partial void OnCODARTICULOChanged();
    partial void OnREFERENCIAChanging(string value);
    partial void OnREFERENCIAChanged();
    partial void OnDESCRIPCIONChanging(string value);
    partial void OnDESCRIPCIONChanged();
    partial void OnUNIDADESChanging(System.Nullable<double> value);
    partial void OnUNIDADESChanged();
    partial void OnPRECIOChanging(System.Nullable<double> value);
    partial void OnPRECIOChanged();
    partial void OnUSUARIOChanging(System.Nullable<int> value);
    partial void OnUSUARIOChanged();
    partial void OnCAJAChanging(System.Nullable<int> value);
    partial void OnCAJAChanged();
    partial void OnZChanging(System.Nullable<int> value);
    partial void OnZChanged();
    partial void OnSTOCKChanging(System.Nullable<double> value);
    partial void OnSTOCKChanged();
    partial void OnDESCARGADOChanging(System.Nullable<char> value);
    partial void OnDESCARGADOChanged();
    partial void OnFECHACREACIONChanging(System.Nullable<System.DateTime> value);
    partial void OnFECHACREACIONChanged();
    partial void OnIMPRESIONESChanging(System.Nullable<int> value);
    partial void OnIMPRESIONESChanged();
    partial void OnESRECUENTOChanging(System.Nullable<bool> value);
    partial void OnESRECUENTOChanged();
    partial void OnOBSERVACIONESChanging(string value);
    partial void OnOBSERVACIONESChanged();
    partial void OnIDMOTIVOChanging(System.Nullable<int> value);
    partial void OnIDMOTIVOChanged();
    partial void OnDESCMOTIVOChanging(string value);
    partial void OnDESCMOTIVOChanged();
    #endregion
		
		public TRASPALMACEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SERIE", DbType="NVarChar(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SERIE
		{
			get
			{
				return this._SERIE;
			}
			set
			{
				if ((this._SERIE != value))
				{
					this.OnSERIEChanging(value);
					this.SendPropertyChanging();
					this._SERIE = value;
					this.SendPropertyChanged("SERIE");
					this.OnSERIEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMERO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int NUMERO
		{
			get
			{
				return this._NUMERO;
			}
			set
			{
				if ((this._NUMERO != value))
				{
					this.OnNUMEROChanging(value);
					this.SendPropertyChanging();
					this._NUMERO = value;
					this.SendPropertyChanged("NUMERO");
					this.OnNUMEROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LINEA", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LINEA
		{
			get
			{
				return this._LINEA;
			}
			set
			{
				if ((this._LINEA != value))
				{
					this.OnLINEAChanging(value);
					this.SendPropertyChanging();
					this._LINEA = value;
					this.SendPropertyChanged("LINEA");
					this.OnLINEAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODALMORIG", DbType="NVarChar(3)")]
		public string CODALMORIG
		{
			get
			{
				return this._CODALMORIG;
			}
			set
			{
				if ((this._CODALMORIG != value))
				{
					this.OnCODALMORIGChanging(value);
					this.SendPropertyChanging();
					this._CODALMORIG = value;
					this.SendPropertyChanged("CODALMORIG");
					this.OnCODALMORIGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODALMDEST", DbType="NVarChar(3)")]
		public string CODALMDEST
		{
			get
			{
				return this._CODALMDEST;
			}
			set
			{
				if ((this._CODALMDEST != value))
				{
					this.OnCODALMDESTChanging(value);
					this.SendPropertyChanging();
					this._CODALMDEST = value;
					this.SendPropertyChanged("CODALMDEST");
					this.OnCODALMDESTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA
		{
			get
			{
				return this._FECHA;
			}
			set
			{
				if ((this._FECHA != value))
				{
					this.OnFECHAChanging(value);
					this.SendPropertyChanging();
					this._FECHA = value;
					this.SendPropertyChanged("FECHA");
					this.OnFECHAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODARTICULO", DbType="Int")]
		public System.Nullable<int> CODARTICULO
		{
			get
			{
				return this._CODARTICULO;
			}
			set
			{
				if ((this._CODARTICULO != value))
				{
					this.OnCODARTICULOChanging(value);
					this.SendPropertyChanging();
					this._CODARTICULO = value;
					this.SendPropertyChanged("CODARTICULO");
					this.OnCODARTICULOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_REFERENCIA", DbType="NVarChar(15)")]
		public string REFERENCIA
		{
			get
			{
				return this._REFERENCIA;
			}
			set
			{
				if ((this._REFERENCIA != value))
				{
					this.OnREFERENCIAChanging(value);
					this.SendPropertyChanging();
					this._REFERENCIA = value;
					this.SendPropertyChanged("REFERENCIA");
					this.OnREFERENCIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPCION", DbType="NVarChar(45)")]
		public string DESCRIPCION
		{
			get
			{
				return this._DESCRIPCION;
			}
			set
			{
				if ((this._DESCRIPCION != value))
				{
					this.OnDESCRIPCIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPCION = value;
					this.SendPropertyChanged("DESCRIPCION");
					this.OnDESCRIPCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UNIDADES", DbType="Float")]
		public System.Nullable<double> UNIDADES
		{
			get
			{
				return this._UNIDADES;
			}
			set
			{
				if ((this._UNIDADES != value))
				{
					this.OnUNIDADESChanging(value);
					this.SendPropertyChanging();
					this._UNIDADES = value;
					this.SendPropertyChanged("UNIDADES");
					this.OnUNIDADESChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRECIO", DbType="Float")]
		public System.Nullable<double> PRECIO
		{
			get
			{
				return this._PRECIO;
			}
			set
			{
				if ((this._PRECIO != value))
				{
					this.OnPRECIOChanging(value);
					this.SendPropertyChanging();
					this._PRECIO = value;
					this.SendPropertyChanged("PRECIO");
					this.OnPRECIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USUARIO", DbType="Int")]
		public System.Nullable<int> USUARIO
		{
			get
			{
				return this._USUARIO;
			}
			set
			{
				if ((this._USUARIO != value))
				{
					this.OnUSUARIOChanging(value);
					this.SendPropertyChanging();
					this._USUARIO = value;
					this.SendPropertyChanged("USUARIO");
					this.OnUSUARIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAJA", DbType="Int")]
		public System.Nullable<int> CAJA
		{
			get
			{
				return this._CAJA;
			}
			set
			{
				if ((this._CAJA != value))
				{
					this.OnCAJAChanging(value);
					this.SendPropertyChanging();
					this._CAJA = value;
					this.SendPropertyChanged("CAJA");
					this.OnCAJAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Z", DbType="Int")]
		public System.Nullable<int> Z
		{
			get
			{
				return this._Z;
			}
			set
			{
				if ((this._Z != value))
				{
					this.OnZChanging(value);
					this.SendPropertyChanging();
					this._Z = value;
					this.SendPropertyChanged("Z");
					this.OnZChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STOCK", DbType="Float")]
		public System.Nullable<double> STOCK
		{
			get
			{
				return this._STOCK;
			}
			set
			{
				if ((this._STOCK != value))
				{
					this.OnSTOCKChanging(value);
					this.SendPropertyChanging();
					this._STOCK = value;
					this.SendPropertyChanged("STOCK");
					this.OnSTOCKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCARGADO", DbType="NChar(1)")]
		public System.Nullable<char> DESCARGADO
		{
			get
			{
				return this._DESCARGADO;
			}
			set
			{
				if ((this._DESCARGADO != value))
				{
					this.OnDESCARGADOChanging(value);
					this.SendPropertyChanging();
					this._DESCARGADO = value;
					this.SendPropertyChanged("DESCARGADO");
					this.OnDESCARGADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHACREACION", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHACREACION
		{
			get
			{
				return this._FECHACREACION;
			}
			set
			{
				if ((this._FECHACREACION != value))
				{
					this.OnFECHACREACIONChanging(value);
					this.SendPropertyChanging();
					this._FECHACREACION = value;
					this.SendPropertyChanged("FECHACREACION");
					this.OnFECHACREACIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMPRESIONES", DbType="Int")]
		public System.Nullable<int> IMPRESIONES
		{
			get
			{
				return this._IMPRESIONES;
			}
			set
			{
				if ((this._IMPRESIONES != value))
				{
					this.OnIMPRESIONESChanging(value);
					this.SendPropertyChanging();
					this._IMPRESIONES = value;
					this.SendPropertyChanged("IMPRESIONES");
					this.OnIMPRESIONESChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESRECUENTO", DbType="Bit")]
		public System.Nullable<bool> ESRECUENTO
		{
			get
			{
				return this._ESRECUENTO;
			}
			set
			{
				if ((this._ESRECUENTO != value))
				{
					this.OnESRECUENTOChanging(value);
					this.SendPropertyChanging();
					this._ESRECUENTO = value;
					this.SendPropertyChanged("ESRECUENTO");
					this.OnESRECUENTOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OBSERVACIONES", DbType="NVarChar(100)")]
		public string OBSERVACIONES
		{
			get
			{
				return this._OBSERVACIONES;
			}
			set
			{
				if ((this._OBSERVACIONES != value))
				{
					this.OnOBSERVACIONESChanging(value);
					this.SendPropertyChanging();
					this._OBSERVACIONES = value;
					this.SendPropertyChanged("OBSERVACIONES");
					this.OnOBSERVACIONESChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMOTIVO", DbType="Int")]
		public System.Nullable<int> IDMOTIVO
		{
			get
			{
				return this._IDMOTIVO;
			}
			set
			{
				if ((this._IDMOTIVO != value))
				{
					this.OnIDMOTIVOChanging(value);
					this.SendPropertyChanging();
					this._IDMOTIVO = value;
					this.SendPropertyChanged("IDMOTIVO");
					this.OnIDMOTIVOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCMOTIVO", DbType="NVarChar(100)")]
		public string DESCMOTIVO
		{
			get
			{
				return this._DESCMOTIVO;
			}
			set
			{
				if ((this._DESCMOTIVO != value))
				{
					this.OnDESCMOTIVOChanging(value);
					this.SendPropertyChanging();
					this._DESCMOTIVO = value;
					this.SendPropertyChanged("DESCMOTIVO");
					this.OnDESCMOTIVOChanged();
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

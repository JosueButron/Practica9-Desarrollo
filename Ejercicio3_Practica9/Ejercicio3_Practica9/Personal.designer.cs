#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejercicio3_Practica9
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Personal")]
	public partial class PersonalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public PersonalDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["PersonalConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PersonalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PersonalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<personal> personal
		{
			get
			{
				return this.GetTable<personal>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.personal")]
	public partial class personal
	{
		
		private string _Nombre;
		
		private System.Nullable<int> _DNI;
		
		private string _area;
		
		private System.Nullable<int> _sueldo;
		
		public personal()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="Int")]
		public System.Nullable<int> DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_area", DbType="NVarChar(50)")]
		public string area
		{
			get
			{
				return this._area;
			}
			set
			{
				if ((this._area != value))
				{
					this._area = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sueldo", DbType="Int")]
		public System.Nullable<int> sueldo
		{
			get
			{
				return this._sueldo;
			}
			set
			{
				if ((this._sueldo != value))
				{
					this._sueldo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

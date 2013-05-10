﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("SecurityDb", "RolePermissions", "Permissions", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(TestApp.Permissions), "Roles", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(TestApp.Roles))]
[assembly: EdmRelationshipAttribute("SecurityDb", "UserRoles", "Roles", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(TestApp.Roles), "Users", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(TestApp.Users))]

#endregion

namespace TestApp
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SecurityEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SecurityEntities object using the connection string found in the 'SecurityEntities' section of the application configuration file.
        /// </summary>
        public SecurityEntities() : base("name=SecurityEntities", "SecurityEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SecurityEntities object.
        /// </summary>
        public SecurityEntities(string connectionString) : base(connectionString, "SecurityEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SecurityEntities object.
        /// </summary>
        public SecurityEntities(EntityConnection connection) : base(connection, "SecurityEntities")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Permissions> Permissions
        {
            get
            {
                if ((_Permissions == null))
                {
                    _Permissions = base.CreateObjectSet<Permissions>("Permissions");
                }
                return _Permissions;
            }
        }
        private ObjectSet<Permissions> _Permissions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Roles> Roles
        {
            get
            {
                if ((_Roles == null))
                {
                    _Roles = base.CreateObjectSet<Roles>("Roles");
                }
                return _Roles;
            }
        }
        private ObjectSet<Roles> _Roles;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Users> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<Users>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<Users> _Users;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Permissions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPermissions(Permissions permissions)
        {
            base.AddObject("Permissions", permissions);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Roles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRoles(Roles roles)
        {
            base.AddObject("Roles", roles);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(Users users)
        {
            base.AddObject("Users", users);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SecurityDb", Name="Permissions")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Permissions : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Permissions object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Permissions CreatePermissions(global::System.Int32 id, global::System.String name)
        {
            Permissions permissions = new Permissions();
            permissions.Id = id;
            permissions.Name = name;
            return permissions;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SecurityDb", "RolePermissions", "Roles")]
        public EntityCollection<Roles> Roles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Roles>("SecurityDb.RolePermissions", "Roles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Roles>("SecurityDb.RolePermissions", "Roles", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SecurityDb", Name="Roles")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Roles : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Roles object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Roles CreateRoles(global::System.Int32 id, global::System.String name)
        {
            Roles roles = new Roles();
            roles.Id = id;
            roles.Name = name;
            return roles;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SecurityDb", "RolePermissions", "Permissions")]
        public EntityCollection<Permissions> Permissions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Permissions>("SecurityDb.RolePermissions", "Permissions");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Permissions>("SecurityDb.RolePermissions", "Permissions", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SecurityDb", "UserRoles", "Users")]
        public EntityCollection<Users> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Users>("SecurityDb.UserRoles", "Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Users>("SecurityDb.UserRoles", "Users", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SecurityDb", Name="Users")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Users : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Users object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="username">Initial value of the Username property.</param>
        /// <param name="pwHash">Initial value of the PwHash property.</param>
        public static Users CreateUsers(global::System.Int32 id, global::System.String username, global::System.Int32 pwHash)
        {
            Users users = new Users();
            users.Id = id;
            users.Username = username;
            users.PwHash = pwHash;
            return users;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                OnUsernameChanging(value);
                ReportPropertyChanging("Username");
                _Username = StructuralObject.SetValidValue(value, false, "Username");
                ReportPropertyChanged("Username");
                OnUsernameChanged();
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PwHash
        {
            get
            {
                return _PwHash;
            }
            set
            {
                OnPwHashChanging(value);
                ReportPropertyChanging("PwHash");
                _PwHash = StructuralObject.SetValidValue(value, "PwHash");
                ReportPropertyChanged("PwHash");
                OnPwHashChanged();
            }
        }
        private global::System.Int32 _PwHash;
        partial void OnPwHashChanging(global::System.Int32 value);
        partial void OnPwHashChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SecurityDb", "UserRoles", "Roles")]
        public EntityCollection<Roles> Roles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Roles>("SecurityDb.UserRoles", "Roles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Roles>("SecurityDb.UserRoles", "Roles", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
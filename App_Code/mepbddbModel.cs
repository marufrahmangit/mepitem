﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class tblCompanyDetail
{
    public int Id { get; set; }
    public string BrandName { get; set; }
    public string MinCapacity { get; set; }
    public string MaxCapacity { get; set; }
    public string Catalogue { get; set; }
    public string Specification { get; set; }
    public Nullable<int> CompanyTypeId { get; set; }
    public Nullable<int> UserId { get; set; }
    public Nullable<int> SystemId { get; set; }
    public Nullable<int> SubSystemId { get; set; }
    public Nullable<int> ItemId { get; set; }
    public Nullable<int> SubItemId { get; set; }
    public string SystemTitle { get; set; }
    public string SubSystemTitle { get; set; }
    public string ItemTitle { get; set; }
    public string SubItemTitle { get; set; }

    public virtual tblUserAccount tblUserAccount { get; set; }
    public virtual tblSystem tblSystem { get; set; }
    public virtual tblSubSystem tblSubSystem { get; set; }
    public virtual tblItem tblItem { get; set; }
    public virtual tblSubItem tblSubItem { get; set; }
}

public partial class tblCompanyType
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblCompanyType()
    {
        this.tblUserAccounts = new HashSet<tblUserAccount>();
    }

    public int Id { get; set; }
    public string CompanyType { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblUserAccount> tblUserAccounts { get; set; }
}

public partial class tblItem
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblItem()
    {
        this.tblCompanyDetails = new HashSet<tblCompanyDetail>();
        this.tblSubItems = new HashSet<tblSubItem>();
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public Nullable<int> SubSystemId { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblCompanyDetail> tblCompanyDetails { get; set; }
    public virtual tblSubSystem tblSubSystem { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblSubItem> tblSubItems { get; set; }
}

public partial class tblOffer
{
    public int Id { get; set; }
    public Nullable<int> PostId { get; set; }
    public Nullable<int> ClientId { get; set; }
    public Nullable<int> CompanyId { get; set; }
    public string MessageToClient { get; set; }
    public Nullable<System.DateTime> OfferDate { get; set; }
    public string Status { get; set; }
    public string Specification { get; set; }
}

public partial class tblOfferNotification
{
    public int Id { get; set; }
    public Nullable<int> OfferId { get; set; }
    public Nullable<int> PostId { get; set; }
    public Nullable<System.DateTime> NotificationDate { get; set; }
}

public partial class tblPost
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblPost()
    {
        this.tblTags = new HashSet<tblTag>();
    }

    public int Id { get; set; }
    public string Description { get; set; }
    public Nullable<System.DateTime> PostDate { get; set; }
    public string Status { get; set; }
    public string Specification { get; set; }
    public Nullable<int> UserId { get; set; }

    public virtual tblUserAccount tblUserAccount { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblTag> tblTags { get; set; }
}

public partial class tblPostNotification
{
    public int Id { get; set; }
    public Nullable<int> PostId { get; set; }
    public Nullable<System.DateTime> NotificationDate { get; set; }
}

public partial class tblRole
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblRole()
    {
        this.tblUserAccounts = new HashSet<tblUserAccount>();
    }

    public int Id { get; set; }
    public string RoleType { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblUserAccount> tblUserAccounts { get; set; }
}

public partial class tblSubItem
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblSubItem()
    {
        this.tblCompanyDetails = new HashSet<tblCompanyDetail>();
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public Nullable<int> ItemId { get; set; }
    public Nullable<int> SubSystemId { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblCompanyDetail> tblCompanyDetails { get; set; }
    public virtual tblItem tblItem { get; set; }
    public virtual tblSubSystem tblSubSystem { get; set; }
}

public partial class tblSubSystem
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblSubSystem()
    {
        this.tblCompanyDetails = new HashSet<tblCompanyDetail>();
        this.tblItems = new HashSet<tblItem>();
        this.tblSubItems = new HashSet<tblSubItem>();
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public Nullable<int> SystemId { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblCompanyDetail> tblCompanyDetails { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblItem> tblItems { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblSubItem> tblSubItems { get; set; }
    public virtual tblSystem tblSystem { get; set; }
}

public partial class tblSystem
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblSystem()
    {
        this.tblCompanyDetails = new HashSet<tblCompanyDetail>();
        this.tblSubSystems = new HashSet<tblSubSystem>();
    }

    public int Id { get; set; }
    public string Title { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblCompanyDetail> tblCompanyDetails { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblSubSystem> tblSubSystems { get; set; }
}

public partial class tblTag
{
    public int Id { get; set; }
    public string Tag { get; set; }
    public Nullable<int> PostId { get; set; }

    public virtual tblPost tblPost { get; set; }
}

public partial class tblUserAccount
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblUserAccount()
    {
        this.tblCompanyDetails = new HashSet<tblCompanyDetail>();
        this.tblPosts = new HashSet<tblPost>();
    }

    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Website { get; set; }
    public Nullable<int> RoleId { get; set; }
    public Nullable<int> CompanyTypeId { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblCompanyDetail> tblCompanyDetails { get; set; }
    public virtual tblCompanyType tblCompanyType { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tblPost> tblPosts { get; set; }
    public virtual tblRole tblRole { get; set; }
}
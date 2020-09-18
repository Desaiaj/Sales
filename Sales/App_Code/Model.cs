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

public partial class Customer
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Customer()
    {
        this.Orders = new HashSet<Order>();
    }

    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public int YTDOrders { get; set; }
    public int YTDSales { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Order> Orders { get; set; }
}

public partial class Order
{
    public int CustomerID { get; set; }
    public int OrderID { get; set; }
    public System.DateTime OrderDate { get; set; }
    public Nullable<System.DateTime> FilledDate { get; set; }
    public string Status { get; set; }
    public int Amount { get; set; }

    public virtual Customer Customer { get; set; }
}

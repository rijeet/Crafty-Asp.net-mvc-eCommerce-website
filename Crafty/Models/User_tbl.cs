//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crafty.Models
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    
    public partial class User_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_tbl()
        {
            this.Cart_tbl = new HashSet<Cart_tbl>();
            this.Order_tbl = new HashSet<Order_tbl>();
            this.Payment_tbl = new HashSet<Payment_tbl>();
        }
    
        public int U_ID { get; set; }
        public string Image { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public Nullable<System.DateTime> Dateofbirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string Role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart_tbl> Cart_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_tbl> Order_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment_tbl> Payment_tbl { get; set; }
        
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simpson_Group_Store_Database.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public int Addressid { get; set; }
        public int Userid { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
    
        public virtual User User { get; set; }
    }
}

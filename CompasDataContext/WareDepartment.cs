//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compas.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class WareDepartment
    {
        public WareDepartment()
        {
            this.WareDocumentStaffDetails = new HashSet<WareDocumentStaffDetail>();
        }
    
        public int ID { get; set; }
        public int WareID { get; set; }
        public int DepartmentID { get; set; }
    
        public virtual StaffDepartment StaffDepartment { get; set; }
        public virtual Ware Ware { get; set; }
        public virtual ICollection<WareDocumentStaffDetail> WareDocumentStaffDetails { get; set; }
    }
}
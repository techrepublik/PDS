//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDSSystem.dal.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Children
    {
        public int ChildrenNo { get; set; }
        public Nullable<int> SpouseNo { get; set; }
        public string ChildrenLastName { get; set; }
        public string ChildrenFirstName { get; set; }
        public string ChildrenMiddleName { get; set; }
        public Nullable<System.DateTime> ChildrenBirthDate { get; set; }
        public Nullable<System.DateTime> modifieddate { get; set; }
    
        public virtual Spous Spous { get; set; }
    }
}

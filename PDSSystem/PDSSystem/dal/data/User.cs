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
    
    public partial class User
    {
        public int UserNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserLevel { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace linq_joins_ex.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class depttable2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public depttable2()
        {
            this.emp2 = new HashSet<emp2>();
        }
    
        public long deptid { get; set; }
        public string deptname { get; set; }
        public Nullable<long> cityid { get; set; }
    
        public virtual city city { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<emp2> emp2 { get; set; }
    }
}

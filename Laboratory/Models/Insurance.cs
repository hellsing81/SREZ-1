//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Insurance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Insurance()
        {
            this.Clients = new HashSet<Clients>();
        }
    
        public int InsuranceID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string InsurancePolicy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clients> Clients { get; set; }
        public virtual InsuranceCompanies InsuranceCompanies { get; set; }
        public virtual InsuranceTypes InsuranceTypes { get; set; }
    }
}

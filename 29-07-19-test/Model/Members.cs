
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace _29_07_19_test.Model
{

using System;
    using System.Collections.Generic;
    
public partial class Members
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Members()
    {

        this.Lending = new HashSet<Lending>();

    }


    public int Id { get; set; }

    public string MemberName { get; set; }

    public string MemberSurname { get; set; }

    public string PassportId { get; set; }

    public Nullable<bool> Deleted { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Lending> Lending { get; set; }

}

}


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
    
public partial class Users
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Users()
    {

        this.Lending = new HashSet<Lending>();

    }


    public int Id { get; set; }

    public string UserName { get; set; }

    public string Surname { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public bool Levels { get; set; }

    public bool Staus { get; set; }

    public bool Deleted { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Lending> Lending { get; set; }

}

}

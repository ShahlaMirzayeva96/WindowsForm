﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class masterEntities : DbContext
{
    public masterEntities()
        : base("name=masterEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Users> Users { get; set; }

    public virtual DbSet<BookGenre> BookGenre { get; set; }

    public virtual DbSet<Books> Books { get; set; }

    public virtual DbSet<Lending> Lending { get; set; }

    public virtual DbSet<Members> Members { get; set; }

}

}


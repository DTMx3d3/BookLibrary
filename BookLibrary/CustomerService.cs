//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerService
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DataStart { get; set; }
        public Nullable<System.DateTime> DataEnd { get; set; }
        public Nullable<decimal> Pret { get; set; }
        public Nullable<int> TipCarte { get; set; }
        public string Titlu { get; set; }
    
        public virtual TipuriCarti TipuriCarti { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class pracownicy
    {
        public int id_pracownika { get; set; }
        public string nazwisko { get; set; }
        public string imie { get; set; }
        public System.DateTime data_urodzenia { get; set; }
        public System.DateTime data_zatrudnienia { get; set; }
        public string zawod { get; set; }
        public string nr_pokoju { get; set; }
    
        public virtual pokoje pokoje { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YoklamaKayit
{
    using System;
    using System.Collections.Generic;
    
    public partial class OGRDERS
    {
        public int ID { get; set; }
        public int DERSID { get; set; }
        public string OGRID { get; set; }
    
        public virtual DERSLER DERSLER { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IGA_Havalimanı_Yönetim_Proje
{
    using System;
    using System.Collections.Generic;
    
    public partial class KabinEkibi
    {
        public int KabinID { get; set; }
        public int UçuşID { get; set; }
        public int HavayoluID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
    
        public virtual Havayolları Havayolları { get; set; }
        public virtual Uçuşlar Uçuşlar { get; set; }
    }
}

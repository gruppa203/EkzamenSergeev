//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EkzamenSergeev1.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tovari
    {
        public string ArtikylTovara { get; set; }
        public string NaimenovanieTovara { get; set; }
        public decimal StoimostTovara { get; set; }
        public string EdenitsaIzmeriniya { get; set; }
        public int KodProizvoditelya { get; set; }
        public int KodPostavchika { get; set; }
        public int KategoriyaTovara { get; set; }
        public Nullable<int> SkidkaNaTovar { get; set; }
        public int MaksimalnyaiaSkidka { get; set; }
        public int KolichestoNaSklade { get; set; }
        public string OpisanieTovara { get; set; }
        public string IzobrajenieTovara { get; set; }
    
        public virtual KategoriiTovarov KategoriiTovarov { get; set; }
        public virtual Postavchiki Postavchiki { get; set; }
        public virtual Proizvoditeli Proizvoditeli { get; set; }
    }
}

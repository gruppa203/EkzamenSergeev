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
    
    public partial class Polzovateli
    {
        public int KodPolzovatelya { get; set; }
        public string FamiliyaPolzovatelya { get; set; }
        public string ImyaPolzovatelya { get; set; }
        public string OtchestvoPolzovatelya { get; set; }
        public string LoginPolzovatelya { get; set; }
        public string ParolPolzovatelya { get; set; }
        public int RolPolzovatelya { get; set; }
    
        public virtual Roli Roli { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika1
{
    using System;
    using System.Collections.Generic;
    
    public partial class supply
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Aggentid { get; set; }
        public int Clientid { get; set; }
        public int RealEstatled { get; set; }
    
        public virtual agent agent { get; set; }
        public virtual client client { get; set; }
        public virtual @object @object { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasswordsMenadger.DBContent
{
    using System;
    using System.Collections.Generic;
    
    public partial class Site
    {
        public int Id { get; set; }
        public string UrlPath { get; set; }
        public string Title { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual User User { get; set; }
    }
}

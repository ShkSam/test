//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test4
{
    using System;
    using System.Collections.Generic;
    
    public partial class КомпанииПоставщики
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public КомпанииПоставщики()
        {
            this.ПоставкиНаСклад = new HashSet<ПоставкиНаСклад>();
        }
    
        public int Код_Поставщика { get; set; }
        public string Название_Компании { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПоставкиНаСклад> ПоставкиНаСклад { get; set; }
    }
}

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
    
    public partial class ТоварыНаСкладе
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ТоварыНаСкладе()
        {
            this.ДоставкаТовараВМагазин = new HashSet<ДоставкаТовараВМагазин>();
            this.ПоставкиНаСклад = new HashSet<ПоставкиНаСклад>();
        }
    
        public int Код_Товара { get; set; }
        public string Название_Товара { get; set; }
        public string Ед_изм { get; set; }
        public Nullable<int> Количество_Товара { get; set; }
        public Nullable<int> Цена { get; set; }
        public Nullable<System.DateTime> Годен_до { get; set; }
        public Nullable<int> Код_ВидПродукта { get; set; }
    
        public virtual ВидыПродуктов ВидыПродуктов { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ДоставкаТовараВМагазин> ДоставкаТовараВМагазин { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПоставкиНаСклад> ПоставкиНаСклад { get; set; }
    }
}

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
    
    public partial class Пользователи
    {
        public int Код_Работника { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public string ФИО { get; set; }
        public Nullable<int> Код_Должности { get; set; }
        public string Раб_Телефон { get; set; }
    
        public virtual Должности Должности { get; set; }
    }
}

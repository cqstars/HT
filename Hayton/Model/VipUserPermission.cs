//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class VipUserPermission
    {
        public int VipID { get; set; }
        public Nullable<int> VipUserID { get; set; }
        public Nullable<int> VipPerMissionID { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsDel { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
    
        public virtual Permission Permission { get; set; }
        public virtual UserDB UserDB { get; set; }
    }
}

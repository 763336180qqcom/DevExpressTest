namespace DevTest.测试2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t费用收入
    {
        public int fPID { get; set; }

        [Key]
        public int fID { get; set; }

        public int type { get; set; }

        [Required]
        [StringLength(100)]
        public string 名称 { get; set; }

        public decimal 金额 { get; set; }

        public int 期数 { get; set; }

        public int 状态 { get; set; }

        public virtual t合约业务 t合约业务 { get; set; }
    }
}

namespace DevTest.测试1.ef1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v费用收入
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 业务ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string 类别 { get; set; }

        [StringLength(100)]
        public string 项目名称 { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal 金额 { get; set; }

        [Key]
        [Column(Order = 3)]
        public int 期数 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string 状态 { get; set; }
    }
}

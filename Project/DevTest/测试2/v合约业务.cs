namespace DevTest.测试2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v合约业务
    {
        [Key]
        [Column(Order = 0)]
        public int fID { get; set; }

        [StringLength(100)]
        public string 名称 { get; set; }

        [StringLength(12)]
        public string 运营商ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string 捆绑终端 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string 允许老号 { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal 店员价 { get; set; }

        public decimal? 最低价 { get; set; }

        public decimal? 毛利奖励 { get; set; }

        public decimal? 现金奖励 { get; set; }

        [StringLength(10)]
        public string 开始时间 { get; set; }

        [StringLength(10)]
        public string 结束时间 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string 状态 { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] 时间戳 { get; set; }

        public long? int时间戳 { get; set; }
    }
}

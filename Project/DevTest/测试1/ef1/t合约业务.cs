namespace DevTest.测试1.ef1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t合约业务
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t合约业务()
        {
            t费用收入 = new HashSet<DevTest.测试1.ef1.t费用收入>();
        }

        [Key]
        public int fID { get; set; }

        [Required]
        [StringLength(100)]
        public string 名称 { get; set; }

        public int 运营商ID { get; set; }

        public int 捆绑终端 { get; set; }

        public int 允许老号 { get; set; }

        public decimal 店员价 { get; set; }

        public decimal? 最低价 { get; set; }

        public decimal? 毛利奖励 { get; set; }

        public decimal? 现金奖励 { get; set; }

        public DateTime 开始时间 { get; set; }

        public DateTime? 结束时间 { get; set; }

        public int 状态 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] stamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevTest.测试1.ef1.t费用收入> t费用收入 { get; set; }
    }
}

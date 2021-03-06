namespace Netnr.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SysButton")]
    public partial class SysButton
    {
        [Key]
        [StringLength(50)]
        public string SbId { get; set; }

        [StringLength(50)]
        public string SbPid { get; set; }

        [StringLength(20)]
        public string SbBtnText { get; set; }

        [StringLength(50)]
        public string SbBtnId { get; set; }

        [StringLength(50)]
        public string SbBtnClass { get; set; }

        [StringLength(50)]
        public string SbBtnIcon { get; set; }

        public int? SbBtnOrder { get; set; }

        public int? SbStatus { get; set; }

        [StringLength(200)]
        public string SbDescribe { get; set; }

        public int? SbBtnGroup { get; set; }
    }
}

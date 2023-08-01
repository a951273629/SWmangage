using Newtonsoft.Json;
/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "工作岗位管理",TableName = "Org_WorkPost")]
    public partial class Org_WorkPost:BaseEntity
    {
        /// <summary>
       ///序号
       /// </summary>
       [Key]
       [Display(Name ="序号")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public long Id { get; set; }

       /// <summary>
       ///岗位编码
       /// </summary>
       [Display(Name ="岗位编码")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string PostCode { get; set; }

       /// <summary>
       ///岗位名称
       /// </summary>
       [Display(Name ="岗位名称")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string PostName { get; set; }

       /// <summary>
       ///岗位类型
       /// </summary>
       [Display(Name ="岗位类型")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string PostType { get; set; }

       /// <summary>
       ///岗位职责
       /// </summary>
       [Display(Name ="岗位职责")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PostDuty { get; set; }

       /// <summary>
       ///岗位状态
       /// </summary>
       [Display(Name ="岗位状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? State { get; set; }

       /// <summary>
       ///操作
       /// </summary>
       [Display(Name ="操作")]
       [JsonIgnore]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Operation { get; set; }

       
    }
}

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
    [Entity(TableCnName = "编码器页面",TableName = "CatalogTree")]
    public partial class CatalogTree:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///父级分类
       /// </summary>
       [Display(Name ="父级分类")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentID { get; set; }

       /// <summary>
       ///物料分类名称
       /// </summary>
       [Display(Name ="物料分类名称")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string CatalogTypeName { get; set; }

       /// <summary>
       ///类型编码
       /// </summary>
       [Display(Name ="类型编码")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string CatalogTypeCode { get; set; }

       /// <summary>
       ///分隔符
       /// </summary>
       [Display(Name ="分隔符")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SeparatorCode { get; set; }

       /// <summary>
       ///编码申请起始流水号
       /// </summary>
       [Display(Name ="编码申请起始流水号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? InitialSerialNumber { get; set; }

       /// <summary>
       ///当前编码流水号
       /// </summary>
       [Display(Name ="当前编码流水号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? LastSerialNumber { get; set; }

       /// <summary>
       ///产品物料版本
       /// </summary>
       [Display(Name ="产品物料版本")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Version { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///物料分类规则
       /// </summary>
       [Display(Name ="物料分类规则")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string RuleTypeCode { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreatedTime { get; set; }

       /// <summary>
       ///创建者
       /// </summary>
       [Display(Name ="创建者")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string CreatedBy { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifiedTime { get; set; }

       /// <summary>
       ///修改者
       /// </summary>
       [Display(Name ="修改者")]
       [MaxLength(250)]
       [Column(TypeName="nvarchar(250)")]
       [Editable(true)]
       public string ModifiedBy { get; set; }

       
    }
}
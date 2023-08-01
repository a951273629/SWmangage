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
    [Entity(TableCnName = "编码日志记录",TableName = "Catalog_Record")]
    public partial class Catalog_Record:BaseEntity
    {
        /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///物料ID
       /// </summary>
       [Display(Name ="物料ID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ItemId { get; set; }

       /// <summary>
       ///当前物料名称
       /// </summary>
       [Display(Name ="当前物料名称")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string ItemName { get; set; }

       /// <summary>
       ///产品物料的版本
       /// </summary>
       [Display(Name ="产品物料的版本")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ItemVersion { get; set; }

       /// <summary>
       ///完整的物料编码 ，1-AA.BB-000001
       /// </summary>
       [Display(Name ="完整的物料编码 ，1-AA.BB-000001")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string PartNumber { get; set; }

       /// <summary>
       ///完整的物料分类,如 一级 二级 三级   1-AA.BB
       /// </summary>
       [Display(Name ="完整的物料分类,如 一级 二级 三级   1-AA.BB")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string CompletedTypeCode { get; set; }

       /// <summary>
       ///编码流水号
       /// </summary>
       [Display(Name ="编码流水号")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SerialNumber { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreatedTime { get; set; }

       /// <summary>
       ///创建者
       /// </summary>
       [Display(Name ="创建者")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string CreatedBy { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifiedDate { get; set; }

       /// <summary>
       ///修改者
       /// </summary>
       [Display(Name ="修改者")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string ModifiedBy { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Remark { get; set; }

       
    }
}
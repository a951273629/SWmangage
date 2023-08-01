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
    [Entity(TableCnName = "产品信息档案",TableName = "Prod_ProductionMessage")]
    public partial class Prod_ProductionMessage:BaseEntity
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
       ///产品编码
       /// </summary>
       [Display(Name ="产品编码")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Code { get; set; }

       /// <summary>
       ///产品名称
       /// </summary>
       [Display(Name ="产品名称")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Name { get; set; }

       /// <summary>
       ///产品品牌
       /// </summary>
       [Display(Name ="产品品牌")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Brand { get; set; }

       /// <summary>
       ///产品分类
       /// </summary>
       [Display(Name ="产品分类")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Kind { get; set; }

       /// <summary>
       ///产品型号
       /// </summary>
       [Display(Name ="产品型号")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Model { get; set; }

       /// <summary>
       ///产品类型
       /// </summary>
       [Display(Name ="产品类型")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Type { get; set; }

       /// <summary>
       ///产品单位
       /// </summary>
       [Display(Name ="产品单位")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Unit { get; set; }

       /// <summary>
       ///关联物料
       /// </summary>
       [Display(Name ="关联物料")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Connection { get; set; }

       /// <summary>
       ///启用
       /// </summary>
       [Display(Name ="启用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? State { get; set; }

       /// <summary>
       ///操作
       /// </summary>
       [Display(Name ="操作")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Operation { get; set; }

       
    }
}
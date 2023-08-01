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
    [Entity(TableCnName = "供应商条码规则",TableName = "Store_ProviderRegular")]
    public partial class Store_ProviderRegular:BaseEntity
    {
        /// <summary>
       ///序号
       /// </summary>
       [Key]
       [Display(Name ="序号")]
       [Column(TypeName="bigint")]
       [Required(AllowEmptyStrings=false)]
       public long Id { get; set; }

       /// <summary>
       ///物料条码规则编码
       /// </summary>
       [Display(Name ="物料条码规则编码")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Code_Regular { get; set; }

       /// <summary>
       ///供应商名称
       /// </summary>
       [Display(Name ="供应商名称")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Provider_Name { get; set; }

       /// <summary>
       ///供应商物料编码
       /// </summary>
       [Display(Name ="供应商物料编码")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Provider_Code { get; set; }

       /// <summary>
       ///系统物料编码
       /// </summary>
       [Display(Name ="系统物料编码")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string System_Code { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Material_Name { get; set; }

       /// <summary>
       ///规格型号
       /// </summary>
       [Display(Name ="规格型号")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Specification_Model { get; set; }

       /// <summary>
       ///供应商条码位数
       /// </summary>
       [Display(Name ="供应商条码位数")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Provider_BarCode { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? State { get; set; }

       /// <summary>
       ///操作
       /// </summary>
       [Display(Name ="操作")]
       [Column(TypeName="nvarchar(max)")]
       public string Operation { get; set; }

       
    }
}
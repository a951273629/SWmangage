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
    [Entity(TableCnName = "产成品检验作业",TableName = "Finished_Check_Works")]
    public partial class Finished_Check_Works:BaseEntity
    {
        /// <summary>
       ///关联Id
       /// </summary>
       [Display(Name ="关联Id")]
       [Column(TypeName="bigint")]
       public long? TicketId { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? State { get; set; }

       /// <summary>
       ///物料编码
       /// </summary>
       [Display(Name ="物料编码")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Material_Code { get; set; }

       /// <summary>
       ///物料名称
       /// </summary>
       [Display(Name ="物料名称")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Material_Name { get; set; }

       /// <summary>
       ///物料类型
       /// </summary>
       [Display(Name ="物料类型")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Material_Type { get; set; }

       /// <summary>
       ///物料分类
       /// </summary>
       [Display(Name ="物料分类")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Material_Classify { get; set; }

       /// <summary>
       ///物料单位
       /// </summary>
       [Display(Name ="物料单位")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Material_Unit { get; set; }

       /// <summary>
       ///校验模板
       /// </summary>
       [Display(Name ="校验模板")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Check_Template { get; set; }

       /// <summary>
       ///物料数量
       /// </summary>
       [Display(Name ="物料数量")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? Material_Count { get; set; }

       /// <summary>
       ///校验规则
       /// </summary>
       [Display(Name ="校验规则")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Check_Regular { get; set; }

       /// <summary>
       ///抽样数据
       /// </summary>
       [Display(Name ="抽样数据")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? Sample_Count { get; set; }

       /// <summary>
       ///不良数量
       /// </summary>
       [Display(Name ="不良数量")]
       [Column(TypeName="bigint")]
       [Editable(true)]
       public long? Badness_Count { get; set; }

       /// <summary>
       ///不良率
       /// </summary>
       [Display(Name ="不良率")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Badness_Ratio { get; set; }

       /// <summary>
       ///检查时间
       /// </summary>
       [Display(Name ="检查时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? Check_Time { get; set; }

       /// <summary>
       ///检查人员
       /// </summary>
       [Display(Name ="检查人员")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Checker { get; set; }

       /// <summary>
       ///检查结果
       /// </summary>
       [Display(Name ="检查结果")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Check_Result { get; set; }

       /// <summary>
       ///异常方式
       /// </summary>
       [Display(Name ="异常方式")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Exception_Method { get; set; }

       /// <summary>
       ///操作
       /// </summary>
       [Display(Name ="操作")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Operation { get; set; }

       /// <summary>
       ///作业Id
       /// </summary>
       [Key]
       [Display(Name ="作业Id")]
       [Column(TypeName="bigint")]
       [Required(AllowEmptyStrings=false)]
       public long WorksId { get; set; }

       
    }
}
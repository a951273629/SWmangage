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
    [Entity(TableCnName = "产成品检验单",TableName = "Finished_Check_Ticket",DetailTable =  new Type[] { typeof(Finished_Check_Works)},DetailTableCnName = "产成品检验作业")]
    public partial class Finished_Check_Ticket:BaseEntity
    {
        /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? State { get; set; }

       /// <summary>
       ///检验单号
       /// </summary>
       [Display(Name ="检验单号")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Check_Number { get; set; }

       /// <summary>
       ///检验类型
       /// </summary>
       [Display(Name ="检验类型")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Check_Type { get; set; }

       /// <summary>
       ///生产订单号
       /// </summary>
       [Display(Name ="生产订单号")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Product_Number { get; set; }

       /// <summary>
       ///生产批次
       /// </summary>
       [Display(Name ="生产批次")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Product_Batch { get; set; }

       /// <summary>
       ///计划校验时间
       /// </summary>
       [Display(Name ="计划校验时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? Check_Time { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///创建者
       /// </summary>
       [Display(Name ="创建者")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? Create_Time { get; set; }

       /// <summary>
       ///操作
       /// </summary>
       [Display(Name ="操作")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Operation { get; set; }

       /// <summary>
       ///产成品Id
       /// </summary>
       [Key]
       [Display(Name ="产成品Id")]
       [Column(TypeName="bigint")]
       [Required(AllowEmptyStrings=false)]
       public long TicketId { get; set; }

       [Display(Name ="产成品检验作业")]
       [ForeignKey("TicketId")]
       public List<Finished_Check_Works> Finished_Check_Works { get; set; }

    }
}
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
    [Entity(TableCnName = "人员权限配置",TableName = "Org_people",DetailTable =  new Type[] { typeof(Org_people)},DetailTableCnName = "人员权限配置表")]
    public partial class Org_people:BaseEntity
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
       ///工号
       /// </summary>
       [Display(Name ="工号")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string JobNumber { get; set; }

       /// <summary>
       ///用户名
       /// </summary>
       [Display(Name ="用户名")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Username { get; set; }

       /// <summary>
       ///姓名
       /// </summary>
       [Display(Name ="姓名")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Name { get; set; }

       /// <summary>
       ///电话
       /// </summary>
       [Display(Name ="电话")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Phone { get; set; }

       /// <summary>
       ///邮件
       /// </summary>
       [Display(Name ="邮件")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Email { get; set; }

       /// <summary>
       ///系统账户
       /// </summary>
       [Display(Name ="系统账户")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string SystemAccount { get; set; }

       /// <summary>
       ///部门
       /// </summary>
       [Display(Name ="部门")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string DepartMent { get; set; }

       /// <summary>
       ///管理人员
       /// </summary>
       [Display(Name ="管理人员")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Manager { get; set; }

       /// <summary>
       ///职位
       /// </summary>
       [Display(Name ="职位")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Position { get; set; }

       /// <summary>
       ///薪水
       /// </summary>
       [Display(Name ="薪水")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Salary { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? State { get; set; }

       [Display(Name ="人员权限配置表")]
       [ForeignKey("Id")]
       public List<Org_people> Org_peoples { get; set; }

    }
}
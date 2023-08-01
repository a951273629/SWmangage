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
    [Entity(TableCnName = "系统人员表",TableName = "Org_system",DetailTable =  new Type[] { typeof(Org_system)},DetailTableCnName = "系统用户管理表")]
    public partial class Org_system:BaseEntity
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
       public string UserName { get; set; }

       /// <summary>
       ///姓名
       /// </summary>
       [Display(Name ="姓名")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Name { get; set; }

       /// <summary>
       ///手机
       /// </summary>
       [Display(Name ="手机")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Phone { get; set; }

       /// <summary>
       ///邮箱
       /// </summary>
       [Display(Name ="邮箱")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
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
       ///所属组织
       /// </summary>
       [Display(Name ="所属组织")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Organization { get; set; }

       /// <summary>
       ///负责人
       /// </summary>
       [Display(Name ="负责人")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string Manager { get; set; }

       /// <summary>
       ///任职岗位
       /// </summary>
       [Display(Name ="任职岗位")]
       [Column(TypeName="varchar(max)")]
       [Editable(true)]
       public string Post { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? state { get; set; }

       [Display(Name ="系统用户管理表")]
       [ForeignKey("Id")]
       public List<Org_system> Org_systems { get; set; }

    }
}
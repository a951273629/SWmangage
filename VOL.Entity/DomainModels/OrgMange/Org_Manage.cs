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
    [Entity(TableCnName = "企业权限管理",TableName = "Org_Manage",DetailTable =  new Type[] { typeof(Org_Manage)},DetailTableCnName = "企业权限管理表")]
    public partial class Org_Manage:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="bigint")]
       [Required(AllowEmptyStrings=false)]
       public long Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgCode")]
       [Column(TypeName="nvarchar(max)")]
       public string OrgCode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgName")]
       [Column(TypeName="nvarchar(max)")]
       public string OrgName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgType")]
       [Column(TypeName="nvarchar(max)")]
       public string OrgType { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgFather")]
       [Column(TypeName="bigint")]
       public long? OrgFather { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgKind")]
       [Column(TypeName="nvarchar(max)")]
       public string OrgKind { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgAttribute")]
       [Column(TypeName="nvarchar(max)")]
       public string OrgAttribute { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgManger")]
       [Column(TypeName="nvarchar(max)")]
       public string OrgManger { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgComment")]
       [Column(TypeName="nvarchar(max)")]
       public string OrgComment { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgUse")]
       [Column(TypeName="int")]
       public int? OrgUse { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OrgOperate")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? OrgOperate { get; set; }

       [Display(Name ="企业权限管理表")]
       [ForeignKey("Id")]
       public List<Org_Manage> Org_manage { get; set; }

    }
}
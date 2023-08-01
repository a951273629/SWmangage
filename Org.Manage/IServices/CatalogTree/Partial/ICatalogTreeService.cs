/*
*所有关于CatalogTree类的业务代码接口应在此处编写
*/
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using Org.Manage.Services;

namespace Org.Manage.IServices
{
    public partial interface ICatalogTreeService
    {
        public List<CatalogTree> GetCatalogTreeAll();

        public int GetSerialNumberById(int Id);

        public string GetCode(int[] CatalogIdArrary);

        public Catalog_Record GetCodeComplete(Submit date);

        public CatalogTree GetRuleTypeCode(int ID);
    }
 }

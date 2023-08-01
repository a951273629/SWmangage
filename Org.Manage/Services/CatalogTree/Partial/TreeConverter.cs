using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VOL.Entity.DomainModels;
using System.Threading.Tasks;
using System.Xml.Linq;
using VOL.Core.Extensions.AutofacManager;

namespace Org.Manage.Serice
{
    public class TreeConverter: IDependency
    {
        public List<CatalogTree> ConvertToTree(List<CatalogTree> nodes)
        {
            // 找到根节点
            List<CatalogTree>? root = nodes.FindAll(n => n.ParentID == -1);

            // 建立树形结构
            BuildTree(root, nodes);

            return root;
        }

        private void BuildTree(List<CatalogTree> roots, List<CatalogTree> nodes)
        {
            foreach (CatalogTree root in roots) {
                // 循环遍历找到 root的子节点 
                root.Children = nodes.Where(n => n.ParentID == root.ID).ToList();
                BuildTree(root.Children, nodes);
                
            }
        }
    }
}

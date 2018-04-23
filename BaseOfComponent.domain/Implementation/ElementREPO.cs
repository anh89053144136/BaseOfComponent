using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseOfComponent.domain.Implementation
{
    public class ElementREPO
    {
        private ElementContext ElementsBase = new ElementContext();

        public void AddRelation(Relation relation)
        {
            ElementsBase.Relations.Add(relation);
            ElementsBase.SaveChanges();
        }
        public void AddElement(Element element)
        {
            ElementsBase.Elements.Add(element);
            ElementsBase.SaveChanges();
        }

        public List<Relation> AllElements() => ElementsBase.Relations.ToList();

        public Element[] ReportById(int parentId)
        {
            return ElementsBase.Database.SqlQuery<Element>("EXECUTE [dbo].[Report] @parentId", new SqlParameter("parentId", parentId)).ToArray();
        }
    }
}

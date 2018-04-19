using System;
using System.Collections.Generic;
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
        
        public void DeleteElement(int Id)
        {
            ElementsBase.Elements.Remove(ElementsBase.Elements.FirstOrDefault(x => x.Id == Id));
        }

        public List<Relation> AllElements() => ElementsBase.Relations.ToList();
    }
}

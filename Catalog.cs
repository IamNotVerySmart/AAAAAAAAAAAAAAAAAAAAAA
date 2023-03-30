using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03._30._2023
{
    internal class Catalog
    {
        public IList<Item> Items
        {
            get;
            set;
        }
        public string ThematicDepartment
        {
            get;
            set;
        }
        public Catalog(IList<Item> items)
        {
            Items = items;
            ThematicDepartment = "";
        }
        public Catalog( string thematicDepartment, IList<Item> items)
        {
            Items = items;
            ThematicDepartment = thematicDepartment;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            return $"Item: {Items} \n ThematicDepartment: {ThematicDepartment}";
        }
        public void ShowAllItems()
        {
            foreach(var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    class OrderRepository {
        public Order Load(int orderID) {/*...*/}
        public void Save(Order order) {/*...*/}
    }

    
    class PrintManager {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }



    class Program
    {
        static void Main()
        {
        }
    }
}

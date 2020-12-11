using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Collection : CollectionBase
    {
        //public string DataString { get; set; }
        public Point Add()
        {
            Point Item = new Point();
            List.Add(Item);
            return Item;
        }
        public Point Add(Point Item)
        {
            List.Add(Item);
            return Item;
        }

        public void Insert(int Index, Point Item)
        {
            List.Insert(Index, Item);
        }
        public void Remove(Point Item)
        {
            List.Remove(Item);
        }
        public Point this[int Intex]
        {
            get
            {
                return (Point)List[Intex];
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqXML
{
    public class Product
    {
        private int id;
        private string name;
        private string area;
        private decimal sueldo;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public decimal Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
    }
}
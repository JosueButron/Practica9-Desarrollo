using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace EjercicioPropuesto2Practica9
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var farm = GetFarmacias();
            var cli = GetClientes();


            var query = from m in farm
                        select new { m.Producto, m.Precio, m.Fecha };

            this.GridView1.DataSource = farm; this.GridView1.DataBind();
        }
        public List<Farmacia> GetFarmacias()
        {
            return new List<Farmacia> {
         new Farmacia { Producto="Jabon", Vendedor="Pepe Valencia", Precio=4.70F,
        Fecha=DateTime.Parse("2021/05/31") },
         new Farmacia { Producto="Panadol", Vendedor="Ricardo Buendia", Precio=2.50F,
        Fecha=DateTime.Parse("2021/03/23")},
         new Farmacia { Producto="Jarabe", Vendedor="Raul Ortiz", Precio=7.99F,
        Fecha=DateTime.Parse("2021/02/22")},
         new Farmacia { Producto="Maquina de Afeitar", Vendedor="Timoteo Butron", Precio=6.50F,
        Fecha=DateTime.Parse("2021/09/12") }};
        }

        public class Farmacia
        {
            public string Producto { get; set; }
            public string Vendedor { get; set; }
            public float Precio    { get; set; }
            public DateTime Fecha { get; set; }
        }
        public class Clientes
        {
            public int DNI { get; set; }
            public string Name { get; set; }
        }
        public List<Clientes> GetClientes()
        {
            return new List<Clientes> { new Clientes { DNI=70320769, Name="Josue Butron" } , new
            Clientes { DNI=70320983, Name="Yannela Ibero" } , new Clientes { DNI=40358834, Name="Pablo Alboran" }
             };
        }

        public class LastNameComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                var director1LastName = x.Substring(x.LastIndexOf(' ')); var
             director2LastName = y.Substring(y.LastIndexOf(' ')); return
             director1LastName.CompareTo(director2LastName);
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
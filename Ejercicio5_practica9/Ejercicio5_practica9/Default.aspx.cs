using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio5_practica9
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonalEntities dc = new PersonalEntities(); var query = from m in dc.personal
                                                                  select m;
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        
    }
}
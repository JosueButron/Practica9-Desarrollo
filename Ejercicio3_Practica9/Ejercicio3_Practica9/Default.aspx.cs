using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio3_Practica9
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonalDataContext dc = new PersonalDataContext(); var query = from m in dc.personal
                                                                        select m;
            this.GridView1.DataSource = query; this.GridView1.DataBind();
        }
    }
}
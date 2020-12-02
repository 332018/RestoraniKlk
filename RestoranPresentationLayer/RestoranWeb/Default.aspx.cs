using RestoranBussiessLayer;
using RestoranDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace RestoranWeb
{
    public partial class _Default : Page
    {
        private  RestoranBussiness restoranBussiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.restoranBussiness = new RestoranBussiness();

            List<Restoran> restotans = this.restoranBussiness.GetAllRestorans();

            foreach (Restoran r in restotans)
            {
                listBoxIspis.Items.Add(r.Id + "." + r.Naziv + "," + r.Opis + "," + r.Cena + " ");
            }
        }
    }
}


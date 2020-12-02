using RestoranBussiessLayer;
using RestoranDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranPresentationLayer
{
    public partial class FormRestoran : Form
    {
        private readonly RestoranBussiness restoranBussiness;
        public FormRestoran()
        {
            this.restoranBussiness = new RestoranBussiness();
            InitializeComponent();
        }

        private void FormRestoran_Load(object sender, EventArgs e)
        {
            FillList();
        }

        public void FillList()
        {
            listBoxIspis.Items.Clear();

            List<Restoran> restotans = this.restoranBussiness.GetAllRestorans();

            foreach (Restoran r in restotans)
            {
                listBoxIspis.Items.Add(r.Id + "." + r.Naziv + "," + r.Opis + "," + r.Cena + " ");
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Restoran r = new Restoran();
            r.Naziv = textBoxNaziv.Text;
            r.Opis = textBoxOpis.Text;
            r.Cena = Convert.ToDecimal(textBoxCena.Text);

            bool result = this.restoranBussiness.Insertrestoran(r);

            if(result)
            {
                FillList();
                MessageBox.Show("Uspesan unos!");
                textBoxNaziv.Text = " ";
                textBoxOpis.Text = " ";
                textBoxCena.Text = " ";

            }
            else
            {
                MessageBox.Show("Neuspesan unos!");
            }

        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            decimal min, max;
            min = Convert.ToDecimal(textBoxMin.Text);
            max = Convert.ToDecimal(textBoxMax.Text);

            listBoxIspis.Items.Clear();

            List<Restoran> restotans = this.restoranBussiness.GetRestoransWith(min, max);

            foreach (Restoran r in restotans)
            {
                listBoxIspis.Items.Add(r.Id + "." + r.Naziv + "," + r.Opis + "," + r.Cena + " ");
            }

            textBoxMin.Text = " ";
            textBoxMax.Text = " ";

        }
    }
}

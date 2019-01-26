using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectToMysqlDatabase;

namespace FormGepek
{
    public partial class Form1 : Form
    {
        private bool lettModositva = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattal();
            beallitVezerloketNemSzerkeszthetoAdateleressel();
        }

        private void beallitVezerloketNemSzerkeszthetoAdateleressel()
        {
            //gombok beállítása
            buttonNew.Visible = true;
            buttonEdit.Visible = true;
            buttonDelete.Visible = true;
            buttonSave.Visible = false;

            //dataGridView beállítása
            dataGridViewGepek.ReadOnly = true;
            dataGridViewGepek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGepek.AllowUserToDeleteRows = false;

            buttonNew.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;

            lettModositva = false;

        }

        private void feltoltVezerlotAdatbazisbolMindenAdattal()
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas();
            mdi.open();
            gepekDT = mdi.getToDataTable("SELECT * FROM gepek");
            dataGridViewGepek.DataSource = gepekDT;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beallitVezerloketIndulaskor();
        }

        private void beallitVezerloketIndulaskor()
        {
            buttonNew.Visible = false;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
            buttonNewGep.Visible = false;
        }

        private MySQLDatabaseInterface mdi;

        private DataTable gepekDT;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            beallitVezerloketDataGridViewSzerkesztoUzemmodba();
        }

        private void beallitVezerloketDataGridViewSzerkesztoUzemmodba()
        {
            //gombok beállítása     
            buttonNew.Visible = false;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            buttonSave.Visible = true;

            //dataGridView beállítása 
            dataGridViewGepek.ReadOnly = false;
            dataGridViewGepek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGepek.AllowUserToDeleteRows = false;

            //új gombot kell felvenni, mert a szerkesztés akár megszakítható is     
            buttonCancel.Visible = true;

            //módosítás beállítása     
            lettModositva = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattal();
            beallitVezerloketNemSzerkeszthetoAdateleressel();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!lettModositva)
            {
                MessageBox.Show("Nem lett módosítva egy adat sem.", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mdi.updateChangesInTable(gepekDT);
                beallitVezerloketNemSzerkeszthetoAdateleressel();

                buttonNew.Enabled = true;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            if (lettModositva)
            {
                if (MessageBox.Show("Nem mentett adatok vannak! Valóban ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mdi.close();
                    this.Close();
                }
            }
            else
            {
                mdi.close();
                this.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {         //meghatározzuk a kijelölt sort         
                int sor = dataGridViewGepek.SelectedRows[0].Index;
                if (MessageBox.Show("Valóban törölni akarja a sort?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //töröljük a sort a DataGridView-ból
                    dataGridViewGepek.Rows.RemoveAt(sor);
                    //Lehetővé tesszük a mentést
                    buttonSave.Visible = true;
                    lettModositva = true;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jelölje ki a törlendő sort!", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void beallitVezerloketUjAdatfelvitelkor()
        {
            buttonNew.Visible = false;
            buttonSave.Enabled = true;
            buttonSave.Visible = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCancel.Visible = true;
            buttonCancel.Enabled = true;
            dataGridViewGepek.AllowUserToAddRows = true;
            dataGridViewGepek.SelectionMode = DataGridViewSelectionMode.CellSelect;

            buttonSave.Visible = true;
            buttonNewGep.Visible = true;

            this.ActiveControl = textBoxGyarto;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            beallitVezerloketUjAdatfelvitelkor();
            int sor = dataGridViewGepek.Rows.Count - 1;
            dataGridViewGepek.Rows[sor].Cells[1].Selected = true;
            dataGridViewGepek.Rows[sor].Cells[1].Value = "Írja ide az új adatot";
            dataGridViewGepek.ReadOnly = false;
            for (int i = 0; i < sor; i = i + 1)
                dataGridViewGepek.Rows[i].ReadOnly = true;
            dataGridViewGepek.FirstDisplayedScrollingRowIndex = sor;
            dataGridViewGepek.Columns[0].ReadOnly = true;
        }

        private void dataGridViewGepek_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //Készítünk egy új kapcsolatot az adatbázishoz     
            Adatbazis ujida = new Adatbazis();
            MySQLDatabaseInterface mdiujid = ujida.kapcsolodas();
            mdiujid.open();
            //Készítünk egy lekérdezést az új halid meghatározására     
            int max;
            bool siker = int.TryParse(mdiujid.executeScalarQuery("SELECT MAX(id) FROM gepek"), out max);
            if (!siker)
            {
                MessageBox.Show("Nem lehet megállapítani a következő rekord kulcsát. Adatbázis lekérdezési hiba.", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mdiujid.close();
            e.Row.Cells[0].Value = max + 1;


        }

        private void dataGridViewGepek_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lettModositva = true;
        }


        private void kiolvasAdatokat(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridViewGepek_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void dataGridViewGepek_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridViewGepek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sor = dataGridViewGepek.SelectedRows[0].Index;
            int gepid = Convert.ToInt32(dataGridViewGepek.Rows[sor].Cells["id"].Value);

            ClassGepek g = new ClassGepek(
                Convert.ToInt32(dataGridViewGepek.SelectedRows[0].Cells["id"].Value),
                dataGridViewGepek.SelectedRows[0].Cells["gyarto"].Value.ToString(),
                dataGridViewGepek.SelectedRows[0].Cells["sorozat"].Value.ToString(),
                dataGridViewGepek.SelectedRows[0].Cells["tipus"].Value.ToString(),
                Convert.ToInt32(dataGridViewGepek.SelectedRows[0].Cells["tipusId"].Value),
                Convert.ToDouble(dataGridViewGepek.SelectedRows[0].Cells["pixel"].Value),
                dataGridViewGepek.SelectedRows[0].Cells["szenzor"].Value.ToString(),
                dataGridViewGepek.SelectedRows[0].Cells["objektiv"].Value.ToString(),
                Convert.ToInt32(dataGridViewGepek.SelectedRows[0].Cells["ar"].Value));


            FormModosit fm = new FormModosit(g);

            if (fm.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Sikeres módosítás!");
                ClassGepek modositottGepek = fm.getModositottGepek();

                Adatbazis updateDatabase = new Adatbazis();
                MySQLDatabaseInterface umdi = updateDatabase.kapcsolodas();
                umdi.open(); string query = "";
                query += "UPDATE gepek ";
                query += "SET gyarto=\"" + modositottGepek.getGyarto() + "\"";
                query += ", sorozat=\"" + modositottGepek.getSorozat() + "\"";
                query += ", tipus=\"" + modositottGepek.getTipus() + "\"";
                query += ", tipusId=\"" + modositottGepek.getTipusId() + "\"";
                query += ", pixel=" + modositottGepek.getPixel();
                query += ", szenzor=\"" + modositottGepek.getSzenzor() + "\"";
                query += ", objektiv=\"" + modositottGepek.getObjektiv() + "\"";
                query += ", ar=" + modositottGepek.getAr();
                query += " WHERE id=" + modositottGepek.getId();


                umdi.executeDMQuery(query);

                MessageBox.Show("Sikeres módosítás:" + modositottGepek.ToString()); umdi.close();

                dataGridViewGepek.Rows[sor].Cells["gyarto"].Value = modositottGepek.getGyarto();
                dataGridViewGepek.Rows[sor].Cells["sorozat"].Value = modositottGepek.getSorozat();
                dataGridViewGepek.Rows[sor].Cells["tipus"].Value = modositottGepek.getTipus();
                dataGridViewGepek.Rows[sor].Cells["tipusId"].Value = modositottGepek.getTipusId();
                dataGridViewGepek.Rows[sor].Cells["pixel"].Value = modositottGepek.getPixel();
                dataGridViewGepek.Rows[sor].Cells["szenzor"].Value = modositottGepek.getSzenzor();
                dataGridViewGepek.Rows[sor].Cells["objektiv"].Value = modositottGepek.getObjektiv();
                dataGridViewGepek.Rows[sor].Cells["ar"].Value = modositottGepek.getAr();
            }
        }

        private void buttonNewGep_Click(object sender, EventArgs e)
        {
            Adatbazis ujida = new Adatbazis();
            MySQLDatabaseInterface mdiujid = ujida.kapcsolodas();
            mdiujid.open();
            int Id = Convert.ToInt32(mdiujid.executeScalarQuery("SELECT MAX(id) FROM gepek"));
            int ujId = Id + 1;
            mdiujid.close();

            string gyarto = textBoxGyarto.Text;
            string sorozat = textBoxSorozat.Text;
            string tipus = textBoxTipus.Text;
            int tipusId = Convert.ToInt32(textBoxTipusId.Text);
            double pixel = Convert.ToDouble(textBoxPixel.Text);
            string szenzor = textBoxSzenzor.Text;
            string objektiv = textBoxObjektiv.Text;
            int ar = Convert.ToInt32(textBoxAr.Text);

            Adatbazis updateDatabase = new Adatbazis();
            MySQLDatabaseInterface umdi = updateDatabase.kapcsolodas();
            umdi.open(); string query = "";
            query += "INSERT INTO gepek (id,gyarto,sorozat,tipus,tipusId,pixel,szenzor,objektiv,ar) VALUES ";
            query += "(" + ujId + ", ";
            query += "\"" + gyarto + "\", ";
            query += "\"" + sorozat + "\", ";
            query += "\"" + tipus + "\", ";
            query +=  tipusId + ", ";
            query +=  pixel + ", ";
            query += "\"" + szenzor + "\", ";
            query += "\"" + objektiv + "\", ";
            query += ar + ")";
            umdi.executeDMQuery(query);

            MessageBox.Show(query);

            MessageBox.Show("Sikeres Adatfelvétel");
            umdi.close();

            int sor = dataGridViewGepek.Rows.Count - 1;

            dataGridViewGepek.Rows[sor].Cells["id"].Value = ujId;
            dataGridViewGepek.Rows[sor].Cells["gyarto"].Value = gyarto;
            dataGridViewGepek.Rows[sor].Cells["sorozat"].Value = sorozat;
            dataGridViewGepek.Rows[sor].Cells["tipus"].Value = tipus;
            dataGridViewGepek.Rows[sor].Cells["tipusId"].Value = tipusId;
            dataGridViewGepek.Rows[sor].Cells["pixel"].Value = pixel;
            dataGridViewGepek.Rows[sor].Cells["szenzor"].Value = szenzor;
            dataGridViewGepek.Rows[sor].Cells["objektiv"].Value = objektiv;
            dataGridViewGepek.Rows[sor].Cells["ar"].Value = ar;

            feltoltVezerlotAdatbazisbolMindenAdattal();
        }
    }
}

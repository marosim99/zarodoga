using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGepek
{
    internal partial class FormModosit : Form
    {
        private ClassGepek gepek;

        public FormModosit(ClassGepek g)
        {
            InitializeComponent();
            this.gepek = g;
            megjelenitGepAdatokat();
        }

        public ClassGepek getModositottGepek()
        {
            return gepek;
        }


        private void megjelenitGepAdatokat()
        {
            textBoxGyarto.Text = gepek.getGyarto();
            textBoxSorozat.Text = gepek.getSorozat();
            textBoxTipus.Text = gepek.getTipus();
            textBoxTipusId.Text = gepek.getTipusId().ToString();
            textBoxPixel.Text = gepek.getPixel().ToString();
            textBoxSzenzor.Text = gepek.getSzenzor();
            textBoxObjektiv.Text = gepek.getObjektiv();
            textBoxAr.Text = gepek.getAr().ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            gepek.setGyarto(textBoxGyarto.Text);
            gepek.setSorozat(textBoxSorozat.Text);
            gepek.setTipus(textBoxTipus.Text);
            gepek.setTipusId(Convert.ToInt32(textBoxTipusId.Text));
            gepek.setPixel(Convert.ToDouble(textBoxPixel.Text));
            gepek.setSzenzor(textBoxSzenzor.Text);
            gepek.setObjektiv(textBoxObjektiv.Text);
            gepek.setAr(Convert.ToInt32(textBoxAr.Text));
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

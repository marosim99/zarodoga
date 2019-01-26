using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGepek
{
    class ClassGepek
    {
        private int id;
        private string gyarto;
        private string sorozat;
        private string tipus;
        private int tipusId;
        private double pixel;
        private string szenzor;
        private string objektiv;
        private int ar;

        public ClassGepek(int id, string gyarto, string sorozat, string tipus, int tipusId, double pixel, string szenzor, string objektiv, int ar)
        {
            this.id = id;
            this.gyarto = gyarto;
            this.sorozat = sorozat;
            this.tipus = tipus;
            this.tipusId = tipusId;
            this.pixel = pixel;
            this.szenzor = szenzor;
            this.objektiv = objektiv;
            this.ar = ar;
        }

        public ClassGepek(int id)
        {
            this.id = id; //itt
            this.gyarto = string.Empty;
            this.sorozat = string.Empty;
            this.tipus = string.Empty;
            this.tipusId = 1;
            this.pixel = 1;
            this.szenzor = string.Empty;
            this.objektiv = string.Empty;
            this.ar = 1;
        }

        public int getId()
        {
            return id;
        }

        public string getGyarto()
        {
            return gyarto;
        }

        public string getSorozat()
        {
            return sorozat;
        }

        public string getTipus()
        {
            return tipus;
        }

        public int getTipusId()
        {
            return tipusId;
        }

        public double getPixel()
        {
            return pixel;
        }

        public string getSzenzor()
        {
            return szenzor;
        }

        public string getObjektiv()
        {
            return objektiv;
        }

        public int getAr()
        {
            return ar;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setGyarto(string gyarto)
        {
            this.gyarto = gyarto;
        }

        public void setSorozat(string sorozat)
        {
            this.sorozat = sorozat;
        }

        public void setTipus(string tipus)
        {
            this.tipus = tipus;
        }

        public void setTipusId(int tipusId)
        {
            this.tipusId = tipusId;
        }

        public void setPixel(double pixel)
        {
            this.pixel = pixel;
        }

        public void setSzenzor(string szenzor)
        {
            this.szenzor = szenzor;
        }

        public void setObjektiv(string objektiv)
        {
            this.objektiv = objektiv;
        }

        public void setAr(int ar)
        {
            this.ar = ar;
        }
    }
}

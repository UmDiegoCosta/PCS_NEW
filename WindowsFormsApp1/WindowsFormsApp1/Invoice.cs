using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Invoice
    {
        public int pNo { get; set; }
        public string pCode { get; set; }
        public string pDesc { get; set; }
        public double pPrice { get; set; }
        public int pQty { get; set; }

        public string eName { get; set; }

        public int cNo { get; set; }
        public string cName { get; set; }
        public string cPhone { get; set; }
        public string cShipAd { get; set; }
        public string cShipCity { get; set; }
        public string cChipZip { get; set; }
        public string cBillAd { get; set; }
        public string cBillCity { get; set; }
        public string cBillZip { get; set; }

    }
}

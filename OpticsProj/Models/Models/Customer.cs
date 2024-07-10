using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Customer
    {
        //Costumers Details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Id { get; set; }
        public string Phone { get; set; }
        public DateTime PurchaseDate { get; set; }

        //Glasses details
        public string GModel { get; set; }
        public int GPD { get; set; }
        //Right Eye
        public string GRnumber { get; set; }
        public string GRCyilinder { get; set; }
        public int  GRAxis { get; set; }
        public string GRAddition { get; set; }
        public string GRPrizma { get; set; }
        public double GRIndex { get; set; }
        //Left Eye
        public string GLnumber { get; set; }
        public string GLCyilinder { get; set; }
        public int GLRAxis { get; set; }
        public string GLAddition { get; set; }
        public string GLPrizma { get; set; }
        public double GLIndex { get; set; }
        


        //Contact Lenses
        //Right Eye
        public string Rnumber { get; set; }
        public string RCyilinder { get; set; }
        public int RAxis { get; set; }
        public double RBC { get; set; }
        //Left Eye
        public string lnumber { get; set; }
        public string LCyilinder { get; set; }
        public int LAxis { get; set; }
        public double LBC { get; set; }



        //Prev number
        //Glasses details
        public int PreGPD { get; set; }
        //Right Eye
        public string PreGRnumber { get; set; }
        public string PreGRCyilinder { get; set; }
        public int PreGRAxis { get; set; }
        public string PreGRAddition { get; set; }
        public string PreGRPrizma { get; set; }
        public double PreGRIndex { get; set; }
        //Left Eye
        public string PreGLnumber { get; set; }
        public string PreGLCyilinder { get; set; }
        public int PreGLRAxis { get; set; }
        public string PreGLAddition { get; set; }
        public string PreGLPrizma { get; set; }
        public double PreGLIndex { get; set; }


    }
}

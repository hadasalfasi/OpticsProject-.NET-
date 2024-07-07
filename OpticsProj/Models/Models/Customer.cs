using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    internal class Customer
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
        public double GRnumber { get; set; }
        public double GRCyilinder { get; set; }
        public int  GRAxis { get; set; }
        public double GRAddition { get; set; }
        public double GRPrizma { get; set; }
        public double GRIndex { get; set; }
        //Left Eye
        public double GLnumber { get; set; }
        public double GLCyilinder { get; set; }
        public int GLRAxis { get; set; }
        public double GLAddition { get; set; }
        public double GLPrizma { get; set; }
        public double GLIndex { get; set; }
        


        //Contact Lenses
        //Right Eye
        public double Rnumber { get; set; }
        public double RCyilinder { get; set; }
        public int RAxis { get; set; }
        public double RBC { get; set; }
        //Left Eye
        public double lnumber { get; set; }
        public double LCyilinder { get; set; }
        public int LAxis { get; set; }
        public double LBC { get; set; }



        //Prev number
        //Glasses details
        public int PreGPD { get; set; }
        //Right Eye
        public double PreGRnumber { get; set; }
        public double PreGRCyilinder { get; set; }
        public int PreGRAxis { get; set; }
        public double PreGRAddition { get; set; }
        public double PreGRPrizma { get; set; }
        public double PreGRIndex { get; set; }
        //Left Eye
        public double PreGLnumber { get; set; }
        public double PreGLCyilinder { get; set; }
        public int PreGLRAxis { get; set; }
        public double PreGLAddition { get; set; }
        public double PreGLPrizma { get; set; }
        public double PreGLIndex { get; set; }


    }
}

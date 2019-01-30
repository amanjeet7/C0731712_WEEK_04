using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731712
{
    class Program
    {
        static void Main(string[] args)
        {


        }


    }
    class village
    {
        // Node ia an ADT
        // what kind of data do we need in a NODE?
        public village nextvillage;
        public village previousvillage;
        public string villagename;
            public bool isastrildehere = false;
    }
    class countryside
    {
        village maple = new village();
       
        village toronto = new village();
        
        village ajax = new village();
        village first;
        village last;


        public void Launch()
        {
            maple.villagename = "maple";
            maple.nextvillage = toronto;
            maple.previousvillage = null;
            toronto.villagename = "toonto";
            toronto.nextvillage = ajax;
            toronto.previousvillage = maple;
            ajax.villagename = "ajax";
            ajax.nextvillage = null;
            ajax.nextvillage = toronto;
        } 
    }
}

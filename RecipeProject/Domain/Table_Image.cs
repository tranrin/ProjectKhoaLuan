using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Table_Image
    {
       public int ID { get; set; }
        public string URL { get; set; }
        public int CongThucID { get; set; }
    }
}

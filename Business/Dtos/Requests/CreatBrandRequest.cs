using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests;

public class CreatBrandRequest
{
    public string Name { get; set; }  // son müşteriden ne istiyorum onu yazdık Id falan olmaz müşteri bilemez o veritabanının işidir
}

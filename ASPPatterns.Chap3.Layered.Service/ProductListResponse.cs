using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASPPatterns.Chap3.Layered.Model;

namespace ASPPatterns.Chap3.Layered.Service
{
    public class ProductListResponse
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public IList<ProductViewModel> Products { get; set; }
    }
}

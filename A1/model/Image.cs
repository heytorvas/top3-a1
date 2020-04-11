using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.model
{
    public class Image
    {
        private int id;
        private String url;

        public string Url { get => url; set => url = value; }
        public int Id { get => id; set => id = value; }
    }
}

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Site_parsing
{
    internal class Program
    {
        static void Main(string[] args) => Parsing();
        public static void Parsing()
        {
            Auth_form.Get_us_tok();
            Auth_form.Complete();
            Vkont_api.Get_inf();
        }
    }
}
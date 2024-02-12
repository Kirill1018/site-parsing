using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site_parsing
{
    internal class Vkont_api
    {
        public const string app_id = "51851303",
            vkont_api_url = "https://dev.vk.com/ru/method/friends.get";
        public static string token;
        public Vkont_api(string acc_tok) { token = acc_tok; }
        public static Dictionary<string, string> Get_inf()
        {
            HTTPRequest.HttpRequest request = new HTTPRequest.HttpRequest();
            string us_id = "663365991",
                acc_tok = "vk1.a.omLYbRMx_AzKkwffUKsWrhEw5DvfSPMBTe5k2BMuszGeJbhzSiMjTkpnto8zNQxhU0-O-Qz73kmvuVrIslJ0WzUMSZcBIV1xbo9kfxGK2YbrMAwMyFT8hga68wwvoSkT5hdszFAmfRXCjCNHZFqZoRuYdUWz011Xj4cnrtgbpwiQmxvD-ub2oa7EE9M-OmjC";
            request.AppendHeader("user_id", us_id);
            request.AppendHeader("access_token", acc_tok);
            string result = vkont_api_url.Substring(13, vkont_api_url.Length - 15);
            Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            Console.WriteLine(dictionary);
            return dictionary;
        }
    }
}
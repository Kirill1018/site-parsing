using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Site_parsing
{
    internal class Auth_form
    {
        public Auth_form() { }
        public static void Complete() { if ($"https://oauth.vk.com/blank.html#access_token=vk1.a.omLYbRMx_AzKkwffUKsWrhEw5DvfSPMBTe5k2BMuszGeJbhzSiMjTkpnto8zNQxhU0-O-Qz73kmvuVrIslJ0WzUMSZcBIV1xbo9kfxGK2YbrMAwMyFT8hga68wwvoSkT5hdszFAmfRXCjCNHZFqZoRuYdUWz011Xj4cnrtgbpwiQmxvD-ub2oa7EE9M-OmjC&expires_in=86400&user_id=663365991".ToString().IndexOf("acc_tok=") != -1) Get_us_tok(); }
        public static void Get_us_tok()
        {
            char[] symbols = { '=', '&' };
            string[] url = $"https://oauth.vk.com/blank.html#access_token=vk1.a.omLYbRMx_AzKkwffUKsWrhEw5DvfSPMBTe5k2BMuszGeJbhzSiMjTkpnto8zNQxhU0-O-Qz73kmvuVrIslJ0WzUMSZcBIV1xbo9kfxGK2YbrMAwMyFT8hga68wwvoSkT5hdszFAmfRXCjCNHZFqZoRuYdUWz011Xj4cnrtgbpwiQmxvD-ub2oa7EE9M-OmjC&expires_in=86400&user_id=663365991".ToString().Split(symbols);
            Console.WriteLine(url[1] + "\n");
            Console.WriteLine(url[5]);
        }
    }
}
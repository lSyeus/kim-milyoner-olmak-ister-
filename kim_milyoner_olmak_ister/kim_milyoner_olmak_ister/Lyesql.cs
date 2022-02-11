using System;
using System.Windows.Forms;
using System.Configuration;

namespace kim_milyoner_olmak_ister
{

    class lyesql
    {
        public static string sqlconnection = ConfigurationManager.ConnectionStrings["kim_milyoner_olmak_ister.Properties.Settings.lyesqlConnectionString3"].ConnectionString;
            
        //"Data Source=DESKTOP-D8U9370;Initial Catalog=lyesql;Integrated Security=True";
    }

}
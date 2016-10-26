using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class MySettings
    {
        public static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
    }
}

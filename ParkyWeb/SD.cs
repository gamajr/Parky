using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyWeb
{
    public class SD
    {
        public static string APIBaseUrl = "https://localhost:44329/";
        public static string NationalParkAPIPath = APIBaseUrl + "api/v1/nationalparks/";
        public static string TrailAPIPath = APIBaseUrl + "api/v1/trails/";
        public static string UserAPIPath = APIBaseUrl + "api/v1/users/";
    }
}

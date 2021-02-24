using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSoft.Helper
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, string value)
        {
            session.SetString(key, (value));
        }

        public static string GetObjectFromJson(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value;
        }
    }
}

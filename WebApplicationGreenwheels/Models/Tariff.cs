using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationGreenwheels
{
    public partial class Tariff
    {
        public static List<Tariff> GetAllTariffs()
        {
            GreenwheelsEntities context = new GreenwheelsEntities();

            return context.Tariffs.ToList();
        }

    }
}
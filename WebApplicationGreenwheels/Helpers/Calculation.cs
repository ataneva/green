using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplicationGreenwheels;

namespace WebApplicationGreenwheel.Helpers
{
    public class Calculation
    {
        public decimal SumTotal { get; set; }

        public string Subscription { get; set; }

        [RegularExpression("([0-9]*)", ErrorMessage = "Km must be a natural number")]
        public int Km { get; set; }

        [RegularExpression("([0-9]*)", ErrorMessage = "Hours must be a natural number")]
        public int Hours { get; set; }

        public static Calculation CalculateTariff(int hours, int km, string carType)
        {
            Calculation result = new Calculation();
            result.SumTotal = decimal.MaxValue;
            result.Subscription = "occasional"; //default

            try

            {
                var filteredTariffs = Tariff.GetAllTariffs().Where(x => x.TypeVehicle.Vehicle.ToLower().Equals(carType.ToLower()));

                foreach (var item in filteredTariffs)
                {
                    decimal sum = item.PriceHour * hours + item.PriceKm * km + item.TypeSubscription.PerMonth ?? 0;

                    if (sum < result.SumTotal)
                    {
                        result.SumTotal = sum;
                        result.Subscription = item.TypeSubscription.Subscription;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }

            return result;
        }
        
    }
}
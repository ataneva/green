//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationGreenwheels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tariff
    {
        public int Id { get; set; }
        public decimal PriceKm { get; set; }
        public decimal PriceHour { get; set; }
        public int VehicleID { get; set; }
        public int SubsciptionID { get; set; }
    
        public virtual TypeSubscription TypeSubscription { get; set; }
        public virtual TypeVehicle TypeVehicle { get; set; }
    }
}
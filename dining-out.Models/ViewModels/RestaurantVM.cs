using System;
namespace dining_out.Models.ViewModels
{
    public class RestaurantVM
    {
        public RestaurantVM(){}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string CoverImg { get; set; }
        public int? UserId { get; set; }
        public string SystemDefinitionName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public string Address { get; set; }
        public int? Capacity { get; set; }
        public string Logo { get; set; }

    }
}

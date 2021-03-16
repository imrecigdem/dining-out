using System;
namespace dining_out.Models.ViewModels
{
    public class BookTableRezervationVM
    {
        public BookTableRezervationVM()
        {
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string RezervationUserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string NameLastname { get; set; }
        public string RezervationStatus { get; set; }
        public String RezervationDate { get; set; }
        public String RezervationTime { get; set; }
        public string RestaurantName { get; set; }
        public int AttendeeNumber { get; set; }
        public DateTime RezervationCreatedDatetime { get; set; }
    }
}

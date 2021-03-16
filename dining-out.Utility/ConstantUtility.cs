using System;
namespace dining_out.Utility
{
    public static class ConstantUtility
    {
        public enum RezervationStatus
        {
            NEW,APPROVED,CANCELLED,CLOSED
        }

        public static string textValueOfRezervationStatus(string rezervationStatus)
        {
            if (RezervationStatus.NEW.ToString().Equals(rezervationStatus))
            {
                return "Yeni";
            }
            if (RezervationStatus.APPROVED.ToString().Equals(rezervationStatus))
            {
                return "Onaylandı";
            }
            if (RezervationStatus.CANCELLED.ToString().Equals(rezervationStatus))
            {
                return "İptal";
            }
            if (RezervationStatus.CLOSED.ToString().Equals(rezervationStatus))
            {
                return "Kapandı";
            }
            return "";

        }

        public enum UserType
        {
            CUSTOMER, RESTAURANT
        }
    }
}

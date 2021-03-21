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

        public static bool IsRezervationStatusNEW(string rezervationStatus)
        {
            if (RezervationStatus.NEW.ToString().Equals(rezervationStatus))
            {
                return true;
            }
            return false;

        }

        public static bool IsRezervationStatusAPPROVED(string rezervationStatus)
        {
            if (RezervationStatus.APPROVED.ToString().Equals(rezervationStatus))
            {
                return true;
            }
            return false;

        }

        public static bool IsRezervationStatusCANCELLED(string rezervationStatus)
        {
            if (RezervationStatus.CANCELLED.ToString().Equals(rezervationStatus))
            {
                return true;
            }
            return false;

        }

        public static bool IsRezervationStatusCLOSED(string rezervationStatus)
        {
            if (RezervationStatus.CLOSED.ToString().Equals(rezervationStatus))
            {
                return true;
            }
            return false;

        }

        public enum UserType
        {
            CUSTOMER, RESTAURANT
        }
    }
}

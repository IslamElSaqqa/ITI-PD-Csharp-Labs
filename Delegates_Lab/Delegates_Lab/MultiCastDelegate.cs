using System;

namespace Delegates_Lab
{
    public static class MultiCastDelegateClass
    {
        // Send Email
        public static string SendEmail(string s) {
            return $"Email sent: {s}";
        }

        // Send SMS
        public static string SendSMS(string s)
        {
            return $"SMS sent: {s}";
        }

        // LogToFile

        public static string LogToFile(string s)
        {
            return $"Logged: {s}";
        }


    }
}

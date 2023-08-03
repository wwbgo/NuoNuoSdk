namespace NuoNuoSdk
{
    public static class NuoNuoSdkExtension
    {
        public static string ToInvoiceDatString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}

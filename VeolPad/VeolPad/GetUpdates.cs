using System.Net;

namespace VeolPad
{
    internal class GetUpdates
    {
        internal static bool Verify()
        {
            WebClient Client = new WebClient();
            string TempFile = System.IO.Path.GetTempFileName();
            string LastedVersionURL = "https://bit.ly/3uTzDPx";
            Client.DownloadFile(LastedVersionURL, TempFile);
            string LastGettedVersion = System.IO.File.ReadAllText(TempFile);
            bool Anw;
            if (LastGettedVersion == "v1.1")
                Anw = false;
            else
                Anw = true;
            return Anw;
        }
    }
}

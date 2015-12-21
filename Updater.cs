using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ReplayEditor
{
    public class Updater
    {
        private static string VersionHash = "NFWmDUCPtV9i4Ifr84A2f6gisxEjP70o";

        public static bool CheckForUpdate()
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(new Uri("https://raw.githubusercontent.com/thebetioplane/OsuReplayEditor/master/VersionHash.txt"));
                WebResponse webResponse = webRequest.GetResponse();
                return Updater.ReadFromStream(webResponse.GetResponseStream()) != Updater.VersionHash;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DownloadUpdate(string file)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://github.com/thebetioplane/OsuReplayEditor/raw/master/bin/Release/ReplayEditor.exe", file);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static string ReadFromStream(Stream stream)
        {
            byte[] buff = new byte[32];
            int k = stream.Read(buff, 0, buff.Length);
            string msg = "";
            for (int i = 0; i < k; i++)
            {
                msg += Convert.ToChar(buff[i]);
            }
            return msg;
        }
    }
}

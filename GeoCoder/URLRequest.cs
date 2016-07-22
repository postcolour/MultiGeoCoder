using System;
using System.IO;
using System.Net;
using System.Web;
using System.Windows.Forms;


namespace MultiGeoCoder
{
    public class URLRequest
    {
        /// <summary>
        /// Method to return response from web request
        /// </summary>
        public void WebRequestGet(ref string sAddr, ref string sLoc)
        {
            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create("https://geocode-maps.yandex.ru/1.x/?results=1&geocode=" +
                                                                      HttpUtility.UrlEncode(sAddr) + "&lang=" + 
                                                                      HttpUtility.UrlEncode(sLoc));
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;

                // for proxy authentication
                var proxy = WebRequest.GetSystemWebProxy();
                var cr = new NetworkCredential("user", "pass", "domain");
                proxy.Credentials = cr;
                request.Proxy = proxy;

                // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Display the status.
                Console.WriteLine(response.StatusDescription);

                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();

                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);

                // Read the content.
                sAddr = reader.ReadToEnd();

                // Cleanup the streams and the response.
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sAddr = string.Empty;
            }
        }
    }
}

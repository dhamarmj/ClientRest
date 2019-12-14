using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create("http://localhost:4567/api/url/");
            webrequest.Method = "GET";
            webrequest.ContentType = "application/json";
            Stream stream = webrequest.GetRequestStream();
            stream.Close();
            string result;
            using (WebResponse response = webrequest.GetResponse()) 
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    result = reader.ReadToEnd();
                    Console.WriteLine(Convert.ToString(result));
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace QuickMonery.Common
{
    public class HttpHelper
    {
        public static string service = ConfigurationManager.AppSettings["services"].ToString();
        public static string HttpPost(string Url, string postDataStr = "")
        {

            Url = service + Url;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";


            request.UserAgent = "User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Trident/4.0; QQDownload 534; TencentTraveler 4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; CIBA; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; InfoPath.2)";


            byte[] postData = System.Text.Encoding.UTF8.GetBytes(postDataStr);

            request.ContentLength = postData.Length;

            Stream writer = request.GetRequestStream();
            writer.Write(postData, 0, postData.Length);
            writer.Close();

            HttpWebResponse response;
            try
            {

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (System.Net.WebException ex)
            {
                throw ex;
            }

            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码  
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            return retString;
        }
        public static JObject HttpPostToJson(string Url, string postDataStr = "")
        {
            string responseText = HttpPost(Url, postDataStr);
            return JObject.Parse(responseText);

        }
        public static JObject HttpPostToJson(string Url, params string[] postData)
        {

            string sb = "";


            for (int i = 0; i < postData.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb += postData[i];
                    sb += "=";
                }
                else
                {
                    sb += Uri.EscapeDataString(postData[i]);
                    sb += "&";
                }
            }


            string responseText = HttpPost(Url, sb);
            return JObject.Parse(responseText);

        }
    }
}

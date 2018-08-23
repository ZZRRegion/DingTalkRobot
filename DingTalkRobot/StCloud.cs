using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using System.IO;

namespace DingTalkRobot
{
    public static class StCloud
    {
        public static string Post(string url, string paraUrlCoded)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";

            byte[] payload = Encoding.UTF8.GetBytes(paraUrlCoded);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stm = response.GetResponseStream();
            StreamReader Reader = new StreamReader(stm, Encoding.UTF8);
            string resp = Reader.ReadToEnd();
            return resp;
        }
    }
}

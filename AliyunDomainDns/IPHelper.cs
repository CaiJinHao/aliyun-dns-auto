using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DomainNameResolution;
using Newtonsoft.Json;

namespace AliyunDomainDns
{
    public static class IPHelper
    {
        private static readonly HttpClient client = new HttpClient();

        /*public static async Task<string> GetIP_Sohu()
        {
            CitySN ipObj = null;
            try
            {
                //var responseMessage = await client.GetAsync("http://pv.sohu.com/cityjson");
                //var responseStream = await responseMessage.Content.ReadAsStreamAsync();
                ////Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                //var encodeList = Encoding.GetEncodings();
                //var encode = Encoding.GetEncoding("gbk");
                //var responseText = new StreamReader(responseStream, encode).ReadToEnd();

                //var startIndex = 18;

                //var ip = responseText.Substring(startIndex);

                //ip = ip.Trim();
                //ip = ip.Trim(';');

                //ipObj = JsonConvert.DeserializeObject<CitySN>(ip);
            }
            catch (Exception e)
            {
                //logger.LogError(e, e.Message);
                return null;
            }
            
            return ipObj?.cip;
        }*/

        public static async Task<string> GetIP_Amazon()
        {
            var responseMessage = await client.GetAsync("http://checkip.amazonaws.com");
            var ip = (await responseMessage.Content.ReadAsStringAsync()).Trim('\n');
            if (!IsIP(ip))
            {
                throw new Exception("IP返回值异常");
            }
            return ip;
        }

        private static bool IsIP(string ip)
        {
            return IPAddress.TryParse(ip, out var address);
        }
    }
}

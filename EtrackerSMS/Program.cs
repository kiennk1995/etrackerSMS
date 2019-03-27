using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EtrackerSMS
{
    class Program
    {
        private string url = "https://www.etracker.cc/bulksms/send";
        private string result = null;
        static void Main(string[] args)
        {
            string user = ConfigurationManager.AppSettings["user"];
            string pass = ConfigurationManager.AppSettings["pass"];

        }

        //public string ChoseMobile(string mobilephone,string phone)
        //{

        //}

        private async void SendSMS(SendSMSModel smsModel)
        {
            try
            {
                //Validation of all the Parameter before submitting API request
                string json = Json2KeyValue.JsonConvert.SerializeObject(smsModel);
                using (HttpClient clinet = new HttpClient())
                {
                    StringContent content = new StringContent(json);
                    content.Headers.ContentType.MediaType = "application/json";

                    clinet.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await clinet.PostAsync(new Uri(url), content);
                    response.EnsureSuccessStatusCode();

                    result = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {

            }
        }
    }
}

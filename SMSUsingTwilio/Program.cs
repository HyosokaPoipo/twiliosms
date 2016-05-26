using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
namespace SMSUsingTwilio
{
    class Program
    {
        static void Main(string[] args)
        {
            String ACCOUNT_SID = "AC043aeb2b44b3f2e8642f7827ec312b2b"; 
            String AUTH_TOKEN = "40b0693f7b856b3dbacf2ae16239c3e8";

            TwilioRestClient client = new TwilioRestClient(ACCOUNT_SID, AUTH_TOKEN);


            Message Response = client.SendMessage("(732)305-8856", "+6285798901128", "Hellow Hyosoka Poipo :D");

            Console.WriteLine(Response.Sid);
            Console.WriteLine(Response.Status);
            Console.WriteLine(Response.AccountSid);
            
            

            var messg = client.GetMessage("SMf4f6bccce2634d1fbd2f8383493031bf");
            Console.WriteLine(messg.Status);
            
            
            Console.WriteLine("SMS Berhasil di kirim");
            Console.ReadLine();

        }
    }
}

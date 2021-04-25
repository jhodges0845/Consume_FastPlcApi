using System;

namespace TestWebRequest
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var rest = new ConsumeRestApi.ConsumeRestApi();
            rest.EndPoint = "http://localhost:8000/ping/192.168.2.5";
            for (var i = 1; i < 5; i++)
            {
                rest.GetRequest();

                if (rest.Data != null)
                {
                    Console.WriteLine(rest.Data);
                }
                else
                {
                    Console.WriteLine(rest.Message);
                }
            }

            Console.Read();
        }
    }
}

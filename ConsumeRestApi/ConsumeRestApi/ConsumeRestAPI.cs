using System;
using System.Net;
using System.IO;

namespace ConsumeRestApi
{
    public class ConsumeRestApi
    {
        public string EndPoint { get; set; }

        public string Message { get; set; }

        public string Data { get; set; }

        public ConsumeRestApi() 
        {
            this.Data = null;
            this.Message = null;
        }

        public void GetRequest()
        {
            WebRequest request;
            request = WebRequest.Create(this.EndPoint);
            request.Timeout = 3000;

            try 
            {
                var response = request.GetResponse();

                Stream objSteam = response.GetResponseStream();

                StreamReader objReader = new StreamReader(objSteam);
                string sLine = "";
                int i = 0;
                while (sLine != null)
                {
                    i++;
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        this.Data =  sLine;
                    }
                }
                response.Close();
                // Send Logs

                this.Message = "Not able to connect to endpoint";
            }
            catch
            {
                // Send Logs

                this.Message =  "There was an error when creating a request.";
            }

        }

    }
}

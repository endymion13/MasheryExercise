using MasheryMVCExercise.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace MasheryMVCExercise.Common
{
    public class Connection
    {
        private string URLRequest { get; set; }
        private string IDUser { get; set; }
        private string keyAPI { get; set; }



        private Connection()
        {

        }

        //Request a API's service
        public Connection(int RequestNumber, String UserName)
        {
            this.keyAPI = WebConfigurationManager.AppSettings["keyAPI"];
            GetIDUser(UserName);    
            this.URLRequest = "http://api.klout.com/v2/user.json/" + this.IDUser + "/topics?key=" + keyAPI;


            switch (RequestNumber)
            {
                //Get Topics
                case 1:
                    this.URLRequest = "http://api.klout.com/v2/user.json/" + this.IDUser + "/topics?key=" + keyAPI;
                    break;
                //Get Influences
                case 2:
                    this.URLRequest = "http://api.klout.com/v2/user.json/" + this.IDUser + "/influence?key=" + keyAPI;
                    break;
                
            }

        }

        //Request a API's service
        public void GetIDUser(string UserName)
        {
            
           //Get User ID
           this.URLRequest = "http://api.klout.com/v2/identity.json/twitter?screenName=" + UserName + "&key=" + keyAPI;
           var jsonString = "";
           try
           {
               jsonString = GetJSON();
               var objects = JArray.Parse("["+jsonString+"]"); // parse as array  
               foreach (JObject root in objects)
               {

                   this.IDUser = (String)root["id"];
                      
                  
               }
           }
           catch (Exception ex)
           {
               jsonString = ex.ToString();
           }

          

        }


        public string GetJSON()
        {
            var result = "";
            try
            {
                using (WebClient wc = new System.Net.WebClient())
                {
                    result = wc.DownloadString(this.URLRequest);
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            return result;
        }
    }
}
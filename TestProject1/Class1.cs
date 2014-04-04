using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using SourceCode.Workflow.Management;
using SourceCode.Hosting.Client.BaseAPI;
using SourceCode.Workflow.Client;


namespace TestProject1
{
    public class Class1
    {
        static void WorkListItemAction(string SN, string actionName)
        {
            //string _connectionstring = "Integrated=True;IsPrimaryLogin=True;Authenticate=True;EncryptedPassword=False;Host=k2.denallix.com;Port=5555";
            string _connectionstring = "Integrated=True;IsPrimaryLogin=False;Authenticate=True;EncryptedPassword=False;Host=localhost;Port=5252";

            ConnectionSetup connectSetup = new ConnectionSetup();
            connectSetup.ConnectionString = _connectionstring;
            
            Connection _cnn = new Connection();
            _cnn.Open(connectSetup);

            string delimiter = ";";

            string[] SNs = SN.Split(Convert.ToChar(delimiter));


            bool a = String.IsNullOrEmpty(delimiter);


            foreach (string isn in SNs)
            {
                if (!String.IsNullOrEmpty(isn))
                {
                    WorklistItem item = _cnn.OpenWorklistItem(isn, "ASP", true, true);

                    foreach (SourceCode.Workflow.Client.Action act in item.Actions)
                    {
                        if (act.Name == actionName)
                            act.Execute();
                    }
                    
                }   
            }
            _cnn.Close();

                
            
            //// Create a new connection
            //wfManServ.CreateConnection();
            //// Open the connection
            //wfManServ.Connection.Open(_connectionString);

            /////*
            //bool R = true;
            //SCConnectionStringBuilder ConnStr = new SCConnectionStringBuilder();
            //ConnStr.Host = "localhost";
           

            //ConnStr.Integrated = true;
            //ConnStr.IsPrimaryLogin = true;
            //ConnStr.Authenticate = true;
            //ConnStr.Port = 5555;
            /*
           //ConnStr.Port = Convert.ToUInt32(new System.Configuration.AppSettingsReader().GetValue("K2Port", typeof(System.String)));
           //ConnStr.UserID = Convert.ToString(new System.Configuration.AppSettingsReader().GetValue("K2AdminUser", typeof(System.String)));
           //ConnStr.Password = Convert.ToString(new System.Configuration.AppSettingsReader().GetValue("K2AdminPass", typeof(System.String)));
           //ConnStr.SecurityLabelName = Convert.ToString(new System.Configuration.AppSettingsReader().GetValue("K2SecurityLabel", typeof(System.String)));
//            ConnStr.IsPrimaryLogin = true;

            
            WorkflowManagementServer WFServer = new WorkflowManagementServer();
            try
            {
                //WFServer.Open();
                //string conn = WFServer.Connection.ToString();
                WFServer.CreateConnection();
                WFServer.Connection.Open(ConnStr.ToString());
                //WFServer.DeleteProcessInstances(ProcInstID, false);
                WFServer.GotoActivity(ProcInstID, activityName);
            }
            catch
            {
                R = false;
            }
            finally
            {
                WFServer.Connection.Close();
                WFServer.Connection.Dispose();
            }
           // return R;

            */
        }



        public static void WorkListItemActionint(string p, string p_2)
        {
            WorkListItemAction(p, p_2);
        }
    }
}

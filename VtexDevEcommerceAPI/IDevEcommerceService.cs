using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using DevEcommerceAPI;
using DevEcommerceAPI.DataContracts;


namespace DevEcommerceAPI
{
    [ServiceContract]
    public interface IDevEcommerceService
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                        BodyStyle = WebMessageBodyStyle.Wrapped,
                      UriTemplate = "GetDeveloper/{id}")]
        Developer GetDeveloperById(string id);


        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
              UriTemplate = "GetDevelopers")]
        IEnumerable<Developer> GetDevelopers();

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
              UriTemplate = "CalculateDevPrice")]
        string CalculateDevPrice();
    }
}
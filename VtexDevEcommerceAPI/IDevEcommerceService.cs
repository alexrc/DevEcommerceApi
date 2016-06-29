using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using VtexDevEcommerceAPI;
using VtexDevEcommerceAPI.Entities;


namespace VtexDevEcommerceAPI
{
    [ServiceContract]
    public interface IDevEcommerceService
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                        BodyStyle = WebMessageBodyStyle.Wrapped,
                      UriTemplate = "GetUser/{id}")]
        User GetUser(string id);


        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
              UriTemplate = "GetUsers")]
        IEnumerable<User> GetUsers();
    }
}
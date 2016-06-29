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
                      UriTemplate = "GetDeveloperByLogin/{login}")]
        Developer GetDeveloperByLogin(string login);


        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
              UriTemplate = "/GetDevelopers?Page={page}&perPage={perPage}")]
        IEnumerable<Developer> GetDevelopers(int page, int perPage);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
              UriTemplate = "CalculateDevPrice/{devLogin}")]
        string CalculateDevPrice(string devLogin);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS_Services.Services
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        (bool isValid, string role, int studentId) ValidateUser(string username, string password);
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS_Services.Services
{
    [ServiceContract]
    public interface IDeleteService
    {
        [OperationContract]
        void DeleteStudentData(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS_Services.Services
{
    [ServiceContract]
    public interface IAddService
    {
        [OperationContract]
        void AddStudentData(Student student);
    }
    [DataContract]
    public class Student
    {
        [DataMember]
        public int SId { get; set; }

        [DataMember]
        public string SName { get; set; }

        [DataMember]
        public string SAddress { get; set; }

        [DataMember]
        public string SEmail { get; set; }

        [DataMember]
        public string SPhone_no { get; set; }

        [DataMember]
        public int Sem { get; set; }

        [DataMember]
        public string Fees_paid { get; set; }
        [DataMember]
        public string Grades { get; set; }
    }
}

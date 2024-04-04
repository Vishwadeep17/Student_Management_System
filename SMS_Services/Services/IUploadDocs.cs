using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS_Services.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUploadDocs" in both code and config file together.
    [ServiceContract]
    public interface IUploadDocs
    {
        [OperationContract]
        void upload_documents(DocModel dm);

        [OperationContract]
        IEnumerable<DocModel> get_documents(string cid);
    }

    [DataContract]
    public class DocModel
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string c_id { get; set; }
        [DataMember]
        public byte[] fileBytes { get; set; }

    }
}

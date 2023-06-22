using System.Runtime.Serialization;
using System.ServiceModel;

namespace DownloadService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDownloadService" in both code and config file together.

    [ServiceContract]
    public interface IDownloadService
    {
        [OperationContract]
        File DownloadDocument();
    }

    [DataContract]
    public class File
    {
        [DataMember(IsRequired = true)]
        public string Name { get; set; }
        [DataMember(IsRequired = true)]
        public byte[] Content { get; set; }
    }
}

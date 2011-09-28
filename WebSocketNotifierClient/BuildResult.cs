using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace WebSocketNotifierClient
{
    [DataContract]
    public class BuildResult
    {
        [DataMember(Name = "project")]
        public string Project { get; set; }

        [DataMember(Name = "result")]
        public string Result { get; set; }

        [DataMember(Name = "number")]
        public int Number { get; set; }

        public bool IsSuccess
        {
            get { return "SUCCESS".Equals(Result); }
        }

        public bool IsUnstable
        {
            get { return "UNSTABLE".Equals(Result); }
        }

        public bool IsFailure
        {
            get { return "FAILURE".Equals(Result); }
        }

        public static BuildResult Parse(string message)
        {
            var bytes = Encoding.Unicode.GetBytes(message);
            using (var stream = new MemoryStream(bytes))
            {
                var serializer = new DataContractJsonSerializer(typeof(BuildResult));
                return (BuildResult)serializer.ReadObject(stream);
            }
        }

        public string ToMessage()
        {
            var msg = new StringBuilder();
            msg.AppendFormat("{0} #{1}", Project, Number);
            msg.AppendLine();
            msg.AppendLine(Result);
            return msg.ToString();
        }
    }

}

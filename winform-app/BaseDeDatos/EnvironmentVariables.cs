using System.Runtime.Serialization;

namespace winform_app.baseDeDatos
{
    [DataContract]
    public class EnvironmentVariables
    {
        [DataMember(Name = "ConnectionString")]
        public string ConnectionString { get; set; }
    }
}

namespace HostMe.Sdk.Auth
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class AccessTokenViewModel
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = ".expires")]
        public DateTime Expires { get; set; }

        [DataMember(Name = ".issued")]
        public DateTime Issued { get; set; }

        [DataMember(Name = "token_type")]
        public string TokenType { get; set; }

        [DataMember(Name = "userName")]
        public string UserName { get; set; }
    }
}
using System.Runtime.Serialization;

namespace SaloonApp.UserDom.Domain
{
    public enum TypeOfUser
    {
        [EnumMember(Value = "Admin")]
        Admin = 1,
        [EnumMember(Value = "Worker")]
        Worker = 2,
        [EnumMember(Value = "Customer")]
        Customer = 3,
        [EnumMember(Value = "NotLoggedIn")]
        NotLoggedIn = 4
    }
}

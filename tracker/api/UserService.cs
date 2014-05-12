using ServiceStack.ServiceInterface;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tracker.api
{
    public class UserService : Service
    {
        public object Post(AddUser request)
        {
            return new AddUserResponse(UserId = 255);
        }
    }
    class AddUserResponse
    {
        public long UserId { get; set; }
    }

    [Route ("/users","POST")]
    class AddUser
    {
        public string Name { get; set; }
        public int Goal { get; set; }
    }
    
}
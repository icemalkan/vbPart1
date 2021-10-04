using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCore.Models
{
    public  class IncomingUsers
    {
        public List<UserResponse> UserResponses { get; set; } = new List<UserResponse>();
        public  void AddUsers(UserResponse userResponse)
        {
            UserResponses.Add(userResponse);
        }
    }
}

using backendAPI.Models;

namespace backendAPI.Models
{
    public class AuthenticateResponse
    {
        public string Token { get; set; }

        
        public string Name { get; set; }
                    
        public string Team { get; set; }
            
        public string JoinedAt { get; set; }
            
        public string Avatar { get; set; }
        /*public personalDetails Personal { get; set; }
        public class personalDetails
        {
            public string Name { get; set; }
                    
            public string Team { get; set; }
            
            public string JoinedAt { get; set; }
            
            public string Avatar { get; set; }
        }
        */
        
        


        public AuthenticateResponse(User user, string token)
        {
            Name = user.Name;
            Team = user.Team;
            JoinedAt = user.JoinedAt;
            Avatar = user.Avatar;
            Token = token;
        }
    }
}
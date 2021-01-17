using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace backendAPI.Models
{
    public class UserDBContext: DbContext
    {
        private static List<User> UsersSeedData = new List<User>{
            new User() {Name="Test", Team="Developers", JoinedAt="2018-10-01", Avatar ="https://avatarfiles.alphacoders.com/164/thumb-164632.jpg", Email="test@test.com", Password="strong123" }
        };
        private static List<Project> ProjectsUsersSeedData = new List<Project>{
            new Project() {
                Id = "5fb9953bd98214b6df37174d",
                Name =  "Backend Project",
                Score = 88,
                DurationInDays =  35,
                BugsCount =  74,
                MadeDadeline =  false,
                UserEmail = "test@test.com"
            },
            new Project() {
                Id = "5fb9953blknsdfaasdb6df37174d",
                Name =  "Frontend Project",
                Score = 85,
                DurationInDays =  35,
                BugsCount =  24,
                MadeDadeline =  false,
                UserEmail = "test@test.com"
            },
            new Project() {
                Id = "5fb9953blknsdfaasdb6df37174d",
                Name =  "Frontend Project",
                Score = 85,
                DurationInDays =  35,
                BugsCount =  24,
                MadeDadeline =  false,
                UserEmail = "anotherEmail@test.com"
            }
        };
        
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options) {
            
        }

        public static List<Project> getProjects() {
            return UserDBContext.ProjectsUsersSeedData;
        }
        public static List<User> get()
        {
            return UserDBContext.UsersSeedData;
        }
        
        public static void AddUser(User user) {
            UserDBContext.UsersSeedData.Add(user);
        }
    }
}
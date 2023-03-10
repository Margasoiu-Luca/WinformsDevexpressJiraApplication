using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models.DTO2
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class JProject
    {
        public object JTeam { get; set; }
        public List<object> JEvents { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int teamId { get; set; }
    }

    public class JUser
    {
        public List<object> JComments { get; set; }
        public List<object> JEvents { get; set; }
        public List<object> JTeamUsers { get; set; }
        public object JUserType { get; set; }
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public object openBy { get; set; }
        public DateTime dueDate { get; set; }
        public int userId { get; set; }
        public object parentEvent { get; set; }
        public int eventType { get; set; }
        public int eventStatus { get; set; }
        public List<object> JComments { get; set; }
        public List<object> JComments1 { get; set; }
        public object JEventStatu { get; set; }
        public object JEventType { get; set; }
        public List<object> JEvent1 { get; set; }
        public object JEvent2 { get; set; }
        public JUser JUser { get; set; }
        public List<JProject> JProjects { get; set; }
    }




}

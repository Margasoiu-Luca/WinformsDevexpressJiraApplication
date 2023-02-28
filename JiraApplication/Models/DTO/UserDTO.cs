using System;
using System.Collections.Generic;

namespace JiraApplication.Models
{
    // UserDTO myDeserializedClass = JsonConvert.DeserializeObject<UserDTO>(myJsonResponse);
    public class JEvent
    {
        public List<object> JComments { get; set; }
        public List<object> JComments1 { get; set; }
        public JEventStatu JEventStatu { get; set; }
        public JEventType JEventType { get; set; }
        public List<object> JEvent1 { get; set; }
        public object JEvent2 { get; set; }
        public JUser JUser { get; set; }
        public List<object> JProjects { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime openBy { get; set; }
        public DateTime dueDate { get; set; }
        public int? userId { get; set; }
        public object parentEvent { get; set; }
        public int eventType { get; set; }
        public int eventStatus { get; set; }
    }

    public class JEventStatu
    {
        public List<JEvent> JEvents { get; set; }
        public int id { get; set; }
        public string eventStatus { get; set; }
    }

    public class JEventType
    {
        public List<JEvent> JEvents { get; set; }
        public int id { get; set; }
        public string eventType { get; set; }
    }

    public class JProject
    {
        public List<JEvent> JEvents { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int teamId { get; set; }
        public JTeam JTeam { get; set; }
    }

    public class JTeam
    {
        public List<JProject> JProjects { get; set; }
        public List<JTeamUser> JTeamUsers { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class JTeamUser
    {
        public JTeam JTeam { get; set; }
        public int userId { get; set; }
        public int teamId { get; set; }
        public bool isLead { get; set; }
        public JUser JUser { get; set; }
    }

    public class JUser
    {
        public List<object> JComments { get; set; }
        public List<object> JEvents { get; set; }
        public List<JTeamUser> JTeamUsers { get; set; }
        public JUserType JUserType { get; set; }
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
    }

    public class JUser5
    {
        public List<object> JComments { get; set; }
        public List<JEvent> JEvents { get; set; }
        public List<JTeamUser> JTeamUsers { get; set; }
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
    }

    public class JUserType
    {
        public List<object> JUsers { get; set; }
        public int id { get; set; }
        public string userType { get; set; }
        public bool addTeam { get; set; }
        public bool addSprint { get; set; }
        public bool addUser { get; set; }
        public bool addEvent { get; set; }
    }

    public class UserDTO
    {
        public List<object> JComments { get; set; }
        public List<object> JEvents { get; set; }
        public List<JTeamUser> JTeamUsers { get; set; }
        public JUserType JUserType { get; set; }
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
    }


}

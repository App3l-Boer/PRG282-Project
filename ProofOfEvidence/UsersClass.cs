using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfEvidence
{
    class Users
    {
        private List<Users> AllUsers = new List<Users>();
        private string username;
        private string password;
        private string rank;
        private string callsign;
        private string unit;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Callsign { get => callsign; set => callsign = value; }
        public string Unit { get => unit; set => unit = value; }

        public Users()
        {
            
        }

        Users(string username, string password, string rank, string callsign, string unit)
        {
            this.username = username;
            this.password = password;
            this.rank = rank;
            this.callsign = callsign;
            this.unit = unit;
        }

        public List<Users> AddUser()
        {
            AllUsers.Add(new Users("Metal", "123456", "SSG","Sandman","Delta Force"));
            AllUsers.Add(new Users("Westbrook", "134679", "COL", "Frost", "Delta Force"));
            AllUsers.Add(new Users("Riley", "167349", "SGT", "Ghost", "Task Force 141"));
            AllUsers.Add(new Users("Sanderson", "147258", "SGT", "Roach", "SAS"));
            AllUsers.Add(new Users("Price", "000001", "CPT", "Price", "Task Force 141"));
            return AllUsers;
        }
    }
}

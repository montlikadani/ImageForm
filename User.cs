using System;
using System.Drawing;

namespace ImageForm {
    public sealed class User {
        
        public int Id { get; private set; }
        public string Nev { get; private set; }
        public DateTime SzulDate { get; private set; }
        public Image ProfilePicture { get; private set; }

        public User(int id, string nev, DateTime szulDate, Image profilePicture) {
            Id = id;
            Nev = nev;
            SzulDate = szulDate;
            ProfilePicture = profilePicture;
        }

        public override string ToString() {
            return Nev;
        }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    [Table("Pupils")]
    public class Pupil
    {
        [PrimaryKey, AutoIncrement, Column("PupilID")]
        public int PupilID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Pupil(int pupilId, string lastName, string firstName)
        {
            PupilID = pupilId;
            LastName = lastName;
            FirstName = firstName;
        }
    }
}

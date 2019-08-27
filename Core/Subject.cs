using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectTitle { get; set; }
        public int HighestPossibleMark { get; set; }

        public Subject(int subjectID, string subjectTitle, int highestPossibleMark)
        {
            SubjectID = subjectID;
            SubjectTitle = subjectTitle;
            HighestPossibleMark = highestPossibleMark;
        }
    }
}

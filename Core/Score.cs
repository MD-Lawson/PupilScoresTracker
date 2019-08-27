using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Score
    {
        public int ScoreID { get; set; }
        public int PupilID { get; set; }
        public int SubjectID { get; set; }
        public decimal ScoreAmount { get; set; }

        public Score(int scoreID, int pupilID, int subjectID, decimal scoreAmount)
        {
            ScoreID = scoreID;
            PupilID = pupilID;
            SubjectID = subjectID;
            ScoreAmount = scoreAmount;
        }
    }
}

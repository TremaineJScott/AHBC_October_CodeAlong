using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
   public class CandidateInterviewCancelled : InterviewEmailBase
    {
        public bool IsRescheduled { get; set; }

        public  virtual void ScheduleInterview()
        {
            // do stuff
        }

    }
}

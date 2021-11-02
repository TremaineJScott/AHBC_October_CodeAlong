using System;
using System.Collections.Generic;
using System.Text;

namespace WeekFour
{
    enum BookGenre
    {
        SciFi = 1,
        Romance,
        Western,
        PersonalDevelopment,
        NonFiction,
        Mystery,
        
    }

    enum EmailTypes
    {
        CandidateSubmission = 200,
        InterviewRequest = 500,
        JobOffer = 404,
        CandidateRemoved = 498   
    }

    enum BookStatus
    {
        OnShelf,
        CheckedOut,
        Returned
    }



}

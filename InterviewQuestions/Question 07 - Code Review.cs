//Question 7 - Code review the code below. Write any comments / suggestions in code comments next to the affected line.
// if you feel like your comment can be backed up with evidence: eg 'this breaks the open closed principle' - please point to any evidence via blogposts etc


//Start code review HERE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; // remove unused reference

namespace InterviewQuestions
{
    public class Question7
    {
        public string defaultAnswer; //publics should be properties instead of fields.
        private List<string> AvaliableAnswers { get; set; } //privates should be prefixed with an underscore and the first letter should be lowercase

        // two lines of whitespace
        public Question7(List<string> avaliableAnswers)
        {
            defaultAnswer = GetDefaultAnswer(avaliableAnswers);
        }

        public string GetDefaultAnswer(List<string> avaliableAnswers)
        {
            try
            {
                // we shouldn't have more than one avaliable answer NORMALLY, so lets try and get one.
                // remove redundant code: your code tells me you want 1 object
                return avaliableAnswers.Single();
                // this should be handled by doing SingleOrDefault or another way of checking the numbers first, then handling the result instead of catching exceptions
            }
            catch (Exception e) // do not catch generic exceptions, as if your code fails for an unknown reason, it will be handled in your app. Exceptions are not a bad thing all the time
            {
                if (avaliableAnswers.Count == 0) //.Any() ?
                {
                    return "There are no answers avaliable";
                }
                else
                {
                    // there were multiple answers. Inform the user
                    // another redundant comment
                    return "There are more than 1 answers to this question";
                }
            }
        }

        // this code isnt used, can it be removed?
        public void DisplayAnswersToUser()
        {
            foreach (var answer in AvaliableAnswers)
            {
                var currentItemPosition = AvaliableAnswers.IndexOf(answer) + 1;
                Console.WriteLine(currentItemPosition + " - " + answer);
            }
        }
    }
}

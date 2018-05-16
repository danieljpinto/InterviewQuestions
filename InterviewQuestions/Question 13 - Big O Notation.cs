using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Write some code that could be described in Big O notation as O(n^3)
    /// </summary>
    public class Question13
    {
        public List<string> TheO { get; set; }

        public void DoSomethingToTheListUsingONotation()
        {
            foreach (var item in TheO)
            {
                for (int i = 0; i < 10; i++)
                {
                    DoSomethingWith(item);

                    for (int j = 0; j < 2; i++)
                    {
                        DoSomethingElseWith(item);
                    }
                }
            }
        }

        private void DoSomethingWith(string item)
        {
            // do something
        }

        private void DoSomethingElseWith(string item)
        {
            // do something
        }
    }
}

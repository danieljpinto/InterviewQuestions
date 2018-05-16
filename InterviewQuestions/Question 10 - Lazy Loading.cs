using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Implement lazy loading on memory heavy thing, do not use the Lazy<IMemoryHeavyThing> class
    /// </summary>
    public class Question10
    {
        private IMemoryHeavyThing _memoryHeavyThing;
        public IMemoryHeavyThing MemoryHeavyThing
        {
            get
            {
                if (_memoryHeavyThing == null)
                {
                    _memoryHeavyThing = GetMemoryHeavyThing();
                }
                return _memoryHeavyThing;
            }
            set
            {
                _memoryHeavyThing = value;
            }
        }

        public Question10()
        {

        }

        public IMemoryHeavyThing GetMemoryHeavyThing()
        {
            throw new NotImplementedException();
        }

        public interface IMemoryHeavyThing
        {

        }        
    }
}

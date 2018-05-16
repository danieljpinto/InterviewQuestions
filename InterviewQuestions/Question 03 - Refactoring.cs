using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Refactor the code below to make it more object oriented and remove the switch statement.
    /// The likely result of this will end up with a boolean property on the service class
    /// 
    /// You are permitted to write as many additional classes, methods or code as you see necessary.
    /// </summary>
    public class Question3
    {
        private Service _service;

        private Question3(Service service)
        {
            _service = service;
        }

        public string GetString(string theInput)
        {
            var response = _service.AskForPermission();

            if (response.ResponseCode == ResponseCode.Success)
            {
                return String.Format("{0} {1}", theInput, theInput);
            }

            return response.ErrorMessage;
        }

        private class Service
        {
            internal PermissionsResponse AskForPermission()
            {
                throw new NotImplementedException();
            }
        }

        private class PermissionsResponse
        {
            public ResponseCode ResponseCode { get; private set; }
            public string ErrorMessage { get; private set; }

            private PermissionsResponse(ResponseCode responseCode)
            {
                ResponseCode = responseCode;
            }
            private PermissionsResponse(ResponseCode responseCode, string errorMessage)
            {
                ResponseCode = responseCode;
                ErrorMessage = errorMessage;
            }

            public static PermissionsResponse Success()
            {
                return new PermissionsResponse(ResponseCode.Success);
            }

            public static PermissionsResponse Failure(string errorMessage)
            {
                return new PermissionsResponse(ResponseCode.Failure, errorMessage);
            }
        }

        private enum ResponseCode
        {
            Success = 1,
            Failure = 2
        }
    }
}

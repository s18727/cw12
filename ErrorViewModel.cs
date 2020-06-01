using System;

namespace cw12.Models
{
    public class ErrorViewModel
    {
        private string requestId;

        public string GetRequestId()
        {
            return requestId;
        }

        public void SetRequestId(string value)
        {
            requestId = value;
        }

        public bool ShowRequestId => !string.IsNullOrEmpty(GetRequestId());
    }
}

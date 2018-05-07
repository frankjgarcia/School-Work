using System;

namespace UnitConveter.Models
{
    public class UnitConvterViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
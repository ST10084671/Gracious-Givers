using System;

namespace WIL_GRACIOUS_GIVERS_WEBSITE_DESIGN_FINAL.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

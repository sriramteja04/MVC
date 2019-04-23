using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class ErrorViewModel
    {
       
        public string RequestId { get; set; }
        public bool Done { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
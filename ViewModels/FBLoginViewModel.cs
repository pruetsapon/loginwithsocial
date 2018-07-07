using System;
using System.Collections.Generic;
using System.Linq;

namespace Social.ViewModels
{
    public class FBLoginViewModel
    {
        public string FacebookId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Image { get; set; }
        public string AccessToken { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSP_Foundation.Interfaces;

namespace CSP_Graph.Entities
{
    public class Token : IToken
    {
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string expires_on { get; set; }
        public string not_before { get; set; }
        public string resource { get; set; }
        public string access_token { get; set; }

        public virtual string token
        {
            get { return access_token; }
        }
    }
}

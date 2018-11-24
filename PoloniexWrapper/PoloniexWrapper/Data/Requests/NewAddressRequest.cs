﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoloniexWrapper.Data.Requests
{
    public class NewAddressRequest : BaseRequest
    {
        public NewAddressRequest(string apiSec, string curr) : base(apiSec)
        {
            arguments = new Dictionary<string, string>
            {
                ["command"] = "generateNewAddress",
                ["currency"] = curr,
                ["nonce"] = GetNonce()
            };
        }
    }
}

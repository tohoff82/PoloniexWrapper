﻿using System.Collections.Generic;

using static PoloniexWrapper.Helper.Enums.ReqType;

namespace PoloniexWrapper.Data.Requests
{
    public class CompleteBalancesRequest : RequestObject
    {
        public CompleteBalancesRequest(string apiSec) : base(apiSec)
        {
            arguments = new Dictionary<string, string>
            {
                ["command"] = "returnCompleteBalances",
                ["nonce"] = GetNonce()
            }; 

            GenerateRequest(POST);
        }
    }
}

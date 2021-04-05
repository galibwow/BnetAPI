using System;
using System.Collections.Generic;
using System.Text;

namespace BnetAPI.Application.Common
{
    interface ICurrentUserService
    {
        string UserId { get; }
    }
}

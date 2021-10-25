using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmg.Blog.Repository.Enums
{
    public enum PostStatus
    {
        Pending = 1,
        PendingApproval = 2,
        Approved = 3,
        Rejected = 4
    }
}

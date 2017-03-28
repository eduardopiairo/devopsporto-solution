using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsPorto.Models
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetListOfMembers();
    }
}

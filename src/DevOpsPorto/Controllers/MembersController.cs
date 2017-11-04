using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevOpsPorto.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DevOpsPorto.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class MembersController
    {
        private readonly IMemberRepository _repository;

        public MembersController(IMemberRepository repository)
        {
            if (repository == null)
                throw new ArgumentNullException(nameof(repository));

            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Member> GetListOfMembers()
        {
            return _repository.GetListOfMembers();
        }

    }
}

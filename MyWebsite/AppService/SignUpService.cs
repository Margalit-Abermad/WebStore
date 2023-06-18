using AutoMapper;
using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService
{
    public class SignUpService : ISignUpService
    {
        ISignUpRepository repo;
        IMapper mapper;
        public SignUpService(ISignUpRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public void Create(SignUpDTO signUpDTO)
        {
            //KnownUser user = mapper.Map<KnownUser>(signUpDTO);
            //repo.Create(user);
            Console.WriteLine("created");
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public SignUpDTO GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<SignUpDTO> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(SignUpDTO productsDTO)
        {
            throw new NotImplementedException();
        }
    }
}

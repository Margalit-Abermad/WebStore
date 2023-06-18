using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService
{
    public interface ISignUpService
    {
        List<SignUpDTO> GetList();

        SignUpDTO GetById(int Id);

        void Delete(int Id);

        void Update(SignUpDTO productsDTO);

        void Create(SignUpDTO productsDTO);
    }
}

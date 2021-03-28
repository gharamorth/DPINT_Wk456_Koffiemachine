using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaAndChocoLibrary;

namespace KoffieMachineDomain.Adapters
{
    public class TeaRepository
    {
        private TeaBlendRepository _repository;

        public TeaRepository()
        {
            _repository = new TeaBlendRepository();
        }

        public List<String> GetTeaNames()
        {
            return (List<string>)_repository.BlendNames;
        }
    }
}

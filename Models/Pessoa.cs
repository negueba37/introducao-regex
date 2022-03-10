using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Models
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Pessoa) {
                Pessoa objPessoa = (Pessoa)obj;
                return objPessoa.Id == Id; 
            }
            return false;
        }

    }
}

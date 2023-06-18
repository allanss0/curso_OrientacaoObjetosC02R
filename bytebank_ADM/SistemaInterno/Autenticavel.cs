using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class Autenticavel : Funcionario
    {
        public string senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.senha.Equals(senha);
        }

        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}

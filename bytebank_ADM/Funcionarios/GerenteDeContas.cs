using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas:Funcionario, Autenticavel
    {
        string Autenticavel.Senha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GerenteDeContas(string cpf) : base(cpf,4000)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        bool Autenticavel.Autenticar(string senha)
        {
            throw new NotImplementedException();
        }
    }
}

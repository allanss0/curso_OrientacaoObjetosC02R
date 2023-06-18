using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: Funcionario, Autenticavel
    {
        public string Senha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public Diretor(string cpf):base(cpf,5000)
        {
            //Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15; 
        }

        public bool Autenticar(string senha)
        {
            throw new NotImplementedException();
        }
    }

    
}

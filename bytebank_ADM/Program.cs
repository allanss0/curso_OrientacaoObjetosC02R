using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System.Reflection.PortableExecutable;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro malazartes";


//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);

//Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";
    paula.senha = "teste1";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";
    camila.senha = "teste1";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = "+ gerenciador.TotalDeBonficacao);

    //Funcionario pedro = new Funcionario("123456",852);
}
void UsarSistema()
{ 
    SistemaInterno sistema = new SistemaInterno();
  
    Diretor paula1 = new Diretor("987456");
    paula1.Nome = "Paula Souza";
    paula1.senha = "teste1";

    GerenteDeContas camila1 = new GerenteDeContas("852963");
    camila1.Nome = "Camila Oliveira";
    camila1.senha = "teste1";

    Auxiliar paula2 = new("987456");
    paula2.Nome = "Paula Souza";
    // paula2.senha = "teste1";

    ParceiroComercial pc1 = new ParceiroComercial();
    pc1.Senha = "123";
        

    sistema.Logar(camila1, "teste11");
    sistema.Logar(paula1, "teste1");
    sistema.Logar(pc1, "123");

    // sistema.Logar(paula2, "teste11");
}





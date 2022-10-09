using ExemploExplorando.Models;

 Pessoa p1 = new Pessoa("Lucas", "Bastos");

Pessoa p2 = new Pessoa(nome: "Daiana", sobrenome: "Vieira Lopes");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();


cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();




















// Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas";
// p1.Sobrenome = "Bastos";
// p1.Idade = 34;
// p1.Apresentar();
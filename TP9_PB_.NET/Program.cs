using TP9_PB_.NET.models;

// Disciplina

Disciplina disciplina1 = new Disciplina(1, "Java");
Disciplina disciplina2 = new Disciplina(2, ".NET");
Disciplina disciplina3 = new Disciplina(3, "Matemática");

// Professor

Professor professor1 = new Professor(1, "Nicolas");
Professor professor2 = new Professor(2, "Celly");
Professor professor3 = new Professor(3, "Carlos");

// Alunos
List<Aluno> listaAlunosIniciais = new List<Aluno>();

Aluno aluno1 = new Aluno(1,"João");
Aluno aluno2 = new Aluno(2, "Andre");
Aluno aluno3 = new Aluno(3, "Samuel");

listaAlunosIniciais.Add(aluno1);
listaAlunosIniciais.Add(aluno2);
listaAlunosIniciais.Add(aluno3);

// Turma

Console.WriteLine("Teste: classe turma e aluno");
// cria e adiciona 3 alunos a turma1
Turma turma1 = new Turma(1, disciplina1, professor1, listaAlunosIniciais);

// adiciona a classe turma em cada aluno 
Console.WriteLine(aluno1.addTurma(turma1));
Console.WriteLine(aluno2.addTurma(turma1));
Console.WriteLine(aluno3.addTurma(turma1));


Console.WriteLine(turma1.gerarPauta());
Console.WriteLine(aluno1.ExibirTurma());

// adiciona aluno a turma 1
Console.WriteLine("Teste: adicionar alunos a uma turma");
Console.WriteLine();
Console.WriteLine(turma1.addAluno(new Aluno(4, "Roberto")));
Console.WriteLine(turma1.addAluno(new Aluno(5, "Crisley")));
Console.WriteLine(turma1.addAluno(new Aluno(6, "Murillo")));
Console.WriteLine(turma1.addAluno(new Aluno(7, "Dam")));
Console.WriteLine(turma1.addAluno(new Aluno(8, "Erika")));
Console.WriteLine(turma1.addAluno(new Aluno(9, "Antonio")));
Console.WriteLine(turma1.addAluno(new Aluno(10, "Rebeca")));
Console.WriteLine(turma1.addAluno(new Aluno(11, "Victor")));
Console.WriteLine(turma1.addAluno(new Aluno(12, "Matheus")));

Console.WriteLine(turma1.gerarPauta());

// adicionar turma ao aluno 1
Console.WriteLine("Teste: adicionar turmas em alunos");
Console.WriteLine();
List<Aluno> listaAlunosIniciais2 = [aluno2, aluno3];

// Criar turmas
Turma turma2 = new Turma(2, disciplina2, professor2, listaAlunosIniciais2);
Turma turma3 = new Turma(1, disciplina3, professor3, listaAlunosIniciais2);

// adicionar turmas no aluno2
Console.WriteLine(aluno2.addTurma(turma2));
Console.WriteLine(aluno2.addTurma(turma3));

// adicionar turmas no aluno3
Console.WriteLine(aluno3.addTurma(turma2));
Console.WriteLine(aluno3.addTurma(turma3));

Console.WriteLine(aluno2.ExibirTurma());
Console.WriteLine(aluno3.ExibirTurma());
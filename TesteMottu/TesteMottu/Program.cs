using TesteMottu;

List<Aluno> alunos = new List<Aluno>
{
    new Aluno { Nome = "aluno1", Notas = new List<double> { 0, 0, 0, 0, 0, 0, 0, 0 } },
    new Aluno { Nome = "aluno2", Notas = new List<double> { 0, 0, 0 } },
    new Aluno { Nome = "aluno3", Notas = new List<double> { 0, 0, 0 } },
    new Aluno { Nome = "aluno4", Notas = new List<double> { 0, 0, 0 } },
    new Aluno { Nome = "aluno5", Notas = new List<double> { 0, 0, 0 } },
    new Aluno { Nome = "aluno6", Notas = new List<double> { 0, 0, 0 } },
    new Aluno { Nome = "aluno7", Notas = new List<double> { 0, 0, 0 } }
};

//Aluno1
Console.WriteLine("Por favor, coloque o nome do primeiro aluno");
alunos[0].Nome = Console.ReadLine();

Console.WriteLine($"Por favor, digite as notas do {alunos[0].Nome}");
var aluno1Nota1 = double.Parse(Console.ReadLine());
alunos[0].Notas[0]= aluno1Nota1;

var aluno1Nota2 = double.Parse(Console.ReadLine());
alunos[0].Notas[1] = aluno1Nota2;

var aluno1Nota3 = double.Parse(Console.ReadLine());
alunos[0].Notas[2] = aluno1Nota3;

var aluno1Nota4 = double.Parse(Console.ReadLine());
alunos[0].Notas[3] = aluno1Nota4;

var aluno1Nota5 = double.Parse(Console.ReadLine());
alunos[0].Notas[4] = aluno1Nota5;

var aluno1Nota6 = double.Parse(Console.ReadLine());
alunos[0].Notas[5] = aluno1Nota6;

var aluno1Nota7 = double.Parse(Console.ReadLine());
alunos[0].Notas[6] = aluno1Nota7;

var aluno1Nota8 = double.Parse(Console.ReadLine());
alunos[0].Notas[7] = aluno1Nota8;

//Aluno2
Console.WriteLine("Por favor, coloque o nome do segundo aluno");
alunos[1].Nome = Console.ReadLine();

Console.WriteLine($"Por favor, digite as notas do {alunos[1].Nome}");
var aluno2Nota1 = double.Parse(Console.ReadLine());
alunos[1].Notas[0] = aluno2Nota1;

var aluno2Nota2 = double.Parse(Console.ReadLine());
alunos[1].Notas[1] = aluno2Nota2;

var aluno2Nota3 = double.Parse(Console.ReadLine());
alunos[1].Notas[2] = aluno2Nota3;

//Aluno3
Console.WriteLine("Por favor, coloque o nome do terceiro aluno");
alunos[2].Nome = Console.ReadLine();

Console.WriteLine($"Por favor, digite as notas do {alunos[2].Nome}");
var aluno3Nota1 = double.Parse(Console.ReadLine());
alunos[2].Notas[0] = aluno3Nota1;

var aluno3Nota2 = double.Parse(Console.ReadLine());
alunos[2].Notas[1] = aluno3Nota2;

var aluno3Nota3 = double.Parse(Console.ReadLine());
alunos[2].Notas[2] = aluno3Nota3;

//Aluno4
Console.WriteLine("Por favor, coloque o nome do quarto aluno");
alunos[3].Nome = Console.ReadLine();

Console.WriteLine($"Por favor, digite as notas do {alunos[3].Nome}");
var aluno4Nota1 = double.Parse(Console.ReadLine());
alunos[3].Notas[0] = aluno4Nota1;

var aluno4Nota2 = double.Parse(Console.ReadLine());
alunos[3].Notas[1] = aluno4Nota2;

var aluno4Nota3 = double.Parse(Console.ReadLine());
alunos[3].Notas[2] = aluno4Nota3;

//Aluno5
Console.WriteLine("Por favor, coloque o nome do quinto aluno");
alunos[4].Nome = Console.ReadLine();

Console.WriteLine($"Por favor, digite as notas do {alunos[4].Nome}");
var aluno5Nota1 = double.Parse(Console.ReadLine());
alunos[4].Notas[0] = aluno5Nota1;

var aluno5Nota2 = double.Parse(Console.ReadLine());
alunos[4].Notas[1] = aluno5Nota2;

var aluno5Nota3 = double.Parse(Console.ReadLine());
alunos[4].Notas[2] = aluno5Nota3;

//Aluno6
Console.WriteLine("Por favor, coloque o nome do sexto aluno");
alunos[5].Nome = Console.ReadLine();

Console.WriteLine($"Por favor, digite as notas do {alunos[5].Nome}");
var aluno6Nota1 = double.Parse(Console.ReadLine());
alunos[5].Notas[0] = aluno6Nota1;

var aluno6Nota2 = double.Parse(Console.ReadLine());
alunos[5].Notas[1] = aluno6Nota2;

var aluno6Nota3 = double.Parse(Console.ReadLine());
alunos[5].Notas[2] = aluno6Nota3;

//Aluno7
Console.WriteLine("Por favor, coloque o nome do sétimo aluno");
alunos[6].Nome = Console.ReadLine();

Console.WriteLine($"Por favor, digite as notas do {alunos[6].Nome}");
var aluno7Nota1 = double.Parse(Console.ReadLine());
alunos[6].Notas[0] = aluno7Nota1;

var aluno7Nota2 = double.Parse(Console.ReadLine());
alunos[6].Notas[1] = aluno7Nota2;

var aluno7Nota3 = double.Parse(Console.ReadLine());
alunos[6].Notas[2] = aluno7Nota3;

//Cálculos
var notasSala = alunos.SelectMany(aluno => aluno.Notas);
double mediaSala = notasSala.Average();

var notasMediasAlunos = alunos
            .Select(aluno => new { Nome = aluno.Nome, NotaMedia = aluno.Notas.Average() })
            .OrderByDescending(aluno => aluno.NotaMedia)
            .ToList();

var alunoNotaMaior = alunos.OrderByDescending(aluno => aluno.Notas.Average()).First();

Console.WriteLine($"Média da sala: {mediaSala:F2}\n");
Console.WriteLine("Notas médias dos alunos ordenadas pelo maior valor:");

foreach (var aluno in notasMediasAlunos)
{
    Console.WriteLine($"{aluno.Nome}: {aluno.NotaMedia:F2}");
}
Console.WriteLine($"\nNome do aluno com maior nota: {alunoNotaMaior.Nome}\nNota: {alunoNotaMaior.Notas.Average():F2}");



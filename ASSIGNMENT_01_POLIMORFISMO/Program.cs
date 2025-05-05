using Alunos.entities;

AlunoETEC alunoETEC = new AlunoETEC("Marcos",2023,150);
AlunoAMS aluno1AMS = new AlunoAMS("Matheus",2021,400);

Console.WriteLine($"alunos da ETEC não AMS nomes : {alunoETEC.Name}, ano de matricula: {alunoETEC.Year},Horas de curso: {alunoETEC.Hours}");

if (aluno1AMS.Hours < aluno1AMS.hoursm)
Console.WriteLine($"alunos da ETEC não AMS nomes : {aluno1AMS.Name}, ano de matricula: {aluno1AMS.Year},Horas de curso: {aluno1AMS.Hours}, o aluno não passou, minimo  de {aluno1AMS.hoursm}");
else{
    Console.WriteLine($"alunos da ETEC não AMS nomes : {aluno1AMS.Name}, ano de matricula: {aluno1AMS.Year},Horas de curso: {aluno1AMS.Hours}, o aluno passou ,minimo  de {aluno1AMS.hoursm}");
}


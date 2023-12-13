
using _16Agregacao;

Professor prof1 = new Professor("Carlos", "Química");
Professor prof2 = new Professor("Maria", "Inglês");
Professor prof3 = new Professor("Ana", "Literatura");
Professor prof4 = new Professor("Paulo", "Matemátia");

Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof4);
dep1.ListaProfessores();

Departamento dep2 = new Departamento("Humanas");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof3);
dep2.ListaProfessores();


Console.ReadKey();
namespace Novidades.Record;

// Permite declarar os tipos de valor record usando as declaracoes
// record struct ou readonly record struct
public readonly record struct Projeto(string Nome);

// Torna a record um tipo valor nao perdendo suas caracteristicas.
public record struct Projeto2(string Nome);
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Linq.data;

var values = DataSource.GenerateNumbers(max: 10);

// Select
Console.WriteLine("Select");
var it1 = values.Select(v => new { Value = v });

// SelectMany
Console.WriteLine("Select Many");
var m1 = new List<List<int>>() {
  new() {1, 2, 3, 4, 5},
  new() {1, 2, 3, 4, 5},
  new() {1, 2, 3, 4, 5},
};

// Consulta no formato sql xingling
var v = from m in m1 where m.All(x => x > 1) select m;

// Agrupando
var v2 = from m in m1 group m by m; 


m1.SelectMany(v => v).ToList().ForEach(v => Console.Write($" {v} "));


// Distinct
var it2 = values.Distinct();

// Intersect
string[] font1 = {"Brasil", "USA", "UK"};
string[] font2 = {"Brasil", "UK"};

Console.WriteLine();
font1.Intersect(font2).ToList().ForEach(x => Console.Write($" {x} "));
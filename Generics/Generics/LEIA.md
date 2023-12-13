# Colecoes Genericas

Estao presentes no namespace System.Collections.Generic

**Dictionary<K, V>**
<p>
  <h4>Propriedades</h4>
  <ul>
    <li>Count</li>
    <li>IsReadOnly</li>
    <li>Item - Ele retorna o indexador</li>
    <li>Keys</li>
    <li>Values</li>
    <li>Comparer</li>
  </ul>
  <h4>Metodos</h4>
  <ul>
    <li>Add</li>
    <li>TryAdd</li>
    <li>Clear</li>
    <li>ContainsKey</li>
    <li>ContainsValue</li>
    <li>Remove</li>
    <li>TryGetValue</li>
  </ul>
</p>

**SortedDictionary<K,V>**

**SortedList<K,V>**

**LinkedList<T>**

**HashSet<T>**

<div>
 <h4>Metodos</h4>
  <ul>
    <li>IsSubsetOf - Indica se um objeto HashSet e um subconjunto da colecao especificada.</li>
    <li>IsSupersetOf - Indica se um objeto HashSet e um superconjunto da colecao especificada. (tem todos os elementos)</li>
    <li>Overlaps - Indica se o objeto HashSet atual e uma colecao especificada compartilham pelo menos um elemento em comum.</li>
    <li>SetEquals - Indica se um objeto HashSet atual e uma colecao espeficiada contem os mesmos elementos.</li>
    <li>UnionWith - Une dois conjuntos</li>
  </ul>
</div>


**SortedSet<T>**

**Stack<T>**

**Queue<T>**

**List<T>**


# Colecoes Nao Genericas

Estao presentes no namespace System.Collections, elas usam o tipo object.
Elas sao obsoletas.

**ArrayList**

**HashTable**

**SortedList**

**Stack**

**Queue**

# Colecao Somente Leitura

namespace System.Collections.ObjectModel

Permite que estruturas apenas sejam acessadas, mas nao modificadas.

**ReadOnlyCollection<T>**

**ReadOnlyDictionary<T>**

# Operador in e out 

Eles devem ser usados em interface e delegates.

**in** - Significa que a entrada deve ser do tipo T, mas a saida nao pode ser do tipo T.

**out** - Singifica que a entrada nao pode ser o tipo T, mas a saida vai ser um tipo T.
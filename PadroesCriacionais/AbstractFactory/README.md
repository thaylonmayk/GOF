#Abstract Factory

##Propósito:

O Abstract Factory é um padrão de projeto criacional que permite que você produza famílias de objetos relacionados sem ter que especificar suas classes concretas.

##Intenção: 

Fornecer uma interface para criação de famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.
Cria uma instância de várias famílias de classes

##Problema:

Use o Abstract Factory quando seu código precisa trabalhar com diversas famílias de produtos relacionados, mas que você não quer depender de classes concretas daqueles produtos-eles podem ser desconhecidos de antemão ou você simplesmente quer permitir uma futura escalabilidade.

##Solução:

Sugere é declarar explicitamente interfaces para cada produto distinto da família de produtos (ex: cadeira, sofá ou mesa de centro). Então você pode fazer todas as variantes dos produtos seguirem essas interfaces. Por exemplo, todas as variantes de cadeira podem implementar a interface Cadeira; todas as variantes de mesa de centro podem implementar a interface MesaDeCentro, e assim por diante.

![Representação do Abstract Factory](.\AbstractFactory.png)

##Aplicabilidade :

O Abstract Factory fornece a você uma interface para a criação de objetos de cada classe das famílias de produtos. Desde que seu código crie objetos a partir dessa interface, você não precisará se preocupar em criar uma variante errada de um produto que não coincida com produtos já criados por sua aplicação.

Considere implementar o Abstract Factory quando você tem uma classe com um conjunto de métodos fábrica que desfoquem sua responsabilidade principal.

Em um programa bem desenvolvido cada classe é responsável por apenas uma coisa. Quando uma classe lida com múltiplos tipos de produto, pode valer a pena extrair seus métodos fábrica em uma classe fábrica solitária ou uma implementação plena do Abstract Factory.

##Prós :

* Você pode ter certeza que os produtos que você obtém de uma fábrica são compatíveis entre si.

* Você evita um vínculo forte entre produtos concretos e o código cliente.

* Princípio de responsabilidade única. Você pode extrair o código de criação do produto para um lugar, fazendo o código ser de fácil manutenção.

* Princípio aberto/fechado. Você pode introduzir novas variantes de produtos sem quebrar o código cliente existente.

##Contras :

* O código pode tornar-se mais complicado do que deveria ser, uma vez que muitas novas interfaces e classes são introduzidas junto com o padrão.

##Relações com outros padrões

Muitos projetos começam usando o __Factory Method__ (menos complicado e mais customizável através de subclasses) e evoluem para o __Abstract Factory__, __Prototype__, ou __Builder__ (mais flexíveis, mas mais complicados).

O __Builder__ foca em construir objetos complexos passo a passo. O __Abstract Factory__ se especializa em criar famílias de objetos relacionados. O __Abstract Factory__ retorna o produto imediatamente, enquanto que o __Builder__ permite que você execute algumas etapas de construção antes de buscar o produto.

Classes __Abstract Factory__ são quase sempre baseadas em um conjunto de _métodos fábrica_, mas você também pode usar o __Prototype__ para compor métodos dessas classes.

O __Abstract Factory__ pode servir como uma alternativa para o __Facade__ quando você precisa apenas esconder do código cliente a forma com que são criados os objetos do subsistema.

Você pode usar o __Abstract Factory__ junto com o __Bridge__. Esse pareamento é útil quando algumas abstrações definidas pelo __Bridge__ só podem trabalhar com implementações específicas. Neste caso, o __Abstract Factory__ pode encapsular essas relações e esconder a complexidade do código cliente.

As _Fábricas Abstratas, Construtores, e Protótipos_ podem todos ser implementados como __Singletons__.
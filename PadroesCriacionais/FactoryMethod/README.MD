# FACTORY METHOD

## Propósito:

O Factory Method é um padrão criacional de projeto que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados.

## Intenção:

Definir uma interface para criar um objeto, mas deixar as subclasses decidirem que classe instanciar.

Cria uma instância de várias classes derivadas.

Fornecer uma interface para criar objetos em uma superclasse, mas permitem que as subclasses alterem o tipo de objetos que serão criados.

## Problema: 

Quando seu código tem partes parecidas. Você desenvolve uma classe para um objetivo e depois tem que mudar para outro criando muitas condicionais.

Imagine que você está criando uma aplicação de gerenciamento de logística. A primeira versão da sua aplicação pode lidar apenas com o transporte de caminhões, portanto a maior parte do seu código fica dentro da classe _Caminhão_. Todos os dias você recebe dezenas de solicitações de empresas de transporte marítimo para incorporar a logística marítima na aplicação.
Atualmente, a maior parte do seu código é acoplada à classe _Caminhão_. Adicionar _Navio_ à aplicação exigiria alterações em toda a base de código. Além disso, se mais tarde você decidir adicionar outro tipo de transporte à aplicação, provavelmente precisará fazer todas essas alterações novamente.

## Solução:

Definir uma interface para criar um objeto, mas deixar as subclasses decidirem que classe instanciar.O padrão sugere que você substitua a chamada direta de construção de objetos usando o operador new, por chamadas para um método especial.
À primeira vista, essa mudança pode parecer sem sentido: apenas mudamos a chamada do construtor de uma parte do programa para outra. No entanto, considere o seguinte: agora você pode sobrescrever o método fábrica em uma subclasse e alterar a classe de produtos que estão sendo criados pelo método.
Porém, há uma pequena limitação: as subclasses só podem retornar tipos diferentes de produtos se esses produtos tiverem uma classe ou interface base em comum. Além disso, o método fábrica na classe base deve ter seu tipo de retorno declarado como essa interface.

![Solution do Factory Method](.\FactoryMethodSolution.png)

## Aplicabilidade:

Use o Factory Method quando não souber de antemão os tipos e dependências exatas dos objetos com os quais seu código deve funcionar.
O Factory Method separa o código de construção do produto do código que realmente usa o produto. Portanto, é mais fácil estender o código de construção do produto independentemente do restante do código.
Por exemplo, para adicionar um novo tipo de produto à aplicação, só será necessário criar uma nova subclasse criadora e substituir o método fábrica nela.

![Representação do Factory Method](.\FactoryMethod.png)

![Exemplo do Factory Method](.\FactoryMethod2.png)

## Prós:

* Você evita acoplamentos firmes entre o criador e os produtos concretos.
* Princípio de responsabilidade única. Você pode mover o código de criação do produto para um único local do programa, facilitando a manutenção do código.
* Princípio aberto/fechado. Você pode introduzir novos tipos de produtos no programa sem quebrar o código cliente existente.

## Contras:

* O código pode se tornar mais complicado, pois você precisa introduzir muitas subclasses novas para implementar o padrão.

## Como implementar:

Faça todos os produtos implementarem a mesma interface. Essa interface deve declarar métodos que fazem sentido em todos os produtos.
Adicione um método fábrica vazio dentro da classe criadora. O tipo de retorno do método deve corresponder à interface comum do produto.
No código da classe criadora, encontre todas as referências aos construtores de produtos. Um por um, substitua-os por chamadas ao método fábrica, enquanto extrai o código de criação do produto para o método fábrica.
Pode ser necessário adicionar um parâmetro temporário ao método fábrica para controlar o tipo de produto retornado.
Neste ponto, o código do método fábrica pode parecer bastante feio. Pode ter um grande operador switch que escolhe qual classe de produto instanciar. Mas não se preocupe, resolveremos isso em breve.
Agora, crie um conjunto de subclasses criadoras para cada tipo de produto listado no método fábrica. Sobrescreva o método fábrica nas subclasses e extraia os pedaços apropriados do código de construção do método base.
Se houver muitos tipos de produtos e não fizer sentido criar subclasses para todos eles, você poderá reutilizar o parâmetro de controle da classe base nas subclasses.
Se, após todas as extrações, o método fábrica base ficar vazio, você poderá torná-lo abstrato. Se sobrar algo, você pode tornar isso em um comportamento padrão do método.

##Relações com outros padrões

Muitos projetos começam usando o __Factory Method__ (menos complicado e mais customizável através de subclasses) e evoluem para o __Abstract Factory__, __Prototype__, ou __Builder__ (mais flexíveis, mas mais complicados).

Classes __Abstract Factory__ são quase sempre baseadas em um conjunto de _métodos fábrica_, mas você também pode usar o __Prototype__ para compor métodos dessas classes.

Você pode usar o __Factory Method__ junto com o __Iterator__ para permitir que uma coleção de subclasses retornem diferentes tipos de iteradores que são compatíveis com as coleções.

O __Prototype__ não é baseado em heranças, então ele não tem os inconvenientes dela. Por outro lado, o __Prototype__ precisa de uma inicialização complicada do objeto clonado. O __Factory Method__ é baseado em herança mas não precisa de uma etapa de inicialização.

O __Factory Method__ é uma especialização do __Template Method__. Ao mesmo tempo, o __Factory Method__ pode servir como uma etapa em um __Template Method__ grande.
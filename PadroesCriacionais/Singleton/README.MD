# SINGLETON

## Propósito:
O Singleton é um padrão de projeto criacional que permite a você garantir que uma classe tenha apenas uma instância, enquanto provê um ponto de acesso global para essa instância.

## Intenção:
Garantir que uma determinada classe tenha uma, e somente uma instância, mantendo um ponto global de acesso para a mesma.

## Intenção: 
Permite a você garantir que a classe tenha apenas uma instância, enquanto você prevê um ponto de acesso global para essa instância.

## Problema: 
Um objeto ser instanciado mais de uma vez, não ficando integro a informação, por exemplo o saldo de uma conta.

## Solução: 
Precisa garantir que uma classe tenha apenas uma única instância, fornecendo um ponto global para acesso aquela instância.

Para isso precisa fazer o construtor padrão privado, para prevenir que outros objetos usem o operador new com a classe singleton.

Criar um método estático de criação que age como um construtor. Esse método chama o construtor privado por debaixo dos panos para criar um objeto e o salva em um campo estático. Todas as chamadas seguintes para esse método retornam o objeto em cache.

## Aplicabilidade: 
Utilize o padrão Singleton quando você precisa de um controle mais estrito sobre as variáveis globais, ou seja, uma classe em seu programa deve ter apenas uma instância disponível para todos seus clientes; por exemplo, um objeto de base de dados único compartilhado por diferentes partes do programa.

O padrão Singleton desabilita todos os outros meios de criar objetos de uma classe exceto pelo método especial de criação. Esse método tanto cria um novo objeto ou retorna um objeto existente se ele já tenha sido criado.

Ao contrário das variáveis globais, o padrão Singleton garante que há apenas uma instância de uma classe. Nada, a não ser a própria classe singleton, pode substituir a instância salva em cache.

Observe que você sempre pode ajustar essa limitação e permitir a criação de qualquer número de instâncias singleton. O único pedaço de código que requer mudanças é o corpo do método getInstance.

![Representação do Singleton](.\Singleton.png)

![Exemplo do Singleton](.\Singleton2.png)

## Prós:
* A certeza que uma classe só terá uma única instância;
* Você ganha um ponto de acesso global para aquela instância;
* O objeto é inicializado somente quando for pedido pela primeira vez;

## Contras:

* Viola o princípio  de responsabilidade única.
* Pode mascarar um design ruim.(quando os componentes sabem muito sobre cada um)
* O padrão requer tratamento especial em um ambiente multi threaded para que múltiplas threads não possam criar um objeto várias vezes.
* Complexidade de realizar testes unitários do código do cliente,pois muitos frameworks de testes dependem de herança.


## Como implementar:
Adicione um campo privado estático na classe para o armazenamento da instância singleton.
Declare um método de criação público estático para obter a instância singleton.
Implemente a “inicialização preguiçosa” dentro do método estático. Ela deve criar um novo objeto na sua primeira chamada e colocá-lo no campo estático. O método deve sempre retornar aquela instância em todas as chamadas subsequentes.
Faça o construtor da classe ser privado. O método estático da classe vai ainda ser capaz de chamar o construtor, mas não os demais objetos.
Vá para o código cliente e substitua todas as chamadas diretas para o construtor do singleton com chamadas para seu método de criação estático.

[Singleton ingênuo](SingletonIngenuo\README.MD)
[Singleton seguro para threads](SingletonSeguroParaThreads\README.MD)


## Relações com outros padrões

Uma classe _fachada_ a pode frequentemente ser transformada em uma __singleton__ já que um único objeto fachada é suficiente na maioria dos casos.

O __Flyweight__ seria parecido com o __Singleton__ se você, de algum modo, reduzisse todos os estados de objetos compartilhados para apenas um objeto __flyweight__. Mas há duas mudanças fundamentais entre esses padrões:

 + Deve haver apenas uma única instância singleton, enquanto que uma classe __flyweight__ pode ter múltiplas instâncias com diferentes estados intrínsecos.

 + O objeto __singleton__ pode ser mutável. Objetos __flyweight__ são imutáveis.

As __Fábricas Abstratas__, __Construtores__, e __Protótipos__ podem todos ser implementados como __Singletons__.
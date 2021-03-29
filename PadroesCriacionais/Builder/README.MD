# BUILDER

## Propósito:

O Builder é um padrão de projeto criacional que permite a você construir objetos complexos passo a passo. O padrão permite que você produza diferentes tipos e representações de um objeto usando o mesmo código de construção.

## Intenção:

Separar a construção de um objeto complexo da sua representação de modo que o mesmo processo de construção possa criar diferentes representações.
Separa a construção do objeto de sua representação.

## Problema:
Um objeto complexo que necessite de uma inicialização passo a passo trabalhosa de muitos campos e objetos agrupados. Tal código de inicialização fica geralmente enterrado dentro de um construtor monstruoso com vários parâmetros. Ou pior: espalhado por todo o código cliente.

Por exemplo você pode criar um construtor gigante diretamente na classe Casa base com todos os possíveis parâmetros que controlam o objeto casa. Embora essa abordagem realmente elimine a necessidade de subclasses, ela cria outro problema. Na maioria dos casos a maioria dos parâmetros não será usada, tornando as chamadas do construtor em algo feio de se ver. Por exemplo, apenas algumas casas têm piscinas, então os parâmetros relacionados a piscinas serão inúteis nove em cada dez vezes.

## Solução:

O padrão Builder sugere que você extraia o código de construção do objeto para fora de sua própria classe e mova ele para objetos separados chamados builders.

O padrão organiza a construção de objetos em uma série de etapas,permitindo que você construa objetos complexos passo a passo. O Builder não permite que outros objetos acessem o produto enquanto ele está sendo construído.

Builders diferentes executam a mesma tarefa de várias maneiras.
Por exemplo, imagine um builder que constrói tudo de madeira e vidro, um segundo builder que constrói tudo com pedra e ferro, e um terceiro que usa ouro e diamantes. 

![Representação do Builder](.\Builder.png)

## Aplicabilidade :

#### Use o padrão Builder para se livrar de um “construtor monstro”.
![Representação do Builder](.\Bug1.png)
Digamos que você tenha um construtor com dez parâmetros opcionais. Chamar um monstro desses é muito inconveniente; portanto, você sobrecarrega o construtor e cria diversas versões curtas com menos parâmetros. Esses construtores ainda se referem ao principal, passando alguns valores padrão para qualquer parâmetro omitido.

O padrão Builder permite que você construa objetos passo a passo, usando apenas aquelas etapas que você realmente precisa. Após implementar o padrão, você não vai mais precisar amontoar dúzias de parâmetros em seus construtores.

#### Use o padrão Builder quando você quer que seu código seja capaz de criar diferentes representações do mesmo produto (por exemplo, casas de pedra e madeira).
![Representação do Builder](.\Bug2.png)
O padrão Builder pode ser aplicado quando a construção de várias representações do produto envolvem etapas similares que diferem apenas nos detalhes.

A interface base do builder define todas as etapas de construção possíveis, e os buildrs concretos implementam essas etapas para construir representações particulares do produto. Enquanto isso, a classe diretor guia a ordem de construção.



#### Use o Builder para construir árvores Composite ou outros objetos complexos.

O padrão Builder permite que você construa produtos passo a passo. Você pode adiar a execução de algumas etapas sem quebrar o produto final. Você pode até chamar etapas recursivamente, o que é bem útil quando você precisa construir uma árvore de objetos.

Um builder não expõe o produto não finalizado enquanto o processo de construção estiver executando etapas. Isso previne o código cliente de obter um resultado incompleto.

## Como implementar:

Certifique-se que você pode definir claramente as etapas comuns de construção para construir todas as representações do produto disponíveis. Do contrário, você não será capaz de implementar o padrão.

Declare essas etapas na interface builder base.

Crie uma classe builder concreta para cada representação do produto e implemente suas etapas de construção.

Não se esqueça de implementar um método para recuperar os resultados da construção. O motivo pelo qual esse método não pode ser declarado dentro da interface do builder é porque vários builders podem construir produtos que não tem uma interface comum. Portanto, você não sabe qual será o tipo de retorno para tal método. Contudo, se você está lidando com produtos de uma única hierarquia, o método de obtenção pode ser adicionado com segurança para a interface base.

Pense em criar uma classe diretor. Ela pode encapsular várias maneiras de construir um produto usando o mesmo objeto builder.

O código cliente cria tanto os objetos do builder como do diretor. Antes da construção começar, o cliente deve passar um objeto builder para o diretor. Geralmente o cliente faz isso apenas uma vez, através de parâmetros do construtor do diretor. O diretor usa o objeto builder em todas as construções futuras. Existe uma alternativa onde o builder é passado diretamente ao método de construção do diretor.

O resultado da construção pode ser obtido diretamente do diretor apenas se todos os produtos seguirem a mesma interface. Do contrário o cliente deve obter o resultado do builder.

## Prós :

* Você pode construir objetos passo a passo, adiar as etapas de construção ou rodar etapas recursivamente.
* Você pode reutilizar o mesmo código de construção quando construindo várias representações de produtos.
* Princípio de responsabilidade única. Você pode isolar um código de construção complexo da lógica de negócio do produto.

## Contras :

* A complexidade geral do código aumenta uma vez que o padrão exige criar múltiplas classes novas.

## Relações com outros padrões

Muitos projetos começam usando o __Factory Method__ (menos complicado e mais customizável através de subclasses) e evoluem para o __Abstract Factory__, __Prototype__, ou __Builder__ (mais flexíveis, mas mais complicados).

O __Builder__ foca em construir objetos complexos passo a passo. O __Abstract Factory__ se especializa em criar famílias de objetos relacionados. O __Abstract Factory__ retorna o produto imediatamente, enquanto que o __Builder__ permite que você execute algumas etapas de construção antes de buscar o produto.

Você pode usar o __Builder__ quando criar árvores __Composite__ complexas porque você pode programar suas etapas de construção para trabalhar recursivamente.

Você pode combinar o __Builder__ com o __Bridge__: a classe diretor tem um papel de abstração, enquanto que diferentes construtores agem como implementações.

As _Fábricas Abstratas_, _Construtores_, e _Protótipos_ podem todos ser implementados como __Singletons__.
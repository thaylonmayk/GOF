# PADRÕES DE CRIAÇÃO (“criacionais”)

Aplicam-se em situações que envolvem a criação de objetos.

Ajudam a fazer um sistema independente de como seus objetos são criados, compostos e representados (Erich Gamma, et al.).

Eles disponibilizam uma maneira para criar objetos ocultando os detalhes da sua criação, ao invés de utilizar o operador new diretamente. Isto dá mais flexibilidade na hora de decidir quais objetos precisam ser criados para um determinado caso.


# Navegue entre eles

## [Criacional](README.MD)

### [Singleton](Singleton\README.MD)
Assegura que somente um objeto de uma determinada classe seja criado em todo o projeto;
### [Abstract Factory](AbstractFactory\README.md)
Permite que um cliente crie famílias de objetos sem especificar suas classes concretas;
### [Builder](Builder\README.MD)
Encapsular a construção de um produto e permitir que ele seja construído em etapas;
### [Prototype](Prototype\README.MD)
Permite você criar novas instancias simplesmente copiando instancias existentes;
### [Factory Mathod](FactoryMethod\README.MD)
As subclasses decidem quais classes concretas serão criadas;
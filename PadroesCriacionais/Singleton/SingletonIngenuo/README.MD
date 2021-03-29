# Singleton ingênuo

É muito fácil implementar um Singleton desleixado. Você só precisa ocultar o construtor e implementar um método de criação estático.

A mesma classe se comporta incorretamente em um ambiente multithread. Vários threads podem chamar o método de criação simultaneamente e obter várias instâncias da classe Singleton.a
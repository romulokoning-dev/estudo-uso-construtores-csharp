using System;

class Person //Criando Classe Person
{
    public string name; // Variável nula pública name
    public int age; // Variável nula pública age
    public string carreer;// Variável nula pública carreer
    public Person(string Name, int Age, string Carreer) // Aqui faço o uso do contrutor, criei um contrutor público com mesmo nome da classe, onde atribui nele novas strings: Name , Age e Carreer
    {
        name = Name; // digo que a variável name da classe Person equivale ao do construtor
        age = Age; // digo que a variável age da classe Person equivale ao do construtor
        carreer = Carreer; // digo que a variável carreer da classe Person equivale ao do construtor
    }

    public void Presentation() // Chamo o método Presentation para fazer a apresentação
    {
        Console.WriteLine($"Hello, my name is {name} im {age} years old and im {carreer}"); // interpolação com as variáveis no Console.WriteLine
    }
}


class Program // Classe Program para rodar o código principal
{
    static void Main()
    {
       Person p1 = new Person("Maria",10, "student"); // Aqui uso o construtor, onde economizo linhas de código que gastaria definindo os valores das variáveis uma por uma, consigo fazer tudo na mesma linha do objeto.
        p1.Presentation(); // Chamo direto o método com apenas 2 linhas de código.
        Person p2 = new Person("Pedro",20, "Mainteiner"); // Uso novamente o construtor para a Classe Person, definindo o objeto p2 e atribuindo os valores na mesma linha.
        p2.Presentation(); // Chamo o método Presentation para objeto p2
       
    }
}
// Nota sobre o estudo: Aprendi como usar os contrutores para código mais limpo, onde ao invés de fazer uso de várias linhas para declarar o valor de cada váriavel, declaro tudo em uma linha única vinculada ao objeto, favorecendo o código limpo e boas práticas de desenvolvimento.

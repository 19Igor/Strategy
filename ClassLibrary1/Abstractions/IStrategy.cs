namespace ClassLibrary1.Abstractions;

public interface IStrategy
{
    // Interfaces can contain properties and methods, but not fields.       
    int Pick(Deck deck);
}

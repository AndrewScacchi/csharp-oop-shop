// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva

//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//-alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//-Il codice prodotto sia accessibile solo in lettura
//-Gli altri attributi siano accessibili sia in lettura che in scrittura
//-Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//-Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//-Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

Product product1 = new Product();

//create new product
product1.SetName("//");
product1.SetName("TestName");
product1.SetDescription("Test Description Lorem Ipsum");
product1.SetPrice(123.45);
product1.SetIva(12);

//print to console
Console.WriteLine(product1.GetProdKey);
Console.WriteLine(product1.GetName());
Console.WriteLine(product1.GetDescription());
Console.WriteLine(product1.GetPrice());
Console.WriteLine(product1.GetIva());



public class Product
{
    //class attributes
    private int prodKey;
    private string name;
    private string description;
    private double price;
    private int iva;

    //constructor
    public Product()
    {
        Random random = new Random();
        prodKey = random.Next(1, 123456);
    }

    //methods
    public int GetProdKey()
    {
        return prodKey;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
    public void SetDescription(string description)
    {
        this.description = description;
    }
    public string GetDescription()
    {
        return description;
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public double GetPrice()
    {
        return price;
    }
    public void SetIva(int iva)
    {
        this.iva = iva;
    }
    public int GetIva()
    {
        return iva;
    }
    public double GetPricePostTax()
    {
        return price + (price / 100 * iva);
    }
    public string GetFullName()
    {
        return prodKey + " " + name;
    }
}
/*•	Где растет (protected)
•	Название (public)
•	Цена (private)
•	Форма (public)*/
class Fruit{
    protected string geograph;
    public string name;
    private double price;
    public string forma;
public Fruit(string geograph, string name, double price,string forma){
    this.geograph=geograph;
    this.name=name;
    this.price=price;
    this.forma=forma;
}
}

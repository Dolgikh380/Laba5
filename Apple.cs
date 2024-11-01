
class Apple : Fruit{
public string sort;
public double srrazmer;
public bool korneplod=false;
public Apple(string geograph, string name, double price, string forma,string sort, double  srrazmer, bool korneplod)
:base( geograph, name, price,forma){
    this.sort=sort;
    this.srrazmer=srrazmer;
    this.korneplod=korneplod;

}
}

/*•	Для яблока – сорт,  средний размер яблока,
•	Для ягоды – цвет (использовать перечисление), 
дата сбора урожая, 
•	Для яблока и ягоды – bool поле,
 является ли корнеплодом (инициализируется для 
 Apple  и Berry по умолчанию значением false)*/

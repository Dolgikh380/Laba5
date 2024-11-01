public enum Color {красный, зеленый, желтый, оранжевый};
class Berry : Fruit{
public Color color;
public DateTime datasbora;
public bool korneplod;
public Berry(string geograph, string name, double price, string forma, Color color , DateTime  datasbora, bool korneplod)
:base( geograph, name, price,forma){
    this.color=color;
    this.datasbora=datasbora;
    this.korneplod=korneplod;
}
public override void DisplayInfo()
        {
            Console.WriteLine($"Цвет: {color}, Дата сбора : {datasbora}, Корнеплодное: {korneplod}");
            base.DisplayInfo();
        }
}
/*•	Для ягоды – цвет (использовать перечисление), дата сбора урожая*/
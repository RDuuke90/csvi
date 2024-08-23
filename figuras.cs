/**
Este ejercicio tiene como objetivo crear un sistema para gestionar figuras geométricas. Se utilizará una clase abstracta Figura y una interfaz Calculable. La clase Figura tendrá atributos como nombre y color. La interfaz Calculable tendrá un método abstracto calcularArea(). Se crearán dos clases concretas que hereden de Figura e implementen Calculable: Circulo y Rectangulo. Cada una de estas clases tendrá sus propios métodos para calcular el área. Finalmente, se creará una lista de figuras y se calculará el área total de todas las figuras.
*/
Circulo r = new Circulo("Circulo 1", "Rojo", 10.0);
List<ICalculable> figuras = new List<ICalculable>
{
    r,
    new Rectangulo("Rectangulo 1", "Azul", 5.0, 10.0),
    new Circulo("Circulo 2", "Verde", 4.0),
    new Rectangulo("Rectangulo 2", "Amarillo", 4.0, 8.0)
};

double areaTotal = 0;

foreach(ICalculable figura in figuras) {
    Console.WriteLine(figura);
    areaTotal += figura.CalcularArea();
}

Console.WriteLine($"Area total de figura es: {areaTotal}");


public interface ICalculable
{
    double CalcularArea();
}

public abstract class AFigura
{
    public string nombre {set; get;}
    public string color { set; get;}

    public AFigura(string nombre, string color){
        this.nombre = nombre;
        this.color = color;
    }

}

public class Circulo : AFigura, ICalculable
{
    public Circulo(string nombre, string color, double radio) : base(nombre, color)
    {
        this.radio = radio;
    }
    
    public double radio { set; get;}
    public double CalcularArea(){
        return Math.PI * Math.Pow(radio, 2);
    }

    public override string ToString()
    {
        return $"Circulo: {this.nombre}, Color: {this.color}, Radio: {this.radio}, Area: {this.CalcularArea()}";
    }
}

public class Rectangulo: AFigura, ICalculable
{
    public double altura { get; set;}
    public double ancho {get; set;}

    public Rectangulo(string nombre, string color, double altura, double ancho) : base(nombre, color)
    {
        this.altura = altura;
        this.ancho = ancho;
    }

    public double CalcularArea(){
        return this.altura * this.ancho; 
    }

    public override string ToString()
    {
        return $"Rectangulo: {this.nombre}, Color: {this.color}, Altura: {this.altura}, Ancho: {this.ancho}, Area: {this.CalcularArea()}";
    }
}

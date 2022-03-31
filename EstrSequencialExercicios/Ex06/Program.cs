namespace Ex06 {
  class Ex06 {
    static void Main(string[] args) {
      float a, b, c;
      float areaTriang, areaCirc, areaTrapezio, areaquad, arearet;
      
      Console.WriteLine("Digite um numero: ");
      a = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite outro numero: ");
      b = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite mais um numero: ");
      c = float.Parse(Console.ReadLine());

      areaTriang = (a * c) / 2;
      areaCirc = (float)(c * 3.14159);
      areaTrapezio = ((a + b) / 2);
      areaquad = b * b;
      arearet = a * b;
      
      Console.WriteLine("A area do circulo é " + areaCirc);
      Console.WriteLine("A area do trapézio é: " + areaTrapezio);
      Console.WriteLine("A area do quadrado é " + areaquad);
      Console.WriteLine("A area do retangulo é: " + arearet);
    }
  }
}
class Program {
    static void Main(string[] args) {
        List<float> notas = new List<float>();
        float nota;

    Console.WriteLine("Ingrese la nota del estudiante: (-1 para finalizar)");
    do{
     nota = float.Parse(Console.ReadLine());
     if(nota >=0 && nota <= 10) {
       notas.Add(nota);
      }
     }while(nota != -1);

     float promedio=0;
     foreach (float n in notas) {
     promedio += n;
    }
    promedio /= notas.Count;

    Console.WriteLine("La nota del estudiante es:{0}",promedio);
     if(promedio >=4) {
        Console.WriteLine("El Estudiante a aprobado");
     }else{
        Console.WriteLine("El Estudiante a Reprobado");
     }
     Console.ReadKey();

  }
 }

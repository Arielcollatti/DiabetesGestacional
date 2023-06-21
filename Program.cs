Console.WriteLine(" ---DiabetesGestacional--- \n");

Console.Write("Digite o valor de glicemia (mg/dL)...: ");
double glicemia = double.Parse(Console.ReadLine()!);

if (glicemia < 92 )
{
    Console.Write("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}
    else if  (glicemia >= 92 && glicemia < 126)
    {
           Console.Write("Comapatível com Diabettes Gestacional");
    }
else
{
    Console.Write("Diabetes Mellitus na Gravizez");
}














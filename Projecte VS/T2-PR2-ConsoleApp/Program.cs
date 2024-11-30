using System;
using T2_PR2_ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        //Bloc de constants i variables
        const string MissatgeIntrodueixAmplada = "Introdueix l'amplada del rectangle: ",
            MissatgeIntrodueixAltura = "Introdueix l'altura del rectangle: ",
            MissatgeAreaRectangle = "L'àrea del rectangle és: {0}",
            MissatgeIntrodueixRadi = "Introdueix el radi del cercle: ",
            MissatgeCircumferencia = "La circumferència del cercle és: {0}";


        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        Console.Write(MissatgeIntrodueixAmplada);
        double width = Convert.ToDouble(Console.ReadLine());
        Console.Write(MissatgeIntrodueixAltura);
        double height = Convert.ToDouble(Console.ReadLine());

        // Calcula l'àrea
        double area = MyFunctions.CalcularArea(width, height);
        Console.WriteLine(MissatgeAreaRectangle, area);

        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        Console.Write(MissatgeIntrodueixRadi);
        double radius = Convert.ToDouble(Console.ReadLine());
        double circumference = MyFunctions.CalcularCircumferencia(radius);
        Console.WriteLine(MissatgeCircumferencia, circumference);

        MyFunctions.ImprimirRangDeArea(area);
    }
}
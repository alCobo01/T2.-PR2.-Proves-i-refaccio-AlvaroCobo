using System;
using T2_PR2_ClassLibrary;

class Program
{
    static void Main()
    {
        //Bloc de constants i variables
        const string MissatgeIntrodueixAmplada = "Introdueix l'amplada del rectangle: ",
            MissatgeIntrodueixAltura = "Introdueix l'altura del rectangle: ",
            MissatgeAreaRectangle = "L'àrea del rectangle és: {0}",
            MissatgeIntrodueixRadi = "Introdueix el radi del cercle: ",
            MissatgeCircumferencia = "La circumferència del cercle és: {0}";

        double width, height, area, circumference, radius;

        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        do {
            Console.Write(MissatgeIntrodueixAmplada);
            width = Convert.ToDouble(Console.ReadLine());
        } while (MyFunctions.IsUnderZero(width));

        do
        {
            Console.Write(MissatgeIntrodueixAltura);
            height = Convert.ToDouble(Console.ReadLine());
        } while (MyFunctions.IsUnderZero(height));

        Console.WriteLine();
        area = MyFunctions.CalcularArea(width, height);
        Console.WriteLine(MissatgeAreaRectangle, area);
        MyFunctions.ImprimirRangDeArea(area);

        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        do
        {
            Console.Write(MissatgeIntrodueixRadi);
            radius = Convert.ToDouble(Console.ReadLine());
        } while (MyFunctions.IsUnderZero(radius));
        
        // Calcula la circumferència
        circumference = MyFunctions.CalcularCircumferencia(radius);
        Console.WriteLine(MissatgeCircumferencia, circumference);
    }
}
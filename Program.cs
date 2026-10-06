


decimal[] typeNumbers = new decimal[2];
decimal result = 0;
decimal studenGrade = 0;
int options = 0;
int next = 1;
decimal newNumber;

do
{
    try
    {

        Console.WriteLine("Calculadora Básica\n");
        Console.WriteLine("Por favor, escriba el número de la opción que desea");
        Console.WriteLine("1. Suma ");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Evaluar estudiante (Aprobado / Reprobado)");
        Console.WriteLine("6. Salir del programa \n");

        Console.Write("Seleccione una opción: ");
        options = int.Parse(Console.ReadLine());




        if (options >= 1 && options <= 4)
        {

           typeNumbers = new decimal[2];

            Console.Write("Coloque el primer numero: ");
            typeNumbers[0] = decimal.Parse(Console.ReadLine());

            Console.Write("Coloque el segundo numero: ");
            typeNumbers[1] = decimal.Parse(Console.ReadLine());

            next = 1;
        

        while (next == 1)
        {
            Console.WriteLine("\n Desea agregar otro numero");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");

            next = int.Parse(Console.ReadLine());

                if (next != 1 && next != 2)
                {
                    Console.WriteLine("Error: debes seleccionar una de las dos opciones.");
                    next = 1;
                    continue;
                }



                if (next == 1)
            {
                Console.Write("Coloque otro número: ");

                newNumber = decimal.Parse(Console.ReadLine());

                decimal[] savedNumbers = new decimal[typeNumbers.Length + 1];

                for (int i = 0; i < typeNumbers.Length; i++)
                {
                    savedNumbers[i] = typeNumbers[i];
                }

                savedNumbers[savedNumbers.Length - 1] = newNumber;

                typeNumbers = savedNumbers;
            }
        }

        }

        switch (options)
        {

            case 1:
                {
                    result = 0;

                    for (int i = 0; i < typeNumbers.Length; i++)
                    {
                        result += typeNumbers[i];
                    }

                    Console.WriteLine($"El resultado es: {result}\n");
                    break;
                }

            case 2:
                {
                    result = typeNumbers[0];

                    for (int i = 1; i < typeNumbers.Length; i++)
                    {
                        result -= typeNumbers[i];
                    }

                    Console.WriteLine($"El resultado es: {result}\n");
                    break;

                }

            case 3:
                {
                    result = 1;

                    for (int i = 0; i < typeNumbers.Length; i++)
                    {
                        result *= typeNumbers[i];
                    }

                    Console.WriteLine($"El resultado es: {result}\n");
                    break;

                }

            case 4:
                {
                    try
                    {

                        result = typeNumbers[0];

                        for (int i = 1; i < typeNumbers.Length; i++)
                        {
                            result /= typeNumbers[i];
                        }

                        Console.WriteLine($"El resultado es: {result}\n");

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }


                    break;

                }

            case 5:
                {

                    try
                    {

                        Console.Write("Coloque la calificacion final del estudiante: ");
                        studenGrade = decimal.Parse(Console.ReadLine());

                        if (studenGrade < 0 || studenGrade > 100)
                        {
                            Console.WriteLine("Error: La calificacion debe estar entre 0 y 100");

                        }
                        else if (studenGrade >= 70)
                        {
                            Console.WriteLine("El estudiante fue aprobado \n");
                        }
                        else
                        {

                            Console.WriteLine("El estudiante fue reprobado \n");

                        }

                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Solo debes digitar la calificacion final del estudiante");
                    }

                }

                break;

            case 6:
                {
                    Console.WriteLine("Saliendo del programa.... ");
                    break;
                }

            default:
                Console.WriteLine("Opción no valida tienes que selecionar un numero de la lista.");
                break;

        }

    }


    catch
    {
        Console.WriteLine("Error: Ingrese solo números.");

    }

} while (options != 6);


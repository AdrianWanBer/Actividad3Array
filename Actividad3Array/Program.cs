namespace Atividad3Array
{
    class program
    {
        public static void Main(String[] args)
        {
            int[,] numeros = new int[10,10];

            int contador = 1;

            //Rellenar los huecos
            for (int filas = 9; filas >= 0; filas--)
            {
                for (int columnas = 9 ; columnas >= 0; columnas--)
                {
                    numeros[filas,columnas] = contador++;
                    ;
                }
            }
            //Imprimir los numeros
            for (int filas = 0; filas < 10; filas++)
            {
                for (int columnas = 0; columnas < 10; columnas++)
                {
                    Console.Write(numeros[filas, columnas]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            //Imprimir numeros de forma ascendente
            for (int filas = 9; filas >= 0; filas--)
            {
                for (int columnas = 9; columnas >= 0; columnas--)
                {
                    Console.WriteLine(numeros[filas,columnas]);
                }
            }
            
        }
    }
}
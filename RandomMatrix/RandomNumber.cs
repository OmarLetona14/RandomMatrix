using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMatrix
{
    class RandomNumber
    {
        int sumTotal, sum1, sum2, sum3, sum4,
            Csum1, Csum2, Csum3, Csum4;
        Random random = new Random();

        public void generateMatrix(){
            int[,] randomMatrix = new int[4, 4];

            for (int y = 0; y< 4;y++) {
                for (int x= 0; x<4; x++) {
                    randomMatrix[x, y] = generateRandom();
                    sumTotal += randomMatrix[x, y];
                    sumRow(y, randomMatrix[x, y]);
                    sumColumn(x, randomMatrix[x, y]);

                }                   
            }

            print(randomMatrix);
            printSum();
            printSumColumn();
            printBigger();
            sumDiagonal(randomMatrix);
            Console.WriteLine("La suma total de los numeros de la matriz es: "+sumTotal);
            Console.WriteLine("El promedio de la matriz es: " + (sumTotal/16));
            calcBiggSmaller(randomMatrix);
            
        }

        public int generateRandom()
        {
            
            return random.Next(1, 801);
        }
        public void calcBiggSmaller(int[,] matrix) {
            int mayor = 0, xMa = 0, yMa=0, xMe=0, yMe=0;
            int menor = matrix[0, 0];
            for (int y = 0; y < 4; y++)
            {     
                for (int x = 0; x <4 ; x++)
                {
                    if (matrix[x, y] > mayor)
                    {
                        mayor = matrix[x, y];
                        xMa = x;
                        yMa = y;
                    } else if (matrix[x, y] < menor) {
                        menor = matrix[x, y];
                        xMe = x;
                        yMe = y;
                    }
                }
            }
            Console.WriteLine("El numero mayor de la matriz se encuentra en la fila: " + xMa +
                            " y la columna: " + yMa);
            Console.WriteLine("El numero menor de la matriz se encuentra en la fila: " + xMe +
                           " y la columna: " + yMe);
              
        }
       


        public void print(int[,] matrix)
        {
            String line = "";
            for (int y = 0; y <=4; y++)
            {
                if (y != 0 && !(y > 7))
                {
                    Console.WriteLine(line);
                    line = "";
                }
                for (int x = 0; x < 4; x++)
                {
                    if (!(y >= 4))
                    {
                        line += "|"+ matrix[y,x] +"|";
                    }
                }
            }
        }
        public void sumColumn(int x, int value)
        {
            switch (x)
            {
                case 0:
                    Csum1 += value;
                    break;
                case 1:
                    Csum2 += value;
                    break;
                case 2:
                    Csum3 += value;
                    break;
                case 3:
                    Csum4 += value;
                    break;
            }

        }

        public void sumDiagonal(int[,] matriz) {
            int sumadiagonal = 0, i;
            
            for (i = 0; i < matriz.GetLength(0) && i < matriz.GetLength(1); i++)
            {
                sumadiagonal += matriz[i, i];
            }
            Console.WriteLine("La suma de la diagonal es: " + sumadiagonal);
        }

        public void sumRow(int y, int value) {
            switch (y) {
                case 0:
                    sum1 += value;
                    break;
                case 1:
                    sum2 += value;
                    break;
                case 2:
                    sum3 += value;
                    break;
                case 3:
                    sum4 += value;
                    break;
            }

        }

        public int biggerNumber(int N1, int N2, int N3, int N4) {
            if (N1 > N2 && N1 > N3 && N1 > N4)
            {
                return 0;
            }
            else if (N2 > N1 && N2 > N3 && N2 > N4)
            {
                return 1;
            }
            else if (N3 > N1 && N3 > N2 && N3 > N4)
            {
                return 2;
            }
            else { return 3; }
        }

        public void printSum() {
            Console.WriteLine("Suma de la fila 0: "+sum1);
            Console.WriteLine("Suma de la fila 1: " + sum2);
            Console.WriteLine("Suma de la fila 2: " + sum3);
            Console.WriteLine("Suma de la fila 3: " + sum4);
        }
        public void printSumColumn()
        {
            Console.WriteLine("Suma de la columna 0: " + Csum1);
            Console.WriteLine("Suma de la columna 1: " + Csum2);
            Console.WriteLine("Suma de la columna 2: " + Csum3);
            Console.WriteLine("Suma de la columna 3: " + Csum4);
        }

        public void printBigger() {
            Console.WriteLine("En la fila: "+biggerNumber(sum1,sum2,sum3,sum4) + " se registró la " +
                "mayor suma.");
            Console.WriteLine("En la columna: "+biggerNumber(Csum1, Csum2, Csum3, Csum4)+ " se registró la " +
                "mayor suma.");
        }

    }
}

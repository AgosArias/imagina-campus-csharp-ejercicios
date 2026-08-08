using System;
using System.IO;

namespace Tema10Ej2
{
    internal class Program
    {
        static void Main()
        {
            double[] doubleArray = new double[10000];
            var random = new Random(DateTime.Now.Millisecond);

            for (int i=0; i< doubleArray.Length; i++)
                doubleArray[i] = random.NextDouble();
            using(StreamWriter sw = new StreamWriter(File.Open("doubles.txt", FileMode.Create)))
            using(BinaryWriter bw = new BinaryWriter(File.Open("doubles.bin",FileMode.Create)))
            {
                foreach(var doubleNumber in doubleArray)
                {
                    sw.WriteLine(doubleNumber);
                    bw.Write(doubleNumber);
                }
            }
            FileInfo textFile = new FileInfo("doubles.txt");
            FileInfo binaryFile = new FileInfo("doubles.bin");

            Console.WriteLine("Tamaño fichero texto: " + textFile.Length);
            Console.WriteLine("Tamaño fichero binario: " + binaryFile.Length);           
        }
    }
}



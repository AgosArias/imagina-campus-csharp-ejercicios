using System;
using System.IO;

namespace Tema10Ej1
{
    internal class Program{
        static void Main()
        {
            string carpeta = "/home/agos/Docs";
            string archivoSalida = "ejercicio1.txt";

            DirectoryInfo programFiles = new DirectoryInfo(carpeta);
            using(StreamWriter sw = new StreamWriter(File.Open(archivoSalida,FileMode.Create)))
            {
                try
                {
                    foreach(var directory in programFiles.GetDirectories("*",SearchOption.AllDirectories))
                    {
                        sw.WriteLine(directory.FullName);
                        foreach(var file in directory.GetFiles())
                        {
                            sw.WriteLine("\t"+file.Name);
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error de E/S: " + ex.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine("Error, no se tienen permisos: " + ex.Message);
                }
            }
        }
    }

}
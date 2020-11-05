using System;

namespace Checkpoint_uke1
{

    public class Triangle
    {


        public void BuildTriangle()
        {

            Console.WriteLine("Skriv inn siffer som angir lengde på triangelen adskilt med '-'");

            string[] Values = Console.ReadLine().Split('-');
            string Star = "";
            foreach (var item in Values)
            {

                int Input = Convert.ToInt32(item);

                for (int i = 0; i < Input; i++)
                {
                    Star += "*";
                    Console.WriteLine(Star);

                }

                Star = "";

                Console.WriteLine();

            }

        }

    }

    public class TriangleA
    {
        public void DrawLine(int length)
        {
            for (int j = 1; j <= length; j++)
            {
                Console.Write('*');
            }
            Console.Write('\n');
        }
        public void BuildTriangle()
        {

            Console.WriteLine("Skriv inn bokstav og siffer som angir lengde på triangelen adskilt med '-' hvor A er voksende triangel og B er krympende");

            string[] Values = Console.ReadLine().Split('-');



            string Star = "";
            foreach (var item in Values)
            {

                if (item.StartsWith('A'))
                {
                    int Input = Convert.ToInt32(item.Substring(1));

                    for (int i = 0; i < Input; i++)
                    {
                        DrawLine(i);
                    }

                }
                else if(item.StartsWith('B'))
                {
                    int Input = Convert.ToInt32(item.Substring(1));
                    
                    for (int i = Input; i >= 1; i--)
                    {
                        DrawLine(i);

                    }


                }


                Console.WriteLine();

            }

        }




    }

}

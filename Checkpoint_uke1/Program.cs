using System.Security.Cryptography.X509Certificates;

namespace Checkpoint_uke1
{
    class Program
    {
        static void Main(string[] args)
        {
            Build.Start();

            Build.StartTwo();



        }

    }

    public class Build
    {
            
        public static void Start()
        {
            Triangle t = new Triangle();
            t.BuildTriangle();
        }

        public static void StartTwo()
        {
            TriangleA tA = new TriangleA();

            tA.BuildTriangle();
        }


    }
    
}

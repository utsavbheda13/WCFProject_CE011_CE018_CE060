using MovieRatingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingSystemHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MovieSystem);
            Uri http = new Uri("http://localhost:8000/MovieSystem");
            ServiceHost host = new ServiceHost(t, http);
            host.Open();
            Console.WriteLine("Published...");
            Console.ReadLine();
            host.Close();
        }
    }
}

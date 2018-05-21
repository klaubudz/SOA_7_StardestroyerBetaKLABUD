using StardestroyerBetaKLABUD.ServiceOldBay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardestroyerBetaKLABUD
{
    class Program
    {
        private static readonly OldBayKLABUDClient _oldbay = new OldBayKLABUDClient();

        static void Main(string[] args)
        {
            _oldbay.CreateWing(new Wing()
            {
                Power = 200,
                Shield = 300,
                Name = "DeathStar"

            });

            Console.WriteLine(_oldbay.GetWing("DeathStar"));
        }
    }
}

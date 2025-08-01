using System;
namespace Inheritance;

public class Reptile : Animal
{
    public Reptile()
    {
        IsAlive = true;
        LegCount = 4;
        LandSeaAir = "Land";
        Age = 0;
    }
    public bool IsColdBlooded { get; set; }
    public bool CanWalk { get; set; }
    public double Lifespan { get; set; }
    public bool IsScaly { get; set; }
}
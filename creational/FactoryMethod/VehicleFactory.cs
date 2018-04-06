using System;

namespace FactoryMethod
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
}

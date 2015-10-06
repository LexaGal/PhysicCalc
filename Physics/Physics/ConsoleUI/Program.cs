using System;
using Calculator.Operands;
using Calculator.PhysicUnits;

namespace ConsoleUI
{
    class Program
    {
        private static void Main()
        {
            AllPhysicUnits allPhysicUnits = new AllPhysicUnits();
            Operand o1 = new Operand(10, allPhysicUnits.GetPhysicUnit(Unit.Gram));
            Operand o2 = new Operand(5, allPhysicUnits.GetPhysicUnit(Unit.KilometreInHour));
            Operand o3 = new Operand(2, allPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
            Operand o4 = new Operand(4, allPhysicUnits.GetPhysicUnit(Unit.KilometreInHour));
            Operand o5 = new Operand(6, allPhysicUnits.GetPhysicUnit(Unit.Hour));
            Operand o6 = new Operand(1, allPhysicUnits.GetPhysicUnit(Unit.Second));
            Operand o7 = new Operand(1, allPhysicUnits.GetPhysicUnit(Unit.Second));
            Operand o8 = new Operand(8, allPhysicUnits.GetPhysicUnit(Unit.Kilogram));
            Operand o9 = new Operand(10, allPhysicUnits.GetPhysicUnit(Unit.Second));

            Operand pulse = o1*(o2 + o3);
            Operand distance = (o4*(o5 + o6)/o7*o8 + pulse)/o9;

            Console.WriteLine(pulse);
            Console.WriteLine(distance);
            Console.ReadKey();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace Calculator.PhysicUnits
{
    public class AllPhysicUnits
    {
        public List<SiPhysicUnit> SiPhysicUnits { get; private set; }
        public List<PhysicUnit> PhysicUnits { get; private set; }


        public AllPhysicUnits()
        {
            SiPhysicUnit siMetre = new SiPhysicUnit(SiUnit.Metre, UnitType.Distance, new Dictionary<PhysicUnit, double>());
            SiPhysicUnit siKilogram = new SiPhysicUnit(SiUnit.Kilogram, UnitType.Mass, new Dictionary<PhysicUnit, double>());
            SiPhysicUnit siSecond = new SiPhysicUnit(SiUnit.Second, UnitType.Time, new Dictionary<PhysicUnit, double>());
            SiPhysicUnit siMetreInSecond = new SiPhysicUnit(SiUnit.MetreInSecond, UnitType.Speed, new Dictionary<PhysicUnit, double>());
            SiPhysicUnit siMetreInSecond2 = new SiPhysicUnit(SiUnit.MetreInSecond2, UnitType.Acceleration, new Dictionary<PhysicUnit, double>());
            SiPhysicUnit siKilogramOnMetreInSecond = new SiPhysicUnit(SiUnit.KilogramOnMetreInSecond, UnitType.Impulse,
                new Dictionary<PhysicUnit, double>());
            SiPhysicUnit siKilogramOnMetreInSecond2 = new SiPhysicUnit(SiUnit.KilogramOnMetreInSecond2, UnitType.Power,
                new Dictionary<PhysicUnit, double>());
            
            PhysicUnit metre = new PhysicUnit(Unit.Metre, new KeyValuePair<SiPhysicUnit, double>(siMetre, 1));
            PhysicUnit kilogram = new PhysicUnit(Unit.Kilogram, new KeyValuePair<SiPhysicUnit, double>(siKilogram, 1));
            PhysicUnit second = new PhysicUnit(Unit.Second, new KeyValuePair<SiPhysicUnit, double>(siSecond, 1));
            PhysicUnit metreInSecond = new PhysicUnit(Unit.MetreInSecond, new KeyValuePair<SiPhysicUnit, double>(siMetreInSecond, 1));
            PhysicUnit metreInSecond2 = new PhysicUnit(Unit.MetreInSecond2, new KeyValuePair<SiPhysicUnit, double>(siMetreInSecond2, 1));
            PhysicUnit kilogramOnMetreInSecond2 = new PhysicUnit(Unit.KilogramOnMetreInSecond2,
              new KeyValuePair<SiPhysicUnit, double>(siKilogramOnMetreInSecond2, 1));
            PhysicUnit kilogramOnMetreInSecond = new PhysicUnit(Unit.KilogramOnMetreInSecond,
              new KeyValuePair<SiPhysicUnit, double>(siKilogramOnMetreInSecond, 1));
            PhysicUnit kilometre = new PhysicUnit(Unit.Kilometre, new KeyValuePair<SiPhysicUnit, double>(siMetre, 1000));
            PhysicUnit gram = new PhysicUnit(Unit.Gram, new KeyValuePair<SiPhysicUnit, double>(siKilogram, 0.001));
            PhysicUnit hour = new PhysicUnit(Unit.Hour, new KeyValuePair<SiPhysicUnit, double>(siSecond, 3600));
            PhysicUnit kilometreInHour = new PhysicUnit(Unit.KilometreInHour, new KeyValuePair<SiPhysicUnit, double>(siMetreInSecond, 0.28));

            siMetre.PhysicUnits.Add(new KeyValuePair<PhysicUnit, double>(kilometre, 0.001));
            siKilogram.PhysicUnits.Add(new KeyValuePair<PhysicUnit, double>(gram, 1000));
            siSecond.PhysicUnits.Add(new KeyValuePair<PhysicUnit, double>(hour, 0.00028));
            siMetreInSecond.PhysicUnits.Add(new KeyValuePair<PhysicUnit, double>(kilometreInHour, 3.6));

            SiPhysicUnits = new List<SiPhysicUnit>
            {
                siMetre,
                siKilogram,
                siSecond,
                siMetreInSecond,
                siMetreInSecond2,
                siKilogramOnMetreInSecond2
            };

            PhysicUnits = new List<PhysicUnit>
            {
                metre, 
                kilogram,
                second,
                metreInSecond,
                metreInSecond2,
                kilogramOnMetreInSecond2,
                kilometre,
                gram,
                hour,
                kilometreInHour,
                kilogramOnMetreInSecond
            };

        }

        public void AddSiPhysicUnit(SiPhysicUnit siPhysicUnit)
        {
            SiPhysicUnits.Add(siPhysicUnit);
        }

        public void AddPhysicUnit(SiPhysicUnit siPhysicUnit, PhysicUnit physicUnit, double coeff)
        {
            PhysicUnits.Add(physicUnit);
            siPhysicUnit.PhysicUnits.Add(new KeyValuePair<PhysicUnit, double>(physicUnit, coeff));
            physicUnit.SiPhysicUnit = new KeyValuePair<SiPhysicUnit, double>(siPhysicUnit, 1/coeff);
        }

        public PhysicUnit GetPhysicUnit(Unit unit)
        {
            return PhysicUnits.First(u => u.Unit == unit);
        }
    }
}

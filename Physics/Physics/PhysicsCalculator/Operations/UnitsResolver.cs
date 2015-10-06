using System.Collections.Generic;
using Calculator.Operands;
using Calculator.PhysicUnits;

namespace Calculator.Operations
{
    public static class OperationsApplier
    {
        private static readonly AllPhysicUnits AllPhysicUnits = new AllPhysicUnits();

        public static Operand ApplyOperation(this Operand o1, Operand o2, Operation operation)
        {
            switch (o1.PhysicUnit.SiPhysicUnit.Key.UnitType)
            {
                case UnitType.Mass:
                    switch (o2.PhysicUnit.SiPhysicUnit.Key.UnitType)
                    {
                        case UnitType.Mass:
                            switch (operation)
                            {
                                case Operation.Add:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Gram:
                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return new Operand(o1.Value + o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                        case Unit.Kilogram:
                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return new Operand(o1.Value + o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Subtract:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Gram:
                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return new Operand(o1.Value - o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                        case Unit.Kilogram:
                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return new Operand(o1.Value - o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Distance:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Time:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Speed:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Gram:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value*
                                                        o2.PhysicUnit.SiPhysicUnit.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }
                                            return null;
                                        case Unit.Kilogram:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(
                                                    o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Impulse:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Acceleration:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Gram:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond2));
                                            }
                                            return null;
                                        case Unit.Kilogram:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond2));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Power:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;
                    }
                    break;


//------------------------------------------

                case UnitType.Distance:
                    switch (o2.PhysicUnit.SiPhysicUnit.Key.UnitType)
                    {
                        case UnitType.Mass:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Distance:
                            switch (operation)
                            {
                                case Operation.Add:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Metre:
                                            if (o2.PhysicUnit.Unit == Unit.Metre)
                                            {
                                                return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Kilometre)
                                            {
                                                return new Operand(o1.Value + o2.Value*o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                        case Unit.Kilometre:
                                            if (o2.PhysicUnit.Unit == Unit.Metre)
                                            {
                                                return new Operand(o1.Value + o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Kilometre)
                                            {
                                                return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Subtract:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Metre:
                                            if (o2.PhysicUnit.Unit == Unit.Metre)
                                            {
                                                return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Kilometre)
                                            {
                                                return new Operand(o1.Value - o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                        case Unit.Kilometre:
                                            if (o2.PhysicUnit.Unit == Unit.Metre)
                                            {
                                                return new Operand(o1.Value - o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            if (o2.PhysicUnit.Unit == Unit.Kilometre)
                                            {
                                                return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Time:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Metre:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }
                                            return null;
                                        case Unit.Kilometre:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value/o2.Value/
                                                        o1.PhysicUnit.SiPhysicUnit.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }
                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilometreInHour));
                                            }
                                            return null;
                                    }
                                    break;
                            }
                            break;

                        case UnitType.Speed:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Metre:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Second));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Second));
                                            }
                                            return null;
                                        case Unit.Kilometre:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value/o2.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.Second));
                                            }
                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Hour));
                                            }
                                            return null;
                                    }
                                    break;
                            }
                            break;

                        case UnitType.Impulse:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Acceleration:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Power:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null; // работа А=F*S
                                case Operation.Divide:
                                    return null;
                            }
                            break;
                    }
                    break;

//------------------------------------------

                case UnitType.Time:
                    switch (o2.PhysicUnit.SiPhysicUnit.Key.UnitType)
                    {
                        case UnitType.Mass:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Time:
                            switch (operation)
                            {
                                case Operation.Add:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Second:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value + o2.Value*o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                        case Unit.Hour:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value + o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Subtract:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Second:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value - o2.Value*o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                        case Unit.Hour:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value - o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Distance:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Speed:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Second:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Metre));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Metre));
                                            }
                                            return null;
                                        case Unit.Hour:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.Metre));
                                            }
                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Kilometre));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Impulse:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Acceleration:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Second:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }
                                            return null;
                                        case Unit.Hour:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Power:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.Second:
                                            if (o2.PhysicUnit.Unit == Unit.KilogramOnMetreInSecond2)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }
                                            return null;
                                        case Unit.Hour:
                                            if (o2.PhysicUnit.Unit == Unit.KilogramOnMetreInSecond2)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    return null;
                            }
                            break;
                    }
                    break;


                //------------------------------------------

                case UnitType.Speed:
                    switch (o2.PhysicUnit.SiPhysicUnit.Key.UnitType)
                    {
                        case UnitType.Mass:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }
                                            return null;
                                        case Unit.KilometreInHour:
                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }
                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value*
                                                        o2.PhysicUnit.SiPhysicUnit.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }
                                            return null;
                                    }
                                    break;

                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Time:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Metre));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Metre));
                                            }
                                            return null;
                                        case Unit.KilometreInHour:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Metre));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Kilometre));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
                                            }
                                            return null;
                                        case Unit.KilometreInHour:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value/o2.Value*
                                                        o2.PhysicUnit.SiPhysicUnit.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
                                            }
                                            return null;
                                    }
                                    break;
                            }
                            break;

                        case UnitType.Distance:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Speed:
                            switch (operation)
                            {
                                case Operation.Add:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value + o2.Value,
                                                    o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value + o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                        case Unit.KilometreInHour:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value + o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value + o2.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Subtract:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value - o2.Value,
                                                    o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value - o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                        case Unit.KilometreInHour:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value - o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
                                                    o1.PhysicUnit);
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value - o2.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Impulse:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Acceleration:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Second));
                                            }
                                            return null;
                                        case Unit.KilometreInHour:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return
                                                    new Operand(
                                                        o1.Value*o1.PhysicUnit.SiPhysicUnit.Value/o2.Value,
                                                        AllPhysicUnits.GetPhysicUnit(Unit.Second));
                                            }
                                            return null;
                                    }
                                    break;
                            }
                            break;

                        case UnitType.Power:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;
                    }
                    break;

                //------------------------------------------

                case UnitType.Impulse:
                    switch (o2.PhysicUnit.SiPhysicUnit.Key.UnitType)
                    {
                        case UnitType.Mass:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }
                                            return null;
                                    }
                                    break;

                            }
                            break;

                        case UnitType.Time:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond2));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond2));
                                            }
                                            return null;
                                    }
                                    break;
                            }
                            break;

                        case UnitType.Distance:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Speed:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Kilogram));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.KilometreInHour)
                                            {
                                                return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Kilogram));
                                            }
                                            return null;
                                    }
                                    break;
                            }
                            break;

                        case UnitType.Impulse:
                            switch (operation)
                            {
                                case Operation.Add:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.KilogramOnMetreInSecond)
                                            {
                                                return new Operand(o1.Value + o2.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Subtract:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.KilogramOnMetreInSecond)
                                            {
                                                return new Operand(o1.Value - o2.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Acceleration:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Power:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond:
                                            if (o2.PhysicUnit.Unit == Unit.KilogramOnMetreInSecond2)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Second));
                                            }
                                            return null;
                                    }
                                    break;

                            }
                            break;
                    }
                    break;

//------------------------------------------

                case UnitType.Acceleration:
                    switch (o2.PhysicUnit.SiPhysicUnit.Key.UnitType)
                    {
                        case UnitType.Mass:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond2));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond2));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    return null;

                            }
                            break;

                        case UnitType.Time:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Distance:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Speed:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Impulse:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Acceleration:
                            switch (operation)
                            {
                                case Operation.Add:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return new Operand(o1.Value + o2.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Subtract:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.MetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return new Operand(o1.Value - o2.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Power:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;
                    }
                    break;

                //------------------------------------------

                case UnitType.Power:
                    switch (o2.PhysicUnit.SiPhysicUnit.Key.UnitType)
                    {
                        case UnitType.Mass:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.Kilogram)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Gram)
                                            {
                                                return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
                                            }
                                            return null;
                                    }
                                    break;

                            }
                            break;

                        case UnitType.Time:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.Second)
                                            {
                                                return new Operand(o1.Value*o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }

                                            if (o2.PhysicUnit.Unit == Unit.Hour)
                                            {
                                                return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Distance:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Speed:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Impulse:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;

                        case UnitType.Acceleration:
                            switch (operation)
                            {
                                case Operation.Add:
                                    return null;
                                case Operation.Subtract:
                                    return null;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.MetreInSecond2)
                                            {
                                                return new Operand(o1.Value/o2.Value,
                                                    AllPhysicUnits.GetPhysicUnit(Unit.Kilogram));
                                            }
                                            return null;
                                    }
                                    break;
                            }
                            break;

                        case UnitType.Power:
                            switch (operation)
                            {
                                case Operation.Add:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.KilogramOnMetreInSecond2)
                                            {
                                                return new Operand(o1.Value + o2.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Subtract:
                                    switch (o1.PhysicUnit.Unit)
                                    {
                                        case Unit.KilogramOnMetreInSecond2:
                                            if (o2.PhysicUnit.Unit == Unit.KilogramOnMetreInSecond2)
                                            {
                                                return new Operand(o1.Value - o2.Value,
                                                    o1.PhysicUnit);
                                            }
                                            return null;
                                    }
                                    break;
                                case Operation.Multiply:
                                    return null;
                                case Operation.Divide:
                                    return null;
                            }
                            break;
                    }
                    break;
            }
            return null;
        }
    }
}

//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Metre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilometre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Second:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Hour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilometreInHour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value*
//                                                       o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond2));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;
//                    }
//                    break;

//                case Unit.Kilogram:
//                    switch (o2.PhysicUnit.Unit)
//                    {
//                        case Unit.Gram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilogram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Metre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilometre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Second:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Hour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilometreInHour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond2));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;
//                    }
//                    break;

//                case Unit.Metre:
//                    switch (o2.PhysicUnit.Unit)
//                    {
//                        case Unit.Gram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilogram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Metre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilometre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Second:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
//                            }
//                            break;

//                        case Unit.Hour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
//                            }
//                            break;

//                        case Unit.MetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Second));
//                            }
//                            break;

//                        case Unit.KilometreInHour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.Second));
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;
//                    }
//                    break;

//                case Unit.Kilometre:
//                    switch (o2.PhysicUnit.Unit)
//                    {
//                        case Unit.Gram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilogram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Metre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilometre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Second:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value/o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
//                            }
//                            break;

//                        case Unit.Hour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilometreInHour));
//                            }
//                            break;

//                        case Unit.MetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value/o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.Second));
//                            }
//                            break;

//                        case Unit.KilometreInHour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.Hour));
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;
//                    }
//                    break;

//                case Unit.Second:
//                    switch (o2.PhysicUnit.Unit)
//                    {
//                        case Unit.Gram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilogram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Metre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilometre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Second:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Hour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Metre));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilometreInHour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.Metre));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;
//                    }
//                    break;

//                case Unit.Hour:
//                    switch (o2.PhysicUnit.Unit)
//                    {
//                        case Unit.Gram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilogram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Metre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilometre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Second:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value/o1.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Hour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value/o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.Metre));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilometreInHour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Kilometre));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.MetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o1.PhysicUnit.SiPhysicUnit.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;
//                    }
//                    break;

//                case Unit.MetreInSecond:
//                    switch (o2.PhysicUnit.Unit)
//                    {
//                        case Unit.Gram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilogram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Metre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilometre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Second:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Metre));
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
//                            }
//                            break;

//                        case Unit.Hour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value*o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.Metre));
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
//                            }
//                            break;

//                        case Unit.MetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilometreInHour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value*o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Kilogram));
//                            }
//                            break;

//                        case Unit.MetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value/o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Second));
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;
//                    }
//                    break;

//                    //??
//                case Unit.KilometreInHour:
//                    switch (o2.PhysicUnit.Unit)
//                    {
//                        case Unit.Gram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value * o2.Value * o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilogram:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value * o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.KilogramOnMetreInSecond));
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Metre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Kilometre:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.Second:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value * o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Metre));
//                                case Operation.Divide:
//                                    return new Operand(o1.Value / o2.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
//                            }
//                            break;

//                        case Unit.Hour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return new Operand(o1.Value * o2.Value * o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.Metre));
//                                case Operation.Divide:
//                                    return new Operand(o1.Value / o2.Value * o2.PhysicUnit.SiPhysicUnit.Value,
//                                        AllPhysicUnits.GetPhysicUnit(Unit.MetreInSecond2));
//                            }
//                            break;

//                        case Unit.MetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value, o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value, o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilometreInHour:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return new Operand(o1.Value + o2.Value * o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Subtract:
//                                    return new Operand(o1.Value - o2.Value * o2.PhysicUnit.SiPhysicUnit.Value,
//                                        o1.PhysicUnit);
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value / o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Kilogram));
//                            }
//                            break;

//                        case Unit.MetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return new Operand(o1.Value / o2.Value, AllPhysicUnits.GetPhysicUnit(Unit.Second));
//                            }
//                            break;

//                        case Unit.KilogramOnMetreInSecond2:
//                            switch (operation)
//                            {
//                                case Operation.Add:
//                                    return null;
//                                case Operation.Subtract:
//                                    return null;
//                                case Operation.Multiply:
//                                    return null;
//                                case Operation.Divide:
//                                    return null;
//                            }
//                            break;
//                    }
//                    break;
//            }
//            return null;
//        }
//    }
//}
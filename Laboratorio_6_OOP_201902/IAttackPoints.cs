using System;
using Laboratorio_6_OOP_201902.Enums;

namespace Laboratorio_6_OOP_201902
{
    public interface IAttackPoints
    {
        int[] GetAttackPoints(EnumType line = EnumType.None);
    }
}

﻿using System;



namespace FastEnum.Tests.Models
{
    public enum SByteEnum : sbyte
    {
        MinValue = sbyte.MinValue,
        Zero = 0,
        MaxValue = sbyte.MaxValue,
    }


    public enum ByteEnum : byte
    {
        MinValue = byte.MinValue,
        MaxValue = byte.MaxValue,
    }


    public enum Int16Enum : short
    {
        MinValue = short.MinValue,
        Zero = 0,
        MaxValue = short.MaxValue,
    }


    public enum UInt16Enum : ushort
    {
        MinValue = ushort.MinValue,
        MaxValue = ushort.MaxValue,
    }


    public enum Int32Enum : int
    {
        MinValue = int.MinValue,
        Zero = 0,
        MaxValue = int.MaxValue,
    }


    public enum UInt32Enum : uint
    {
        MinValue = uint.MinValue,
        MaxValue = uint.MaxValue,
    }


    public enum Int64Enum : long
    {
        MinValue = long.MinValue,
        Zero = 0,
        MaxValue = long.MaxValue,
    }


    public enum UInt64Enum : ulong
    {
        MinValue = ulong.MinValue,
        MaxValue = ulong.MaxValue,
    }


    [Flags]
    public enum Flags
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Four = 4,
    }
}

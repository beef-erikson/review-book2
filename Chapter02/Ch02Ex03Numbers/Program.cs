WriteLine(("").PadRight(77, '-'));
WriteLine($"{"Type",-10} {"Byte(s) of memory",-4} {"Min",17} {"Max",30}");
WriteLine(("").PadRight(77, '-'));

WriteLine($"{"sbyte",-10} {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"{"byte",-10} {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"{"short",-10} {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"{"ushort",-10} {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"{"int",-10} {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"{"uint",-10} {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"{"long",-10} {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"{"ulong",-10} {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"{"float",-10} {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"{"double",-10} {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"{"decimal",-10} {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
WriteLine($"{"Half",-10} {"NA",-4} {System.Half.MinValue,30} {System.Half.MaxValue,30}");
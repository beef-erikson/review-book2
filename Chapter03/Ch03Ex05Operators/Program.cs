int x = 3;
int y = 2 + ++x;
WriteLine($"x is {x} y is {y}");

x = 3 << 2;
y = 10 >> 1;
WriteLine($"x is {x} y is {y}");

x = 10 & 8;
y = 10 | 7;
WriteLine($"x is {x} y is {y}");
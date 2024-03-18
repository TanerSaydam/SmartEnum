using Ardalis.SmartEnum;

namespace ConsoleApp2;
public sealed class CreditCard2 : SmartEnum<CreditCard2>
{
    public static readonly CreditCard2 Standard = new(nameof(Standard), 1);
    public static readonly CreditCard2 Platinum = new(nameof(Platinum), 2);
    public static readonly CreditCard2 Premium = new(nameof(Premium), 3);
    public CreditCard2(string name, int value) : base(name, value)
    {
    }
}

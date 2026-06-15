namespace StrykerConsole;

public class Foobar(int value)
{
    public int Value { get; set; } = value;

    public int Value2
    {
        get
        {
            int field = Value * 2; // valid C# 12, breaks in C# 14 (contextual keyword clash)
            return field;
        }
    }

    public int AddedValues()
    {
        return Value + Value2;
    }
}
public class Money
{
    private int rubles;
    private int kopecks;
    public Money(int rubles, int kopecks)
    {
        this.rubles = rubles;
        this.kopecks = kopecks;
    }
    public static Money operator +(Money a, Money b)
    {
        return new Money(a.rubles + b.rubles + (a.kopecks + b.kopecks) / 100, (a.kopecks + b.kopecks) % 100);
    }
    public static bool operator == (Money a, Money b)
    {
        if (a.kopecks % 100 == b.kopecks % 100 && a.rubles + a.kopecks / 100 == b.rubles + b.kopecks / 100) return true;
        return false;
    }
    public static bool operator !=(Money a, Money b)
    {
        if (a.kopecks % 100 != b.kopecks % 100 && a.rubles + a.kopecks / 100 != b.rubles + b.kopecks / 100) return true;
        return false;
    }
    public override string ToString()
    {
        return $"{rubles} руб {kopecks} коп";
    }
}
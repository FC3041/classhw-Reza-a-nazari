namespace S14
{
    public interface IZnumber
    {
        double x { get; set; }
        double y { get; set; }
        IZnumber Sum(IZnumber other);
        IZnumber Minus(IZnumber other);
        double Distance();
        string PrintNum();
    }
}
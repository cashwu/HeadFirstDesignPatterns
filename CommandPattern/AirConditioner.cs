public class AirConditioner
{
    public AirConditioner()
    {
        Degrees = 26;
        Fan = 3;
    }

    /// <summary>
    /// 溫度
    /// </summary>
    public int Degrees { get; set; }

    /// <summary>
    /// 風量
    /// </summary>
    public byte Fan { get; set; }
}
namespace _30._11._2023
{
    internal interface IBuilding
    {
        uint Id { get; }
        uint High { get; }
        uint Level { get; }
        uint NumberOfApartament { get; }
        uint Entrance { get; }
        uint HighLevel { get; }
        uint NumberOfApartamentsInEnrtance { get; }
        uint NumberOfApartamentsInLevel { get; }
        void Build();
    }
}

namespace _30._11._2023
{
    internal class PanelBuild : IBuilding
    {
        private uint id;
        private uint high;
        private uint level;
        private uint numberOfApartament;
        private uint entrance;
        private bool status;
        private uint highLevel;
        private uint numberOfApartamentsInEnrtance;
        private uint numberOfApartamentsInLevel;
        private string description;

        public PanelBuild() { }
        public PanelBuild(uint id, uint high, uint level, uint numberOfApartament, uint entrance)
        {
            this.id = id;
            this.high = high;
            this.level = level;
            this.numberOfApartament = numberOfApartament;
            this.entrance = entrance;
            this.status = true;
            this.highLevel = this.high / this.level;
            this.numberOfApartamentsInEnrtance = this.numberOfApartament / this.entrance;
            this.numberOfApartamentsInLevel = (this.numberOfApartament / this.level) / this.entrance;
            this.description = "Панельное здание";
        }

        public uint Id => id;
        public uint High => high;
        public uint Level => level;
        public uint NumberOfApartament => numberOfApartament;
        public uint Entrance => entrance;
        public uint HighLevel => highLevel = High / Level;
        public uint NumberOfApartamentsInEnrtance => numberOfApartamentsInLevel = NumberOfApartament / Entrance;
        public uint NumberOfApartamentsInLevel => numberOfApartamentsInLevel = (NumberOfApartament / Level) / Entrance;
        public void Build() => status = true;

        public override string ToString() => $" Номер здания - {id},\n" +
                                             $" Высота здания - {high},\n" +
                                             $" Этажность - {Level},\n" +
                                             $" Количество квартир - {NumberOfApartament},\n" +
                                             $" Количество подъездов - {Entrance},\n" +
                                             $" Высота этажа - {highLevel},\n" +
                                             $" Количество квартир в подъезде - {numberOfApartamentsInEnrtance} ,\n" +
                                             $" Количество квартир на этаже - {numberOfApartamentsInLevel} ,\n" +
                                             $" Статус - {status},\n" +
                                             $" Описание - {description}";
    }
}

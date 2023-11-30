using System;
using System.Collections;

namespace _30._11._2023
{
    internal class Creator
    {
        private static uint id;
        private static Hashtable hashtable = new Hashtable();
        private Creator() { }
        public static IBuilding CreateBuild(uint high, uint level, uint numberOfApartament, uint entrance, BrickBuild brickBuild) // Добавляет кирпичное здание
        {
            id++;
            brickBuild = new BrickBuild(id, high, level, numberOfApartament, entrance);
            hashtable.Add(id, brickBuild);
            return brickBuild;
        }
        public static IBuilding CreateBuild(uint high, uint level, uint numberOfApartament, uint entrance, PanelBuild panelBuild) // Добавляет панельное здание
        {
            id++;
            panelBuild = new PanelBuild(id, high, level, numberOfApartament, entrance);
            hashtable.Add(id, panelBuild);
            return panelBuild;
        }
        public static void CloseBuild(uint id) // Метод удаления здания из хеш-таблицы
        {
            hashtable.Remove(id);
        }
        public static void PrintHashtable() // Метод вывода хеш-таблицы
        {
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}

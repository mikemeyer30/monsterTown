using System;

namespace MonsterTownLib
{

    /*
     * This class is immutable. Once instantiated, objects cannot be changed
     * from outside of the class.
     * It uses a constructor to initialize its properties.
     */
    public class Town
    {

        /*
         * { get; } is shorthand getter method.If attribute is public, this
         * allows any other file in the application to access this method.
         *
         * { private set; } means that only an object of this class can set the
         * value of it's own attribute (in this case, the townPopulation attr.)
         */
        // Auto-implemented properties for basic getters and setters
        public String TownName { get; }
        public int Population { get; private set; }
        public int Buildings { get; private set; }

        // Constructor
        /*
         * When passing arguments to a method, the arguments must begin with a
         * lower case letterw in C#, even if their cooresponding attributes in the
         * class are uppercase.
         */
        public Town(string townName, int population, int buildings)
        {
            TownName = townName;
            Population = population;
            Buildings = buildings;
        }

        // Other methods
        public String RetrieveTownDescription ()
        {
            // $"{this.placeholderText} is placeholder syntax 
            string townDescription = new string(
                $"{this.TownName} has a population of {this.Population} and {this.Buildings} buildings.");
            return townDescription;
        }

        // Method to change population
        public void ChangePopulation (int changeAmount)
        {
            this.Population += Population;
        }

        // Method to change buildings
        public void ChangeBuildings (int changeAmount)
        {
            this.Buildings += Buildings;
        }

        
    }
}

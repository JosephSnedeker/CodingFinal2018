using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich
{
    public enum Bread {NineGrainWheat, NineGrainHoneyOat, Italian, ItalianHerbsAndCheese, FlatBread}
    public enum Meat {Ham, Turkey, Tuna, Salami, Chicken, Pepperoni, Meatballs, RoastBeef, Steak}
    public enum Veggies {BananaPeppers, Cucumbers, GreenPeppers, JalapenoPeppers, Lettuce, Onions, Pickles, Olives, Spinach, Tomatoes, Avacado, Carrots, GreenChilies, Mushrooms, SweetPeppers}
    public enum Sauses {ChipotleSouthwestSause, Guacamole, LightMayo, Mayo, Mustard, Oil, Ranch, Caesar, SweetOnionSauce, Vinaigrette, Vinegar, BBQSause, BuffaloSause, CreamyItalian, CreamySriracha}
    class Sandwich
    {
       
        public Bread bread;
        public List<Meat> meat;
        public List<Veggies> veggies;
        public List<Sauses> sauses;

        public Sandwich(Bread bread, List<Meat> meat, List<Veggies> veggies, List<Sauses> sauses)
        
        {
            this.bread = bread;
            this.meat = meat;
            this.veggies = veggies;
            this.sauses = sauses;
            
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Sprites;
using UnityEngine;




public enum Bread { NineGrainWheat, NineGrainHoneyOat, Italian, ItalianHerbsAndCheese, FlatBread }
public enum Meat { Ham, Turkey, Tuna, ColdCutComboMeats, Chicken, SubwayClubMeats, Meatballs, RoastBeef, Steak, Bacon, Pepperoni, Salami }
public enum Veggies { BananaPeppers, Cucumbers, GreenPeppers, JalapenoPeppers, Lettuce, Onions, Pickles, Olives, Spinach, Tomatoes, Avacado, Carrots, GreenChilies, Mushrooms, SweetPeppers }
public enum Sauses { ChipotleSouthwestSause, Guacamole, LightMayo, Mayo, Mustard, Oil, Ranch, Caesar, SweetOnionSauce, Vinaigrette, Vinegar, BBQSause, BuffaloSause, CreamyItalian, CreamySriracha, Teriyaki }
[System.Serializable]
public class Sandwich
{
    public Sprite sandwichPic;  
    public Bread  bread;
    public List<Meat> meat;
    public List<Veggies> veggies; 
    public List<Sauses> sauses;
    public int calorieCount = 0;
    public float price = 0f;
    public string name = "";
    
    public Sandwich(Bread bread, List<Meat> meat, List<Veggies> veggies, List<Sauses> sauses, int calorieCount, float price, Sprite sandwichPic)

    {
        
        
        this.bread = bread;
        this.meat = meat;
        this.veggies = veggies;
        this.sauses = sauses;
        this.calorieCount = calorieCount;
        this.price = price;
        this.sandwichPic = sandwichPic;

    }
    public Sandwich() { }
    
}




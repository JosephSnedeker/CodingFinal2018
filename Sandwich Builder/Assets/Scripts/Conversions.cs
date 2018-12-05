using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Conversions
{
    public static Dictionary<Bread, int> BREAD_TO_CALORIES = new Dictionary<Bread, int>()
    {
        { Bread.NineGrainWheat, 210 }, {Bread.NineGrainHoneyOat, 230}, {Bread.ItalianHerbsAndCheese, 240}, {Bread.Italian, 200}, {Bread.FlatBread, 230}
    };
    public static Dictionary<Meat, int> MEAT_TO_CALORIES = new Dictionary<Meat, int>()
    {
        {Meat.Turkey, 50}, {Meat.Tuna, 250}, {Meat.Steak, 110}, {Meat.ColdCutComboMeats, 130}, {Meat.RoastBeef, 260}, {Meat.SubwayClubMeats, 90}, {Meat.Meatballs, 260}, {Meat.Ham, 60}, {Meat.Chicken, 80}
    };
    public static Dictionary<Veggies, int> VEGGIES_TO_CALORIES = new Dictionary<Veggies, int>()
    {
        {Veggies.Tomatoes, 5}, {Veggies.SweetPeppers, 15}, {Veggies.Spinach, 0}, {Veggies.Pickles, 0}, {Veggies.Onions, 0}, {Veggies.Olives, 0}, {Veggies.Mushrooms, 5}, {Veggies.Lettuce, 0}, {Veggies.JalapenoPeppers, 0}, {Veggies.GreenPeppers, 0}, {Veggies.GreenChilies, 0}, {Veggies.Cucumbers, 0}, {Veggies.Carrots, 5} {Veggies.BananaPeppers, 0}, {Veggies.Avacado, 60}
    };
    public static Dictionary<Sauses, int> SAUSCES_TO_CALORIES = new Dictionary<Sauses, int>()
    {
        {Sauses.Vinegar, 0}, {Sauses.Vinaigrette, 40}, {Sauses.SweetOnionSauce, 40}, {Sauses.Ranch, 110}, {Sauses.Oil, 45}, {Sauses.Mustard, 5}, {Sauses.Mayo, 110}, {Sauses.LightMayo, 50}, {Sauses.Guacamole, 70}, {Sauses.CreamySriracha, 40}, {Sauses.CreamyItalian, 80}, {Sauses.ChipotleSouthwestSause, 100}, {Sauses.Caesar, 130}, {Sauses.BuffaloSause, 35}, {Sauses.BBQSause, 35}
    };
}

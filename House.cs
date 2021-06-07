using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum Nationality { Norwegian, British, Swedish, Danish, German }
public enum HouseColor { Red, Green, White, Yellow, Blue }
public enum Cigarette { PallMall, Marlboro, DunHill, Winfield, Rothmans }
public enum Drink { Tea, Coffee, Milk, Beer, Water }
public enum Pet { Dog, Bird, Cat, Horse, Fish }

struct House
{
    public Nationality Nationality { get; set; }
    public HouseColor HouseColor { get; set; }
    public Cigarette Cigarette { get; set; }
    public Drink Drink { get; set; }
    public Pet Pet { get; set; }

    public override String ToString()
    {
        String s = String.Format("Nationality: {0}", this.Nationality);
        s += Environment.NewLine;
        s += String.Format("  Color: {0}, Pet: {1}", this.HouseColor, this.Pet);
        s += Environment.NewLine;
        s += String.Format("  Cigarette: {0}, Drink: {1}", this.Cigarette, this.Drink);
        return s;
    }
}
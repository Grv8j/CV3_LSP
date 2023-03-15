﻿namespace CV3_LSP.Models;

public class City
{
    private string Name { get; }
    private int PSC { get; set; }
    
    public City(string name, int psc)
    {
        Name = name;
        PSC = psc;
    }
}
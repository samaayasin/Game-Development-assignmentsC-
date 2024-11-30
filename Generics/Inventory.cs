using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Inventory 
{
    List <string> names = new List<string>();
    public void AddItem(string item){
        names.Add(item);
    }
    public void ShowItems(){
        foreach(string n in names){
        Debug.Log(n);
        }
    }
    public static Inventory operator +(Inventory inv1 ,Inventory inv2){
        Inventory newInv = new Inventory();
        foreach (string name in inv1.names){
            newInv.AddItem(name);
        }
        foreach (string name in inv2.names){
            newInv.AddItem(name);
        }

        return newInv;
    }
    
}

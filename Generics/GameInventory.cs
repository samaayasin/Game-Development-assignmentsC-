using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory inv =new Inventory();
        inv.AddItem("Healing Potion");
        inv.AddItem("Strength Potion");

        Inventory inv2 =new Inventory();
        inv2.AddItem("Elixir");
        inv2.AddItem("Dark Elixir");
        Inventory inv3 =new Inventory();
        inv3 = inv +inv2;
        inv3.ShowItems();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

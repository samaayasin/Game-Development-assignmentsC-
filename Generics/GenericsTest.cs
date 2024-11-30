using System.Collections;
using System.Collections.Generic;
using ass18;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> game=new GameContainer<string>();
        game.SetItem("Healing Potion");
        Debug.Log("Stored item: "+ game.GetItem() + "\n");
        GameUtils.DescribeItem(game.GetItem());

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

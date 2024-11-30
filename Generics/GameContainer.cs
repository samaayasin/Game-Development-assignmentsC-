using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace ass18{
public class GameContainer <T> {
    private T item ;
   public void SetItem(T item){
     this.item=item;
   }
    public T GetItem(){
        return item;

   }

    
}

public class GameUtils{
    public static void DescribeItem <T> (T item){
    Debug.Log("This item is a: " + item);

    }

    
}
}
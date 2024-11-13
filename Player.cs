using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player  
{
    public int health ;
    public string playerName ;
    private static int playerCount ;

    public void InitializePlayer(string name, int initialHealth){
      this. playerName = name;
      this. health = initialHealth;
        playerCount ++;
    }

   public void  Heal(int amount){
        health += amount;
        Debug.Log("New Health amount is :" + health);
    }

    public void Heal(bool fullRestore){
        if  (fullRestore){
            health = 200 ;
            Debug.Log("Health fully restored to: " + health);
        }
    }

    public static void ShowPlayerCount(){
        Debug.Log("The Player Count is : " + playerCount);
    }

}


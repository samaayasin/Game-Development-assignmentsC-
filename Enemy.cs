using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class Enemy : Character
{
   public Enemy (string name ,int health) : base (name, health){
   }
   public void Attack(Character targetPlayer,int amount){
    int CurrentHealth = targetPlayer.getHealth();
    int NewHealth = CurrentHealth - amount ;
    targetPlayer.setHealth(NewHealth);
   }
}

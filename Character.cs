using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
   private string Name;
   private int Health;
   public Character(string name , int Health){
    this.Name = name;
    this.Health = Health;
   }
   public string getName(){
    return this.Name;
   }
   public void setName(string name){
    this.Name = name;
   }
    public int getHealth(){
    return this.Health;
   }
   public void setHealth(int health){
    this.Health = Mathf.Min(health, 100);
   }
   

}

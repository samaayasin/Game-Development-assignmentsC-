using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    

public class CharacterTest : MonoBehaviour
{
    void Start(){
    Character soldier = new Soldier(); 
    Character officer = new Officer("Samaa", 90, new Position(80, 50, 200));
    Character[] characters = new Character[] { soldier, officer };
     foreach (Character character in characters)
            {
                character.DisplayInfo(); 
            }

         Debug.Log("Before Attack:");
            soldier.DisplayInfo();  
            officer.Attack(20, soldier);
            Debug.Log("After Attack:");
            soldier.DisplayInfo(); 
    } 
}
}
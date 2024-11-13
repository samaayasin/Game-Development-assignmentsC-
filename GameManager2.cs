using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    void Start()
    {
        Player2 player = new Player2("Samaa", 90);
        Enemy enemy = new Enemy("Aisha", 100);
        Debug.Log("Player Name : "+ player.getName()+ "\nPlayer Health : " +player.getHealth()+"\n");
        Debug.Log("Enemy Name : "+ enemy.getName()+ "\nEnemy Health : " +enemy.getHealth()+"\n");
        player.Heal(20);
        Debug.Log("Player Health after Heal : "+ player.getHealth()+"\n");
        enemy.Attack(player,50);
        Debug.Log("Player Health after Attack : "+ player.getHealth()+"\n");

    }

    
}

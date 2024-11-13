using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();
        player1.InitializePlayer("Mohammad",90);
        player2.InitializePlayer("Ahmad",80);
        player1.Heal(10);
        player1.Heal(true);
        player1.Heal(30);
        player1.Heal(true);
        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

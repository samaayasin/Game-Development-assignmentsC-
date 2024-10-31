using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     string [] Words={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
     int count =7;
     int randomInt;
     string sentence="";
     while(count > 0){
        randomInt=Random.Range(0,10);
        sentence +=Words[randomInt] +" ";
        count--;
     }
     Debug.Log(sentence);

    }



   
}

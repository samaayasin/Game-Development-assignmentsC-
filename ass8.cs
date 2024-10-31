using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ass8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomNum;
        while(true){
        randomNum=Random.Range(1,21);
        if(randomNum == 5){
            continue;
        }
        if(randomNum == 15){
            break;
        }
        Debug.Log(randomNum +"\n");
        
        }
        
    }
}

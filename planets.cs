using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planets :MonoBehaviour
{
    public Transform centerObj ;
    public float rotationSpeed =9f;
    public float selfRotationSpeed =9f;

    private Vector3 orbitaxis=Vector3.up;
    private void RotateAroundCentralObject(){
    transform.RotateAround(centerObj.position, orbitaxis, rotationSpeed* Time.deltaTime);
    }
    private void RotateAroundSelf()
    {
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime);
    }
    void Update()
    {
        RotateAroundCentralObject();
        RotateAroundSelf();
    }


}

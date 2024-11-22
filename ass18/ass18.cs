using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
namespace Assignment18
{
    public struct Position {
       public float X,Y,Z;
    public Position(float X, float Y, float Z){
        this.X=X;
        this.Y=Y;
        this.Z=Z;
    }
    public void printPosition(){
        Debug.Log("X: "+ X +" Y: "+ Y +"Z : "+ Z +"\n");
    }

    }

    public class Character{
    public string name;
    private int health; 
    protected Position position;
    public int Health{
    set{ health=Mathf.Clamp(value,0,100);}
    get{return health;}
    }
    public Character (string name,int Health, Position position){
        this.name=name;
        this.Health=Health;
        this.position=position;
    }
    public Character (): this("No name", 100, new Position(0,0,0)){}

    public virtual void DisplayInfo(){

        Debug.Log("Name: "+ name +"Health: "+ Health);
        position.printPosition();
    }


    public void Attack(int damage, Character target)
        {
            afterDamage(damage, target); 
        }

        public void Attack(int damage, Character target, string attackType)
        {
            Debug.Log("Attack Type : "+attackType);
            afterDamage(damage, target); 
        }

        private void afterDamage(int damage, Character target)
        {
            target.Health -= damage; 
            Debug.Log("Remaining health: " + target.Health);
        }

}


public class Soldier : Character{
public Soldier(){}
public Soldier(string name, int health, Position position):base(name, health, position){
}
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
public class Officer : Character{
    public Officer(string name, int health, Position position):base(name, health, position){}
     public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
}

    
}



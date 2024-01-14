using UnityEngine;

public class Cube : MonoBehaviour, IClone {

    public float speed;
    public int health;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public IClone Clone(){
        
        // Create a new instance and copy the values
        var clonedEnemy = Instantiate( this );
        clonedEnemy.speed = this.speed;
        clonedEnemy.health = this.health;

        return clonedEnemy;
        
    }

}
using UnityEngine;

public class Manager : MonoBehaviour {
    
    public int x = 1;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    [SerializeField]
    private Vector3 pos = Vector3Int.zero;
    
    private Cube _clone;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void Start() => _clone = FindObjectOfType<Cube>();

    private void Update(){
        
        if ( !Input.GetKeyDown( KeyCode.Space ) ) return;
        
        var c = _clone.Clone() as Cube;

        pos.x = ( x * 1.5f );
        c.transform.position = pos;

        c.speed = x;
        c.health = x + 1;

        x++;

    }

}
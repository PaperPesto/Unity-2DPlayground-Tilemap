using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virtualPosition : MonoBehaviour
{
    public int virtual_x { get; set; }
    public int virtual_y { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Up()
    {
        Debug.Log("Up");

        var oldx = transform.position.x;
        var oldy = transform.position.y;

        transform.position = new Vector2(oldx, oldy + 1);
    }

    public void Down()
    {
        Debug.Log("Down");

        var oldx = transform.position.x;
        var oldy = transform.position.y;

        transform.position = new Vector2(oldx, oldy - 1);
    }

    public void Right()
    {
        Debug.Log("Right");

        var oldx = transform.position.x;
        var oldy = transform.position.y;

        transform.position = new Vector2(oldx + 1, oldy);
    }

    public void Left()
    {
        Debug.Log("Left");

        var oldx = transform.position.x;
        var oldy = transform.position.y;

        transform.position = new Vector2(oldx - 1, oldy);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(virtual_x, virtual_y);
    }
}

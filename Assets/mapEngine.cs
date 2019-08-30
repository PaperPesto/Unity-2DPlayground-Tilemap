using UnityEngine;
using UnityEngine.Tilemaps;

public class mapEngine : MonoBehaviour
{
    public TileBase GreenTile;
    public TileBase BrownTile;

    public Tilemap TargetTileMap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            var mouse = Input.mousePosition;

            Debug.Log(mouse);

            int x = Mathf.FloorToInt(mouse.x/24);
            int y = Mathf.FloorToInt(mouse.y/10);
            int z = Mathf.FloorToInt(mouse.z);

            var nuovo = new Vector3Int(-3, -3, z);
            Debug.Log("n" + nuovo);

            TargetTileMap.SetTile(nuovo, GreenTile);
        }
    }
}

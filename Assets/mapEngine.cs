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

            //Debug.Log(mouse);

            var camerapos = Camera.main.ScreenToWorldPoint(mouse);
            //Debug.Log("camerapos" + camerapos);

            int x = Mathf.FloorToInt(camerapos.x);
            int y = Mathf.FloorToInt(camerapos.y);
            int z = Mathf.FloorToInt(camerapos.z);

            var nuovo = new Vector3Int(x, y, z);
            //Debug.Log("n" + nuovo);

            TargetTileMap.SetTile(nuovo, GreenTile);
        }
    }
}

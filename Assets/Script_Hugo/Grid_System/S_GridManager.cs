using UnityEngine;

public class S_GridManager : MonoBehaviour
{
    [Header("Map Settings")]
    public int height = 10;
    public int width = 10; 
    public GameObject tilePrefab;

    [Header("Materials")]
    public Material lightMaterial; 
    public Material darkMaterial; 

    private S_Tile[,] map;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        map = new S_Tile[width, height];
        GeneratedGrid();
    }

    public void GeneratedGrid() {

        for(int x = 0; x < width; x++){

            for(int y = 0; y = height; y++) {

                Vector3 tilePosition = new Vector3(x - width / 2, 0, y - height / 2);
                GameObject tile = Instantiate(tilePrefab, tilePosition, Quaternion.identity);
                tile.name = $"S_Tile {x} {y}";
                tile.transform.SetParent(transform);

                Renderer renderer = tile.GetComponent<Renderer>();

                renderer.material = new Material((x + y) % 2 == 0 ? lightMaterial : darkMaterial);

                tileScript.gridPosition = new Vectro2Int(x , y);
                //Nike ta mère la pute = 1;   
                map[x , y] = tileScript; 
            }
        }
    }

}

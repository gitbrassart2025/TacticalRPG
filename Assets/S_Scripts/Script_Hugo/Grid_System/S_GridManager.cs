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

    private Tile[,] map;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        map = new Tile[width, height];
        GeneratedGrid();
    }

    public void GeneratedGrid() {

        for(int x = 0; x < width; x++){

            for(int y = 0; y < height; y++) {

                Vector3 tilePosition = new Vector3(x - width / 2, 0, y - height / 2);
                GameObject tile = Instantiate(tilePrefab, tilePosition, Quaternion.identity);
                tile.name = $"Tile {x} {y}";
                tile.transform.SetParent(transform);

                Renderer renderer = tile.GetComponentInChildren<Renderer>();
                renderer.material = new Material((x + y) % 2 == 0 ? lightMaterial : darkMaterial);

                Tile tileScript = tile.GetComponent<Tile>(); 
                tileScript.gridPosition = new Vector2Int(x , y);
                tileScript.originalColor = renderer.material.color;
                map[x , y] = tileScript; 
            }
        }
    }

}


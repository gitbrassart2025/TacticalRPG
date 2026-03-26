using UnityEngine;
using UnityEngine.EventSystems;
public class Tile : MonoBehaviour, IPointerExitHandler, IPointerDownHandler
{
    public Vector2Int gridPosition; 
    [Header("Colors")]
    public Color originalColor;
    public Color highlightColor = Color.yellow;
    public Color selectedColor  = Color.blue;

    private Renderer tileRenderer; 
    private static Tile selectedTile;


    private void Start()
    {
        tileRenderer = GetComponentInChildren<Renderer>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                string parentName = hit.collider.transform.parent.name;
                Debug.Log("Case cliquée : " + parentName);
            }
        }
    }
    public void ChangeColor(Color newColor)
    {
        tileRenderer.material.color = newColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(selectedTile != this)
        {
            ChangeColor(originalColor);
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if(selectedTile)
        {
            selectedTile.ChangeColor(selectedTile.originalColor);
        }
        selectedTile = this;
        ChangeColor(selectedColor);
    }
}

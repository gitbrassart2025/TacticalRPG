using UnityEngine;

public class S_PlaceSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject mouseIndicator;
    [SerializeField]
    private S_InputManager inputManager;

    public void Update() {

        Vector3 mousePosition = inputManager.GetSelectedMapPosition();
        mouseIndicator.transform.position = mousePosition; 

    }

}

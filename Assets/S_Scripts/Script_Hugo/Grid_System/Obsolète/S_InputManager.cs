using UnityEngine;

public class S_InputManager : MonoBehaviour
{
    [SerializeField]
    private Camera sceneCamera;
    private Vector3 lastPosition; 

    [SerializeField]
    private LayerMask placementLayermask;

    public Vector3 GetSelectedMapPosition() {

        Vector3 mousePos = Input.mousePosition;
        Ray ray = sceneCamera.ScreenPointToRay(mousePos);
        RaycastHit hit;
        
        if(Physics.Raycast(ray, out hit, 100, placementLayermask)) {
            lastPosition = hit.point;
        }
        return lastPosition; 

    }  
}

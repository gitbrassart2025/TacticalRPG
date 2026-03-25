/*using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    public Camera mainCamera;
    public UIAttackMenu attackMenu;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                PlayerUnit unit = hit.collider.GetComponent<PlayerUnit>();

                if (unit != null)
                {
                    attackMenu.ShowMenu(unit);
                }
            }
        }
    }
}*/
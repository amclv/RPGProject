using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveToCursor();
        }
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        bool hasHit = Physics.Raycast(ray, out hitInfo);

        if (hasHit)
        {
            GetComponent<Mover>().MoveTo(hitInfo.point);
        }
    }
}
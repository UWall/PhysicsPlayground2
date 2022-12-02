using UnityEngine;

public class ObjectSnap : MonoBehaviour
{
    private GameObject hitCell;
    private Vector3 MousePos()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(mouseRay, out RaycastHit raycastHit) == true)
        {
            hitCell = raycastHit.transform.gameObject;
            return raycastHit.transform.gameObject.transform.position;
        }
        else
        {
            return Vector3.zero;
        }
    }

    private bool hasBeenPlaced = false;

    private void Update()
    {
        Snap();
    }

    private void Snap()
    {
        if(MousePos() != Vector3.zero && hasBeenPlaced == false)
        {
            if(hitCell.tag == gameObject.tag)
            {
                transform.position = hitCell.transform.position;
            }
        }
    }
}

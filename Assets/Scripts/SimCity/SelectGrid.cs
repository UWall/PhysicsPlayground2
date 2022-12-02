using UnityEngine;

public class SelectGrid : MonoBehaviour
{
    [SerializeField] private string[] tags;
    private GameObject currentObject;
    private int selectedTag = 1;

    private GameObject GridCell()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(mouseRay, out RaycastHit raycastHit) == true)
        {
            return raycastHit.transform.gameObject;
        }
        else
        {
            return null;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedTag = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedTag = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedTag = 3;
        }
    }

    private void OnMouseDown()
    {
        if (GridCell() != null)
        {
            GridCell().tag = tags[selectedTag];
            if (selectedTag == 1)
            {
                GridCell().GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
            else if (selectedTag == 2)
            {
                GridCell().GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
            }
            else if (selectedTag == 3)
            {
                GridCell().GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            }
        }
    }

    private void OnMouseDrag()
    {
        if (GridCell() != null)
        {
            if (GridCell().tag == "GridCell")
            {
                GridCell().tag = tags[selectedTag];
                if (selectedTag == 1)
                {
                    GridCell().GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                }
                else if (selectedTag == 2)
                {
                    GridCell().GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
                }
                else if (selectedTag == 3)
                {
                    GridCell().GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                }
            }
        }
    }
}

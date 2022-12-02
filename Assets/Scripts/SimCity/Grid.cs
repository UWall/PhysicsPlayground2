using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField]private float sizeX, sizeZ;
    [SerializeField]private Vector3 gridHead;
    [SerializeField]private GameObject grid, gridCell;
    
    private void Start()
    {
        InitGrid();
    }

    private void InitGrid()
    {
        Vector3 pos = gridHead;
        for (int i = 0; i < sizeZ; i++, pos.z--)
        {
            pos.x = gridHead.x;
            for (int j = 0; j < sizeX; j++, pos.x++)
            {
                GameObject currentCell = Instantiate(gridCell, pos, transform.rotation);
                currentCell.transform.SetParent(grid.transform);
            }
        }
    }

    public void GridToggle(bool toggle)
    {
        grid.SetActive(toggle);
    }
}

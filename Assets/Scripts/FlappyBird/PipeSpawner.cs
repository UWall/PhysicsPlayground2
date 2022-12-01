using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]private GameObject pipeUp, pipeDown, middleSection, scene;
    [SerializeField]private float[] spawnHeights;
    [SerializeField]private float spawnTime;

    private void Start()
    {
        InvokeRepeating("SummonObstacle", 0.0f, spawnTime);
    }

    private void SummonObstacle()
    {
        int aux = Random.Range(0, spawnHeights.Length);
        float currentHeight = spawnHeights[aux];
        Vector3 middlePos = new Vector3(10.25f, currentHeight, 0);
        Vector3 spaceBetweenPipes = new Vector3(0, 8, 0);

        Instantiate(middleSection, middlePos, middleSection.transform.rotation, scene.transform);
        Instantiate(pipeUp, middlePos + (spaceBetweenPipes * -1), pipeUp.transform.rotation, scene.transform);
        Instantiate(pipeDown, middlePos + spaceBetweenPipes, pipeDown.transform.rotation, scene.transform);
    }
}

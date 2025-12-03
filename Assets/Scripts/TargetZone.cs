using UnityEngine;

public class TargetZone : MonoBehaviour
{
    [SerializeField] GameObject TargetPrefab;

    private void Start()
    {
        SpawnTarget();
        SpawnTarget();
        SpawnTarget();

    }

    public void SpawnTarget()
    {
        GameObject clonedTarget = Instantiate(TargetPrefab);
        clonedTarget.transform.position = new Vector3(Random.Range(-40f, 40f), 0.1f, Random.Range(80f,125f));
    }
}

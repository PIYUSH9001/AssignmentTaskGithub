using UnityEngine;
using UnityEngine.UI;

public class ItemCollecterZone : MonoBehaviour
{
    [SerializeField] GameObject[] Items;
    private void Start()
    {
        for(int i = 0;i< 10;i++)
        {
            SpawnItem();
        }
    }

    private void SpawnItem()
    {
        int randomItemIndex = Random.Range(0, Items.Length);
        GameObject RandomItem = Instantiate(Items[randomItemIndex]);
        RandomItem.transform.localPosition = new Vector3(Random.Range(-50f, 50f ), 1f,
            Random.Range(-25f, 25f));
    }
}

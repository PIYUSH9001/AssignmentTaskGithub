using UnityEngine;
using UnityEngine.UI;

public class ThrowZone : MonoBehaviour
{
    [SerializeField] Button ThrowBtn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ThrowBtn.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ThrowBtn.gameObject.SetActive(false);
        }
    }
}

using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item"))
        {
            Score.ScoreValue++;
            Destroy(gameObject);
        }
    }
}

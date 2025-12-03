using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreUI;
    public static int ScoreValue = 0;

    private void Update()
    {
        ScoreUI.text = ScoreValue.ToString();
    }
}

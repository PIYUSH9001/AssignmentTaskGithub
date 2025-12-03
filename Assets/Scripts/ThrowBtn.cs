using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThrowBtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Slider ForceStrengthSlider;
    public static float forceStrength = 1.0f;
    private bool isHoldingButton;
    float maxStrengthLimit = 5f;
    public void OnPointerDown(PointerEventData eventData)
    {
        if(PlayerItemDetection.isHoldingItem)
        {
            ForceStrengthSlider.gameObject.SetActive(true);
            isHoldingButton = true;
            StartCoroutine(IncreaseStrength(0.25f));
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        StopAllCoroutines();
        ForceStrengthSlider.value = 1f;
        ForceStrengthSlider.gameObject.SetActive(false);
        isHoldingButton = false;
        Invoke("ResetForceStrength", 0.1f);
    }

    private void ResetForceStrength()
    {
        forceStrength = 1f;
    }

    IEnumerator IncreaseStrength(float delay)
    {
        while(forceStrength < maxStrengthLimit || isHoldingButton)
        {
            forceStrength += 1f;
            ForceStrengthSlider.value += 1f;
            yield return new WaitForSeconds(delay);
        }

    }
}

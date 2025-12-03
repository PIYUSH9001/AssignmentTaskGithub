using StarterAssets;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchCamera : MonoBehaviour,IDragHandler
{
    [SerializeField] GameObject PlayerArmature;
    private StarterAssetsInputs starterAssetsInputs;
    private bool isDragging = false;
    public float sensitivity = 1f;
    private void Start()
    {
        starterAssetsInputs = PlayerArmature.GetComponent<StarterAssetsInputs>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(eventData.dragging)
        {
            float xDragValue = eventData.delta.x;
            float yDragValue = eventData.delta.y;
            starterAssetsInputs.look.x = xDragValue * sensitivity * Time.deltaTime;
            starterAssetsInputs.look.y = -(yDragValue * sensitivity * Time.deltaTime);
        }
    }
}

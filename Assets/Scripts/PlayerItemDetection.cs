using UnityEngine;
using UnityEngine.UI;

public class PlayerItemDetection : MonoBehaviour
{
    [SerializeField] GameObject ItemDetailsPanel;
    [SerializeField] Button ItemBtnPrefab;
    [SerializeField] Transform ItemPickupPoint;
    Button ClonedItemBtn;
    public static bool isHoldingItem = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item") && !isHoldingItem)
        {
            ItemDetailsPanel.SetActive(true);
            ClonedItemBtn = Instantiate(ItemBtnPrefab,ItemDetailsPanel.transform);
            Item clonedItemScript = other.GetComponent<Item>();
            ClonedItemBtn.gameObject.GetComponent<ItemBtn>().SetButton(clonedItemScript.ItemSprite,
            clonedItemScript.ItemName);
            ClonedItemBtn.onClick.AddListener(() => PickUpItem(other.transform));
            // show item details logic
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Item") && !isHoldingItem)
        {
            CloseItemDetailsPanel();
        }
    }

    private void CloseItemDetailsPanel()
    {
        if(ItemDetailsPanel.transform.childCount >= 1)
        {
            Destroy(ClonedItemBtn.gameObject);
            ItemDetailsPanel.SetActive(false);
        }
    }

    public void PickUpItem(Transform Item)
    {
        CloseItemDetailsPanel();
        GameObject clonedItem = Instantiate(Item.gameObject, ItemPickupPoint.transform);
        clonedItem.transform.localPosition = Vector3.zero;
        clonedItem.GetComponent<Rigidbody>().useGravity = false;
        clonedItem.GetComponent<Rigidbody>().isKinematic = true;
        clonedItem.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);
        ThrowItem.HoldingItem = clonedItem;
        Destroy(Item.gameObject);
        isHoldingItem = true;
    }
}

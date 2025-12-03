using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemBtn : MonoBehaviour
{
    TextMeshProUGUI ItemHeading;
    Image ItemImage;
    public void SetButton(Sprite ItemSprite,string ItemName)
    {
        ItemImage = transform.Find("ItemImage").GetComponent<Image>();
        ItemHeading = transform.Find("ItemHeading").GetComponent<TextMeshProUGUI>();
        ItemImage.sprite = ItemSprite;
        ItemHeading.text = ItemName;
    }
}

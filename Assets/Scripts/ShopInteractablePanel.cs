using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInteractablePanel : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private Text descriptionText;
    [SerializeField] private Text costText;
    [SerializeField] private Image itemImage;

    public void SetInfo(StoreItem item)
    {
        nameText.text = item.Name;
        descriptionText.text = item.Description;
        costText.text = item.cost.ToString();
        itemImage.sprite = item.Sprite;
    }
}

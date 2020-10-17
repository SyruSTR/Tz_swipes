using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    [SerializeField] StoreItem selectedItem;
    [SerializeField] GameObject interectablePanel;
    [SerializeField] Transform shadowPanel;

    public void _SelectItem(StoreItem item)
    {
        selectedItem = item;
        shadowPanel.gameObject.SetActive(true);
        interectablePanel.GetComponent<ShopInteractablePanel>().SetInfo(selectedItem);
        interectablePanel.GetComponent<MovePanel>().Move();
    }


}

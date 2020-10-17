using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddDataOnItem : MonoBehaviour
{
    private StoreItem item;
    [SerializeField] private Text nameTextBoard;    
    [SerializeField] private Text costTextBoard;
    [SerializeField] private Image spriteBoard;
    

    public void SetInfoOnInteractablePanel()
    {
        transform.GetComponentInParent<SelectItem>()._SelectItem(item);
    }
    public void AddInfo(StoreItem item)
    {
        this.item = item;
        SetInfo();
    }

    private void SetInfo()
    {
        nameTextBoard.text = item.Name;
        costTextBoard.text = item.cost.ToString();
        spriteBoard.sprite = item.Sprite;
    }

}

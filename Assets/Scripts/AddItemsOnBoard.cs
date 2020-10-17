using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItemsOnBoard : MonoBehaviour
{
    [SerializeField] private GameObject shopItemPrefab;
    [SerializeField] StoreItem[] items;
    // Start is called before the first frame update
    void Start()
    {
        if (items.Length < 4)
        {
            transform.parent.GetComponentInParent<ScrollRect>().vertical = false;
            transform.parent.parent.GetComponentInChildren<Scrollbar>().gameObject.SetActive(false);
        }
        else
        {
            transform.parent.GetComponentInParent<ScrollRect>().vertical = true;
            transform.parent.parent.GetComponentInChildren<Scrollbar>().gameObject.SetActive(true);
        }
        for (int i = 0; i < items.Length; i++)
        {

            var item = Instantiate(shopItemPrefab, transform).GetComponent<AddDataOnItem>();

            item.AddInfo(items[i]);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNewTab : MonoBehaviour
{
    [SerializeField] Transform panel;
    [SerializeField] Transform itemsPanel;
    public void _SetTab()
    {
        panel.SetAsLastSibling();
        transform.SetAsLastSibling();
        itemsPanel.SetAsLastSibling();
    }
}

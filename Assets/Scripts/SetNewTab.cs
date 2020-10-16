using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNewTab : MonoBehaviour
{
    [SerializeField] Transform panel;
    public void _SetTab()
    {
        panel.SetSiblingIndex(transform.parent.childCount - 1);
        transform.SetSiblingIndex(transform.parent.childCount - 1);
    }
}

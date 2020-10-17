using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Shop item", menuName = "Shop item", order = 51)]
public class StoreItem : ScriptableObject
{
    public string Name;
    [TextArea]
    public string Description;
    public int cost;
    public Sprite Sprite;
}

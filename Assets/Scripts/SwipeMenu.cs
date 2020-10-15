using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SwipeMenu : MonoBehaviour
{
    [SerializeField] private Scrollbar scrollbar;
    private float scroll_pos = 0f;
    private float[] pos;
    private float distance = 0f;

    public ChangePanel changePanel;

    //public int CurrentPanel { get; private set; }
    private int currentPanel = 0;
    public int ChildCount { get { return transform.childCount; } }
    private void Awake()
    {
        scroll_pos = 0.5f;
        scrollbar.value = 0.5f;
    }
    // Start is called before the first frame update
    void Start()
    {

        pos = new float[transform.childCount];
        distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }

        changePanel.Invoke(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.value * ChildCount;

            if (scroll_pos > transform.childCount)
            {
                currentPanel = transform.childCount - 1;
            }
            else if (scroll_pos < 0)
                currentPanel = 0;
            else
                currentPanel = Mathf.FloorToInt(scroll_pos);
            changePanel.Invoke(currentPanel);
        }
        //Lerp Move panels
        else
        {
            scrollbar.value = Mathf.Lerp(scrollbar.value, pos[currentPanel], 0.1f);
        }
    }
    public void NextPanel()
    {
        if (currentPanel < transform.childCount - 1)
        {
            currentPanel++;
            changePanel.Invoke(currentPanel);
        }
    }
    public void LastPanel()
    {
        if (currentPanel > 0)
        {
            currentPanel--;
            changePanel.Invoke(currentPanel);
        }
    }
    [System.Serializable]
    public class ChangePanel : UnityEvent<int> { }
}

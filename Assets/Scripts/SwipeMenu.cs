using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeMenu : MonoBehaviour
{
    [SerializeField] Scrollbar scrollbar;
    float scroll_pos = 0f;
    float[] pos;
    int current_panel = 0;
    float distance = 0f;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.value;
        }
        //Lerp Move panels
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if(scroll_pos < pos[i] + (distance /2) && scroll_pos > pos[i] - (distance / 2))
                {
                    scrollbar.value = Mathf.Lerp(scrollbar.value, pos[i], 0.1f);
                }
            }
        }

        //Lerp Change scale
        //for (int i = 0; i < pos.Length; i++)
        //{
        //    if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
        //    {
        //        transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1f, 1f), 0.1f);
        //    }
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTips : MonoBehaviour
{
    [SerializeField] GameObject tipPrefab;
    [SerializeField] private SwipeMenu swipeMenu;
    private Image[] tipsImages;

    // Start is called before the first frame update
    void Start()
    {
        if (swipeMenu != null)
        {
            tipsImages = new Image[swipeMenu.ChildCount];
            for (int i = 0; i < tipsImages.Length; i++)
            {
                tipsImages[i] = Instantiate(tipPrefab, transform).GetComponent<Image>();
            }
        }
    }

    public void ChangeStatus(int activePanelNumber)
    {
        for (int i = 0; i < tipsImages.Length; i++)
        {
            if (activePanelNumber == i)
            {
                tipsImages[i].color = Color.white;
            }
            else
                tipsImages[i].color = Color.gray;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

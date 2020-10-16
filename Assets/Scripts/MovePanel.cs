using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanel : MonoBehaviour
{
    [SerializeField] private float closeY = 0f;
    [SerializeField] private float showY = 0f;

    [SerializeField] private bool active = false;

    public float moveSpeed = 10f;

    public void Move()
    {
        if (active)
        {
            active = false;
        }
        else
        {
            active = true;
        }
    }
    void Start()
    {
        showY = Screen.height / 2;
        closeY = -Screen.height / 2 - 50;
        transform.position = new Vector3(transform.position.x, closeY, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.gameObject.activeInHierarchy)
            if (transform.position.y <= showY && transform.position.y >= closeY)
            {
                float targetPos = Mathf.Clamp(transform.position.y, closeY, showY);

                transform.position = new Vector3(
                    transform.position.x,
                    Mathf.Lerp(targetPos, active ? showY : closeY, moveSpeed * Time.deltaTime),
                    transform.position.z);
            }
    }
}

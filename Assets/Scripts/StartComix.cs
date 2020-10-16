using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartComix : MonoBehaviour
{
    
    private void OnEnable()
    {
        StartCoroutine(StopAnimation());
        
    }    

    IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).length);
        gameObject.SetActive(false);
    }    
}

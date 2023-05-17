using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{        
    public bool active = false;

    private void OnMouseDown()
    {
        active = true;
        GetComponent<Animator>().SetBool("IsClicked", true);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(3);
        GetComponent<Animator>().SetBool("IsClicked", false);
    }
}

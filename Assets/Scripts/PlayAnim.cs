using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<Animator>().SetBool("IsClicked", true);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(3);
        GetComponent<Animator>().SetBool("IsClicked", false);
    }
}

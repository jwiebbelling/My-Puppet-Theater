using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMouth : MonoBehaviour
{
    public PlayAnim PlayAnim;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        PlayAnim = FindObjectOfType<PlayAnim>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayAnim)
        {
            GetComponent<Animator>().SetBool("Robijn", true);
            StartCoroutine(Example());
        }

        IEnumerator Example()
        {
            yield return new WaitForSeconds(3);
            GetComponent<Animator>().SetBool("Robijn", false);
        }
    }
    }
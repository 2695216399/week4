using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;
    public Renderer rend;
    int Rend;
    // Start is called before the first frame update
    void Start()
    {
       Rend = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.gameObject.name+":" + ++i);

        if (gameObject.tag == "Red" && i==100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == Rend)
        {
            rend.enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.gameObject.name);
        Debug.Log(i++);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

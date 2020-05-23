using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomElectron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>().SetInteger("Electron",Random.Range(1,8));
        this.GetComponent<Animator>().speed = 2f;
    }

 
}

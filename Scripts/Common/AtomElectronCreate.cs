using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomElectronCreate : MonoBehaviour
{
    public GameObject electron;
    // Start is called before the first frame update
    
    void OnMouseDown()
    {
        Create();
    }

    void Create(){
        GameObject elctrn = Instantiate(electron,electron.transform.position,Quaternion.identity);
        
    }
}

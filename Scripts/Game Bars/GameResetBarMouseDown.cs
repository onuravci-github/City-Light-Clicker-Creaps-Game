using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResetBarMouseDown : MonoBehaviour
{
    public int mousedownfunction;
    private static Animator gameresetbaranim;
    // Start is called before the first frame update
    void Start()
    {
        gameresetbaranim = GameObject.FindGameObjectWithTag("Game Reset Bar").GetComponent<Animator>();
        if (gameresetbaranim == null){
            gameresetbaranim = GameObject.FindGameObjectWithTag("Game Reset Bar").GetComponent<Animator>();
            gameresetbaranim.SetInteger("GameResetBar",0);
            gameresetbaranim.SetInteger("Destroy",0);
        }
    }

    void OnMouseDown()
    {
        // is Animator Find ? 
        if (gameresetbaranim == null){
            gameresetbaranim = GameObject.FindGameObjectWithTag("Game Reset Bar").GetComponent<Animator>();
        }

        if (mousedownfunction == 0){
            // Soul Value + Button Down
            gameresetbaranim.SetInteger("GameResetBar",1);
        }
        else if (mousedownfunction == 1){
            // No Button Down
            gameresetbaranim.SetInteger("GameResetBar",0);
        }
        else if (mousedownfunction == 2){
            // Yes Reset Button
        }
        else if (mousedownfunction == 3){
            gameresetbaranim.SetInteger("Destroy",1);
        }

    }
}

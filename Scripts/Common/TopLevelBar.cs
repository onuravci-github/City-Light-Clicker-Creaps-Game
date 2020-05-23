using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopLevelBar : MonoBehaviour
{
    public static Animator anim1;
    public static Animator anim2;
    public LevelBarText [] levelBarText;

    private int level;
    private float time;
    private bool control = false;
    public int function ;
    void Awake()
      {
          QualitySettings.vSyncCount = 0;
          Application.targetFrameRate = 25;
      }
    // Start is called before the first frame update
    void Start()
    {
        
            anim1 = GameObject.FindGameObjectWithTag("Top Level Bar Text").GetComponent<Animator>();
            anim2 = GameObject.FindGameObjectWithTag("Top Level Bar").GetComponent<Animator>();
    }

    void TopAnimTextZero1(){
        anim1.SetInteger("Next Level",0);
        level = PlayerSettings.getLevelMap(0);
        levelBarText[0].NextLevelUpdate(level);
        levelBarText[1].NextLevelUpdate(level);
        levelBarText[2].NextLevelUpdate(level);
        levelBarText[3].NextLevelUpdate(level);
        levelBarText[4].NextLevelUpdate(level);
    }

    void TopAnimTextZero2(){
        anim2.SetInteger("Next Level",0);
    }
    
    public static void TopAnimTextNext(){
        anim1.SetInteger("Next Level",1);
        anim2.SetInteger("Next Level",1);
    }

    private void Update() { // Bug Fixed (much level up with anim stop problem)
        if(function == 1){
            if(anim1.GetInteger("Next Level") == 1 && control == false){
                time = Time.time;
                control = true;
            }
            if(Time.time - time >= 1f ){
                anim2.SetInteger("Next Level",0);
                anim1.SetInteger("Next Level",0);
            }

            if (anim1.GetInteger("Next Level") == 0)
            {
                control = false;
            }
        }
    }
}

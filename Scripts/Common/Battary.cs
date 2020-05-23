using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battary : MonoBehaviour
{
    private int level;
    private int isLevelUp;
    private int isTenLevelUp;
    private int activeMap = 0;
    private int tempint1;
    private int tempint2;
    private int tempint3;
    private int tempint4;


    private int control1;
    private int control2;

    private float battaryRate;
    private float levelFloat;
    private float tempFloat;
    private float tempFloat2;
    private float tempFloat3;
    private float tempFloat4;


    public static float [] nowBattaryValue = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    public float [] battary = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    public static MapObjectCreaterControl mapObjectCreater;
    // Start is called before the first frame update
    void Start()
    {
        level = PlayerSettings.getLevelMap(activeMap);
        levelFloat = level;
        tempint1 = 0;
        tempint2 = 1;
        mapObjectCreater = GameObject.FindObjectOfType<MapObjectCreaterControl>();
        BattaryLevelValue();
    }

    // Update is called once per frame
    void Update()
    {
        control1 = 0;
        control2 = 0;

        for (int i = 29; i >= 0; i--)
        {
            if(nowBattaryValue[i] > 0f && control1 == 0){tempint4 = i; control1 = 1;}
            if(battary[i] > 0f && control2 == 0) {tempint3 = i; control2 = 1;}
            
        }

        for (int i = 0; i < 30; i++){
            tempFloat4 = Mathf.FloorToInt(nowBattaryValue[i]/1000);
            if (tempFloat4 >=1f){
                nowBattaryValue[i+1] += tempFloat4 ;
                nowBattaryValue[i] = nowBattaryValue[i] - tempFloat4*1000;  
            }
        }



        if(tempint4 > tempint3 || (tempint4 == tempint3 && nowBattaryValue[tempint4] >= battary[tempint4] ))
        {
            for (int i = 0; i <= tempint4; i++)
            {
                if(nowBattaryValue[i] >=battary[i] ){
                    nowBattaryValue[i] = nowBattaryValue[i] -  Mathf.FloorToInt(battary[i]) ;
                }
                else {
                    nowBattaryValue[i] = nowBattaryValue[i] + 1000 - battary[i];
                }
            }
            if(tempint4 == 0 && battary[tempint4] !=0){
                LevelUp();
                TopLevelBar.TopAnimTextNext();
                mapObjectCreater.Create();
            }
            else if(tempint4 != 0){
                LevelUp();
                TopLevelBar.TopAnimTextNext();
                mapObjectCreater.Create();
            }
        
        } 

            if (tempint4 !=0){ 
                tempFloat2 = nowBattaryValue[tempint4] + nowBattaryValue[tempint4-1]/1000;
                tempFloat3 = battary[tempint4] + battary[tempint4-1]/1000;
            }
            else  {
                tempFloat2 = nowBattaryValue[tempint4];
                tempFloat3 = battary[tempint4];
            }

            
        if(BattaryText.battaryStringNumber == 0){
            BattaryText.nowBattaryValue = nowBattaryValue[BattaryText.battaryStringNumber] ;
            BattaryText.nextBattaryValue = battary[BattaryText.battaryStringNumber] ;
        }
        else {
            BattaryText.nowBattaryValue = nowBattaryValue[BattaryText.battaryStringNumber] + nowBattaryValue[BattaryText.battaryStringNumber-1]/1000;
            BattaryText.nextBattaryValue = battary[BattaryText.battaryStringNumber] + battary[BattaryText.battaryStringNumber-1]/1000;
        }
    
        //print();
    }


    void BattaryLevelValue(){
        level = PlayerSettings.getLevelMap(activeMap);
        levelFloat = level+1;
        if(isLevelUp == 1){tempint2 += 1; isLevelUp = 0;}

        Debug.Log("İstenLevel Up : " + isTenLevelUp);
        if (isTenLevelUp == 20 ) {tempint1 += 1; tempint2 = 1; isTenLevelUp = 0;}
       
        BattaryClear();

        battary[tempint1] += tempint2*(levelFloat)*tempint2;

            for (int i = tempint1; i < 30; i++){
                tempFloat = Mathf.FloorToInt(battary[i]/1000);
                if (tempFloat >=1f){
                    battary[i+1] += tempFloat ;
                    battary[i] = battary[i] - tempFloat*1000;
                   
                }
                if(battary[i] > 0f){
                     BattaryText.battaryStringNumber = i;
                }
            }
    }


    void BattaryClear(){
        for (int i = 0; i < 30; i++)
        {
            battary[i] = 0;
        }
    }


    void LevelUpandNowBattaryClear(){
        for (int i = 0; i < 30; i++)
        {
            nowBattaryValue[i] = 0;
        }
    }

    void LevelUp(){
        
        isTenLevelUp += 1;
        isLevelUp = 1;
        PlayerSettings.setLevelMap(0,PlayerSettings.getLevelMap(0)+1);
        if(level >=50){SoulText.soulUpdateValue = (level-49)*10;};
        BattaryLevelValue();
    }

    void NowBattaryValueSaved(){
        for (int i = 0; i < 30; i++)
        {
            PlayerSettings.setNowBattaryValue(i, nowBattaryValue[i]);
        }
    }

    void print(){
        Debug.Log("Now Battary : " + BattaryText.nowBattaryValue);
        Debug.Log("Next Level Battary : " + BattaryText.nextBattaryValue);
        Debug.Log("Ten Level Up : " + isTenLevelUp);
        Debug.Log("Temp İnt  : " + tempint1);
        
    }
}

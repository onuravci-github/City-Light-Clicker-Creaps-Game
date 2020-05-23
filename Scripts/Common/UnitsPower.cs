using UnityEngine;
public class UnitsPower : MonoBehaviour
{
    private int unitnumber;
    private int unitlevel;
    private float unitlevelfloat;
    private int levelExtraBonus;

    private int tempint1;
    private int tempint2;
    private int tempint3;
    private float tempfloat;

    
    public float [] power = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    public static string [] powerString= {"","K","M","B","T","AA","BB","CC","DD","EE","FF","GG"
                                         ,"HH","II","JJ","KK","LL","MM","NN","OO","PP","QQ"
                                         ,"RR","SS","TT","UU","VV","WW","XX","YY"};
    

    // Start is called before the first frame update
    void Start()
    {
        unitnumber = this.GetComponent<UnitProperty>().unitnumber;
        unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);
        
        unitlevelfloat = unitlevel;
        UnitInfoBarText.autospeed[unitnumber] = unitnumber+1;
        PowerUpdate();
    }

    void PowerUpdate() {
        unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);
        unitlevelfloat = unitlevel;

        if(unitlevel <25){levelExtraBonus = 1;}
        else if(unitlevel <50){levelExtraBonus = 2;}
        else if(unitlevel <75){levelExtraBonus = 4;}
        else if(unitlevel <100){levelExtraBonus = 6;}
        else if(unitlevel <125){levelExtraBonus = 8;}
        else if(unitlevel <150){levelExtraBonus = 12;}
        else if(unitlevel <200){levelExtraBonus = 15;}
        else { levelExtraBonus += 50;}

        if (unitnumber == 0)        {tempint1 = 0; tempint2 = 1;}
        else if (unitnumber == 1)   {tempint1 = 0; tempint2 = 10;}
        else if (unitnumber == 2)   {tempint1 = 0; tempint2 = 100;}
        else if (unitnumber == 3)   {tempint1 = 1; tempint2 = 1;}
        else if (unitnumber == 4)   {tempint1 = 1; tempint2 = 10;}
        else if (unitnumber == 5)   {tempint1 = 1; tempint2 = 100;}
        else if (unitnumber == 6)   {tempint1 = 2; tempint2 = 1;}
        else if (unitnumber == 7)   {tempint1 = 2; tempint2 = 10;}

        PowerClear();
        power[tempint1] += tempint2*(unitlevelfloat)*levelExtraBonus;

            for (int i = tempint1; i < 30; i++){
                tempfloat = Mathf.FloorToInt(power[i]/1000);
                if (tempfloat >=1f){
                    power[i+1] += tempfloat ;
                    power[i] = power[i] - tempfloat*1000;
                }
            }

        if(unitnumber == 0){
            for (int i = 0; i < 30; i++)
            {
                Clicker.ClickerPower[i] = power[i] ;
            }
        }
    }

    void PowerClear(){
        for (int i = 0; i < 30; i++)
        {
            power[i] = 0;
        }
    }


    public void UnitLevelUp(){
        PowerUpdate();

        UnitInfoBarText.UnitNumber = unitnumber;

        if(unitlevel>=1 && unitlevel <=49){        UnitInfoBarText.autospeed[unitnumber] = (unitnumber)/1f;}
        else if(unitlevel>=50 && unitlevel <=99){        UnitInfoBarText.autospeed[unitnumber] = (unitnumber)/2f;}
        else if(unitlevel>=100 && unitlevel <=199){ UnitInfoBarText.autospeed[unitnumber] = (unitnumber)/3f; }
        else if(unitlevel>=200){                    UnitInfoBarText.autospeed[unitnumber] = (unitnumber)/4f;}
        else {UnitInfoBarText.autospeed[unitnumber] = 0;}

        for (int i = 29; i >= 0; i--){
            if(power[i] > 0f){
                tempint3 = i;
                break;
            }
        }
        if (tempint3 != 0){      UnitInfoBarText.unitPower[unitnumber] = (power[tempint3]+(power[tempint3-1]/1000)).ToString("F2") + " " + powerString[tempint3]; }
        else if (tempint3 == 0){ UnitInfoBarText.unitPower[unitnumber] = power[tempint3].ToString("F2") + powerString[tempint3]; }
    }


    public void UnitNextLevelPower(){

    }






}

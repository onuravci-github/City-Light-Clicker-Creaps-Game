using UnityEngine;
using UnityEngine.UI;

public class UnitsText : MonoBehaviour
{
    public int textfunction;
    private int unitnumber;
    private int unitlevel;
    private string nextlevelstring;

    private float unitlevelfloat;
    private int unitlevelextra;
    private Text text;
    private float tempfloat;
    private int tempint1;
    private int tempint2;
    private int tempint3;
    private int tempint4;
    private int tempint5;
    private int tempint6;

    private int control1 = 0;
    private int control2 = 0;

    private UnitsPower unitsPower;

    private static string [] strings1 = {"25","50","75","100","125","150","200","250"};
    private static string [] strings2 = {"AAAAA","BBBBB","CCCCC","DDDDD","EEEEE","FFFFF","GGGGG","HHHHHH"};


    public float [] gold = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    public static string [] goldstring= {"","K","M","B","T","AA","BB","CC","DD","EE","FF","GG"
                                         ,"HH","II","JJ","KK","LL","MM","NN","OO","PP","QQ"
                                         ,"RR","SS","TT","UU","VV","WW","XX","YY"};
    // Start is called before the first frame update
    void Start()
    {
        
        text = this.GetComponent<Text>();
        unitsPower = this.GetComponentInParent<UnitsPower>();
        unitnumber = this.GetComponentInParent<UnitProperty>().unitnumber;

        if(unitnumber != 0 ){unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);}
        else unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber)+1;

        unitlevelfloat = unitlevel;
        LevelUpUnit();
    }
    void Update()
    {
        if (textfunction == 0){
            unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);
            unitlevelfloat = unitlevel;
            if (unitlevel < 25)        {nextlevelstring = "25";}
            else if (unitlevel < 50)   {nextlevelstring = "50";}
            else if (unitlevel < 75)   {nextlevelstring = "75";}
            else if (unitlevel < 100)  {nextlevelstring = "100";}
            else if (unitlevel < 125)  {nextlevelstring = "125";}
            else if (unitlevel < 150)  {nextlevelstring = "150";}
            else if (unitlevel < 200)  {nextlevelstring = "200";}
            else {nextlevelstring = "Complete";}
            text.text = "Lv. " + unitlevel.ToString() + strings2[unitnumber] + "Upgrade Lv." + nextlevelstring;
        }
    }
    
    void LevelUpUnit(){
        

        if (textfunction == 1)
        {
            unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);
            unitlevelfloat = unitlevel+1;
            GoldClear();

            GoldUpdate();
            for (int i = 29; i >= 0; i--){
                if(gold[i] > 0f){
                    tempint3 = i;
                    break;
                }
            }
            if (tempint3 != 0){
                text.text = (gold[tempint3]+(gold[tempint3-1]/1000)).ToString("F2") + " " + goldstring[tempint3]; 
            }
            else if (tempint3 == 0){
                text.text = gold[tempint3].ToString("F2") + goldstring[tempint3]; 
            }
        }
        
        
    }

    void GoldUpdate() {
        
        if (unitnumber == 0)        {tempint1 = 0; tempint2 = 10;}
        else if (unitnumber == 1)   {tempint1 = 0; tempint2 = 100;}
        else if (unitnumber == 2)   {tempint1 = 1; tempint2 = 1;}
        else if (unitnumber == 3)   {tempint1 = 1; tempint2 = 10;}
        else if (unitnumber == 4)   {tempint1 = 1; tempint2 = 100;}
        else if (unitnumber == 5)   {tempint1 = 2; tempint2 = 1;}
        else if (unitnumber == 6)   {tempint1 = 2; tempint2 = 10;}
        else if (unitnumber == 7)   {tempint1 = 2; tempint2 = 100;}

        if(UnitBuyX.BuyX == 0 )      {tempint4 = 1;}
        else if(UnitBuyX.BuyX == 1 ) {tempint4 = 5;}
        else if(UnitBuyX.BuyX == 2 ) {tempint4 = 10;}

        
            for (int k = 0; k < tempint4; k++){
                UnitLevelExtraUpdate(unitlevelfloat+k);
                gold[tempint1] += tempint2*(unitlevelfloat+k)*unitlevelextra;
                for (int i = tempint1; i < 30; i++){
                    tempfloat = Mathf.FloorToInt(gold[i]/1000);
                    if (tempfloat >=1f){
                        gold[i+1] += tempfloat ;
                        gold[i] = gold[i] - tempfloat*1000;
                    }
                }
            }
    }

    void GoldClear(){
        for (int i = 0; i < 30; i++)
        {
            gold[i] = 0;
        }
    }


    void UnitLevelExtraUpdate(float levelfloat){
        if (levelfloat <25)         {unitlevelextra = 1;}
        else if (levelfloat <50)    {unitlevelextra = 2;}
        else if (levelfloat <75)    {unitlevelextra = 5;}
        else if (levelfloat <100)   {unitlevelextra = 10;}
        else if (levelfloat <125)   {unitlevelextra = 20;}
        else if (levelfloat <150)   {unitlevelextra = 40;}
        else if (levelfloat <200)   {unitlevelextra = 80;}
        else                        {unitlevelextra = 100;}
    }


    public void UnitLevelUp(){

        control1 = 0;
        control2 = 0;

        for (int i = 29; i >= 0; i--)
        {
            if(gold[i] > 0f && control1 == 0){tempint5 = i; control1 = 1;}
            if(PlayerSettings.getMainGold1(i) > 0f && control2 == 0) {tempint6 = i; control2 = 1;}
            
        }
        Debug.Log(tempint5 + " ////////" + tempint6);

        if(tempint6 > tempint5 || (tempint6 == tempint5 && PlayerSettings.getMainGold1(tempint6) >= gold[tempint6] ))
        {
            for (int i = 0; i <= tempint6; i++)
            {
                if(PlayerSettings.getMainGold1(i) >=gold[i] ){
                    PlayerSettings.setMainGold1(i,PlayerSettings.getMainGold1(i) - gold[i]) ;
                }
                else{
                    PlayerSettings.setMainGold1(i+1,(PlayerSettings.getMainGold1(i+1)-1));
                    PlayerSettings.setMainGold1(i,PlayerSettings.getMainGold1(i) + 1000 - gold[i]);
                }
            }


            if(UnitBuyX.BuyX == 0 )      {tempint4 = 1;}
            else if(UnitBuyX.BuyX == 1 ) {tempint4 = 5;}
            else if(UnitBuyX.BuyX == 2 ) {tempint4 = 10;}

            PlayerSettings.setMap1UnitLevel(unitnumber,unitlevel = unitlevel + tempint4);
            LevelUpUnit();
            unitsPower.UnitLevelUp();
            StarsCreate.createnumb[unitnumber]++;
            PlayerSettings.setUnitUpgradeNumb(PlayerSettings.getUnitUpgradeNumb() + tempint4);
        }   
    }

    public void UnitXUpdate(){
        PlayerSettings.setMap1UnitLevel(unitnumber,unitlevel);
        LevelUpUnit();
    }


}

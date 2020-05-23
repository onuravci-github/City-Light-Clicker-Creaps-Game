using UnityEngine;
using UnityEngine.UI;

public class GoldText : MonoBehaviour
{
    public static int activemap;

    public static float tempfloat;

    private Text goldtext;

    public static int goldstringnumber = 0;
    public static float [] maingoldtext = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    public static string [] maingoldstring= {" ","K","M","B","T","AA","BB","CC","DD","EE","FF","GG"
                                            ,"HH","II","JJ","KK","LL","MM","NN","OO","PP","QQ"
                                            ,"RR","SS","TT","UU","VV","WW","XX","YY"};


    // Start is called before the first frame update
    void Start()
    {
        goldtext = this.GetComponent<Text>();
        activemap = PlayerSettings.getActiveMap();
        GoldStart();
    }

    // Update is called once per frame
    void Update()
    {
        GoldStart();
        if (activemap == 0){
            for (int i = 0; i < 30; i++){
                if(maingoldtext[i] > 0){
                    goldstringnumber = i;
                }
            }
            if(goldstringnumber !=0){goldtext.text = (maingoldtext[goldstringnumber]+(maingoldtext[goldstringnumber-1]/1000)).ToString("F1") + maingoldstring[goldstringnumber].ToString();}
            else goldtext.text = maingoldtext[goldstringnumber].ToString("F0") + maingoldstring[goldstringnumber].ToString();
        }
    }
    //string dateAndTimeVar = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

    //{"/1K","/1M","/1T","/1CC","/1FF","/1QQ","/1TT"};
    public static void GoldStart(){
        if (activemap == 0){
  
            for (int i = 0; i < 30; i++){
                tempfloat = Mathf.FloorToInt(PlayerSettings.getMainGold1(i)/1000);
                if (tempfloat >=1f){
                    PlayerSettings.setMainGold1(i+1,(PlayerSettings.getMainGold1(i+1) + tempfloat)) ;
                    PlayerSettings.setMainGold1(i,(PlayerSettings.getMainGold1(i) - (tempfloat*1000))) ;
                }
                maingoldtext[i] = PlayerSettings.getMainGold1(i);
            }
            if(maingoldtext[24] > 0) {PlayerSettings.setCrpGain(7);}
            else if(maingoldtext[1] > 0) {PlayerSettings.setCrpGain(1);}
            else if(maingoldtext[2] > 0) {PlayerSettings.setCrpGain(2);}
            else if(maingoldtext[4] > 0) {PlayerSettings.setCrpGain(3);}
            else if(maingoldtext[7] > 0) {PlayerSettings.setCrpGain(4);}
            else if(maingoldtext[10] > 0) {PlayerSettings.setCrpGain(5);}
            else if(maingoldtext[21] > 0) {PlayerSettings.setCrpGain(6);}
        }
        else if (activemap == 1){
            for (int i = 0; i < 30; i++){
                maingoldtext[i] = PlayerSettings.getMainGold2(i);
            }
        }
        else if(activemap == 1){
            for (int i = 0; i < 30; i++){
                maingoldtext[i] = PlayerSettings.getMainGold3(i);
            }
        }
    }
}

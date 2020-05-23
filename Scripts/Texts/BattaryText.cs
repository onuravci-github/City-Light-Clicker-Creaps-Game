using UnityEngine;
using UnityEngine.UI;

public class BattaryText : MonoBehaviour
{
    public int battaryfunction;
    private Text battarytext;
    private float tempfloat;

    public static float nowBattaryValue;
    public static float nextBattaryValue;
    public static int battaryStringNumber = 0;

    public static string [] battaryPowerString = {"","K","M","B","T","AA","BB","CC","DD","EE","FF","GG"
                                                ,"HH","II","JJ","KK","LL","MM","NN","OO","PP","QQ"
                                                ,"RR","SS","TT","UU","VV","WW","XX","YY"};
    // Start is called before the first frame update
    void Start()
    {  
        battarytext = this.GetComponent<Text>();
        

        if (battaryfunction == 0){
            battarytext.text = PlayerSettings.getLevelMap(PlayerSettings.getActiveMap()).ToString();
        }
        else if (battaryfunction == 1){
            battarytext.text = (PlayerSettings.getLevelMap(PlayerSettings.getActiveMap())+1).ToString();
        }
        else if (battaryfunction == 2){
            battarytext.text = nowBattaryValue.ToString("F2") + battaryPowerString[battaryStringNumber] + "Power";
        }
        else if (battaryfunction == 3){
            battarytext.text = "Lv." + (PlayerSettings.getLevelMap(PlayerSettings.getActiveMap())+1).ToString() + "Power";
        }
        else if (battaryfunction == 4){
            battarytext.text = nextBattaryValue.ToString("F2") + battaryPowerString[battaryStringNumber];
        }
        else if (battaryfunction == 5){
            tempfloat = nowBattaryValue/nextBattaryValue;
            transform.localScale = new Vector3(tempfloat*0.2f,0.4f,1f);
        }
        else if (battaryfunction == 6){
            tempfloat = nowBattaryValue/nextBattaryValue/0.33f;
            transform.localScale = new Vector3(tempfloat*0.1f,0.2f,1f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (battaryfunction == 0){
            battarytext.text = PlayerSettings.getLevelMap(PlayerSettings.getActiveMap()).ToString();
        }
        else if (battaryfunction == 1){
            battarytext.text = (PlayerSettings.getLevelMap(PlayerSettings.getActiveMap())+1).ToString();
        }
        else if (battaryfunction == 2){
            battarytext.text = nowBattaryValue.ToString("F2") + battaryPowerString[battaryStringNumber] + " Power";
        }
        else if (battaryfunction == 3){
            battarytext.text = "Lv." + (PlayerSettings.getLevelMap(PlayerSettings.getActiveMap())+1).ToString() + " Power";
        }
        else if (battaryfunction == 4){
            battarytext.text = nextBattaryValue.ToString("F2") + battaryPowerString[battaryStringNumber];
        }
        else if (battaryfunction == 5){
            tempfloat = nowBattaryValue/nextBattaryValue;
            transform.localScale = new Vector3(tempfloat*0.2f,0.4f,1f);
        }
        else if (battaryfunction == 6){
            tempfloat = nowBattaryValue/nextBattaryValue/0.33f;
            transform.localScale = new Vector3(tempfloat*0.1f,0.2f,1f);
        }
    }
}

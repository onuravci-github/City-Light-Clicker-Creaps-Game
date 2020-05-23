using UnityEngine;
using UnityEngine.UI;
public class UnitInfoBarText : MonoBehaviour
{
    public int infofunction;
    private Text infobartext;

    // Mouse Down Units set UnitNumber
    public static int UnitNumber;
    private static string [] UnitName = {"Atom","Electron","Fast","Star","AAAAA","BBBBBB","CCCCCC"};
    public static string [] unitPower = {"","","","","","",""};
    public static float [] autospeed = {0f,0f,0f,0f,0f,0f,0f};
    
    // Start is called before the first frame update
    void Start()
    {
        infobartext = this.GetComponent<Text>();
        if(infofunction == 0){
            infobartext.text = UnitName[UnitNumber];
        }
        else if (infofunction == 1){
            infobartext.text = "Level " + PlayerSettings.getMap1UnitLevel(UnitNumber).ToString();
        }
        else if (infofunction == 2){
            infobartext.text = "Power " + unitPower[UnitNumber];
        }
        else if (infofunction == 3){ 
            //infobartext.text = "Bonus %" + PlayerSettings.getMap1UnitPowerBonus(UnitNumber).ToString();
        }
        else if (infofunction == 4){
            if (UnitNumber == 0 ){  infobartext.text = "Please Click";}
            else infobartext.text = "Auto Click " + autospeed[UnitNumber].ToString("F2") + "s";
        }
        else if (infofunction == 5){
            //infobartext.text = "Bonus %" + PlayerSettings.getMap1UnitAutoBonus(UnitNumber).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(infofunction == 0){
            infobartext.text = UnitName[UnitNumber];
        }
        else if (infofunction == 1){
            infobartext.text = "Level " + PlayerSettings.getMap1UnitLevel(UnitNumber).ToString();
        }
        else if (infofunction == 2){
            infobartext.text = "Power " + unitPower[UnitNumber];
        }
        else if (infofunction == 3){ 
            //infobartext.text = "Bonus %" + PlayerSettings.getMap1UnitPowerBonus(UnitNumber).ToString();
        }
        else if (infofunction == 4){
            if (UnitNumber == 0 ){  infobartext.text = "Please Click";}
            else infobartext.text = "Auto Click " + autospeed[UnitNumber].ToString("F2") + "s";
        }
        else if (infofunction == 5){
            //infobartext.text = "Bonus %" + PlayerSettings.getMap1UnitAutoBonus(UnitNumber).ToString();
        }
    }

    
}

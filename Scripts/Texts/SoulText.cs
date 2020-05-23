using UnityEngine;
using UnityEngine.UI;

public class SoulText : MonoBehaviour
{
    public static Text mainsoultext; // Main Soul Text
    public static Text soultext; // Soul % Text
    public static Text soulupdatetext; // + Soul Text
    public static int soulUpdateValue; // + Soul Value
    public int soulStyle; // Soul Texts Function Select
    
    void Start()
    {
        if(soulStyle == 0){
            mainsoultext = this.GetComponent<Text>();
            if (PlayerSettings.getMainSoul() >999999){
                mainsoultext.text = (PlayerSettings.getMainSoul()/100000).ToString() + "M";
            }
            else{
                mainsoultext.text = PlayerSettings.getMainSoul().ToString();
            }
            
        }
        else if(soulStyle == 1){
            soultext = this.GetComponent<Text>();
            soultext.text = "%" + (PlayerSettings.getMainSoul()/10).ToString();
        }
        else if(soulStyle == 2){
            soulupdatetext = this.GetComponent<Text>();
            soulupdatetext.text = "+" + soulUpdateValue.ToString() + " CRP";
        }
        else if(soulStyle == 3){
            soulupdatetext = this.GetComponent<Text>();
            soulupdatetext.text = "Press +" + soulUpdateValue.ToString() + "CRP";
        }
    }

    void Update(){
            if(soulStyle == 0){
                if (PlayerSettings.getMainSoul() >999999){
                    mainsoultext.text = (PlayerSettings.getMainSoul()/100000).ToString() + "M";
                }
                else{
                    mainsoultext.text = PlayerSettings.getMainSoul().ToString();
                }
            }
            else if(soulStyle == 1){
                soultext.text = "%" + (PlayerSettings.getMainSoul()/10).ToString();
            }
            else if(soulStyle == 2){
                soulupdatetext.text = "+" + soulUpdateValue.ToString() + " CRP";
            }
            else if(soulStyle == 3){
                soulupdatetext.text = "Press +" + soulUpdateValue.ToString() + "CRP";
            }
    }

}

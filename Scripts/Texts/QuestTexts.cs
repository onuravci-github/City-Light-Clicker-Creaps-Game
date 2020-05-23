using UnityEngine;
using UnityEngine.UI;

public class QuestTexts : MonoBehaviour
{
    private int Questnumb;
    public int Questfunct;
    private Text Questtext;


    private static string [] quest1 = {"/100","/1000","/5000","/10k","/50k","/100k","/250k"};
    private static string [] quest2 = {"/1K","/1M","/1T","/1CC","/1FF","/1QQ","/1TT"};
    private static string [] quest3 = {"/10","/25","/50","/100","/250","/500","/1000"};
    private static string [] quest4 = {"/10","/100","/250","/500","/1000","/2500","/5000"};
    private static string [] quest5 = {"/2","/10","/20"};
    private static string [] quest6 = {"/1","/2","/3"};
    private static string [] quest7 = {"/10","/100","/250","/500","/1000","/2500","/50000"};

    // Start is called before the first frame update
    void Start()
    {
        Questnumb = this.GetComponentInParent<QuestNumb>().Questnumb;
        Questtext = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Questfunct == 0)
        {
            if(Questnumb == 0){
                if(PlayerSettings.getClickNumb() <=100) { Questtext.text = "Click " + PlayerSettings.getClickNumb().ToString() + quest1[0]; }
                else if(PlayerSettings.getClickNumb() <=1000) { Questtext.text = "Click " + PlayerSettings.getClickNumb().ToString() + quest1[1]; }
                else if(PlayerSettings.getClickNumb() <=5000) { Questtext.text = "Click " + PlayerSettings.getClickNumb().ToString() + quest1[2]; }
                else if(PlayerSettings.getClickNumb() <=10000) { Questtext.text = "Click " + PlayerSettings.getClickNumb().ToString() + quest1[3]; }
                else if(PlayerSettings.getClickNumb() <=50000) { Questtext.text = "Click " + PlayerSettings.getClickNumb().ToString() + quest1[4]; }
                else if(PlayerSettings.getClickNumb() <=10000) { Questtext.text = "Click " + PlayerSettings.getClickNumb().ToString() + quest1[5]; }
                else if(PlayerSettings.getClickNumb() <=250000) { Questtext.text = "Click " + PlayerSettings.getClickNumb().ToString() + quest1[6]; }
                else { Questtext.text = "Complete"; }
            }
            else if(Questnumb == 1){
                if(PlayerSettings.getGoldQuest() <1) { Questtext.text = "CRP Gain " +  GoldText.maingoldtext[GoldText.goldstringnumber].ToString() + GoldText.maingoldstring[GoldText.goldstringnumber].ToString() + quest2[0]; }
                else if(PlayerSettings.getGoldQuest() <2) { Questtext.text = "CRP Gain " +  GoldText.maingoldtext[GoldText.goldstringnumber].ToString() + GoldText.maingoldstring[GoldText.goldstringnumber].ToString() + quest2[1]; }
                else if(PlayerSettings.getGoldQuest() <3) { Questtext.text = "CRP Gain " +  GoldText.maingoldtext[GoldText.goldstringnumber].ToString() + GoldText.maingoldstring[GoldText.goldstringnumber].ToString() + quest2[2]; }
                else if(PlayerSettings.getGoldQuest() <4) { Questtext.text = "CRP Gain " +  GoldText.maingoldtext[GoldText.goldstringnumber].ToString() + GoldText.maingoldstring[GoldText.goldstringnumber].ToString() + quest2[3]; }
                else if(PlayerSettings.getGoldQuest() <5) { Questtext.text = "CRP Gain " +  GoldText.maingoldtext[GoldText.goldstringnumber].ToString() + GoldText.maingoldstring[GoldText.goldstringnumber].ToString() + quest2[4]; }
                else if(PlayerSettings.getGoldQuest() <6) { Questtext.text = "CRP Gain " +  GoldText.maingoldtext[GoldText.goldstringnumber].ToString() + GoldText.maingoldstring[GoldText.goldstringnumber].ToString() + quest2[5]; }
                else if(PlayerSettings.getGoldQuest() <7) { Questtext.text = "CRP Gain " +  GoldText.maingoldtext[GoldText.goldstringnumber].ToString() + GoldText.maingoldstring[GoldText.goldstringnumber].ToString() + quest2[6]; }
                else { Questtext.text = "Complete"; }
            }
            else if(Questnumb == 2){
                if(PlayerSettings.getWatchAdsNumb() <=10) { Questtext.text = "Watch Ads " +  PlayerSettings.getWatchAdsNumb().ToString() + quest3[0]; }
                else if(PlayerSettings.getWatchAdsNumb() <=25) { Questtext.text = "Watch Ads " +  PlayerSettings.getWatchAdsNumb().ToString() + quest3[1]; }                
                else if(PlayerSettings.getWatchAdsNumb() <=50) { Questtext.text = "Watch Ads " +  PlayerSettings.getWatchAdsNumb().ToString() + quest3[2]; }                
                else if(PlayerSettings.getWatchAdsNumb() <=100) { Questtext.text = "Watch Ads " +  PlayerSettings.getWatchAdsNumb().ToString() + quest3[3]; }                
                else if(PlayerSettings.getWatchAdsNumb() <=250) { Questtext.text = "Watch Ads " +  PlayerSettings.getWatchAdsNumb().ToString() + quest3[4]; }               
                else if(PlayerSettings.getWatchAdsNumb() <=500) { Questtext.text = "Watch Ads " +  PlayerSettings.getWatchAdsNumb().ToString() + quest3[5]; }                
                else if(PlayerSettings.getWatchAdsNumb() <=1000) { Questtext.text = "Watch Ads " +  PlayerSettings.getWatchAdsNumb().ToString() + quest3[6]; }                
                else { Questtext.text = "Complete"; }
            }
            else if(Questnumb == 3){
                if(PlayerSettings.getUnitUpgradeNumb() <=10) { Questtext.text = "Upgrade " +  PlayerSettings.getUnitUpgradeNumb().ToString() + quest4[0]; }
                else if(PlayerSettings.getUnitUpgradeNumb() <=100) { Questtext.text = "Upgrade " +  PlayerSettings.getUnitUpgradeNumb().ToString() + quest4[1]; }                
                else if(PlayerSettings.getUnitUpgradeNumb() <=250) { Questtext.text = "Upgrade " +  PlayerSettings.getUnitUpgradeNumb().ToString() + quest4[2]; }                
                else if(PlayerSettings.getUnitUpgradeNumb() <=500) { Questtext.text = "Upgrade " +  PlayerSettings.getUnitUpgradeNumb().ToString() + quest4[3]; }                
                else if(PlayerSettings.getUnitUpgradeNumb() <=1000) { Questtext.text = "Upgrade " +  PlayerSettings.getUnitUpgradeNumb().ToString() + quest4[4]; }               
                else if(PlayerSettings.getUnitUpgradeNumb() <=2500) { Questtext.text = "Upgrade " +  PlayerSettings.getUnitUpgradeNumb().ToString() + quest4[5]; }                
                else if(PlayerSettings.getUnitUpgradeNumb() <=5000) { Questtext.text = "Upgrade " +  PlayerSettings.getUnitUpgradeNumb().ToString() + quest4[6]; }                
                else { Questtext.text = "Complete"; }
            }
            else if(Questnumb == 4){
                if(PlayerSettings.getOpenDay() <= 2) { Questtext.text = "Open Day " +  PlayerSettings.getOpenDay().ToString() + quest4[0]; }
                else if(PlayerSettings.getOpenDay() <= 10) { Questtext.text = "Open Day " +  PlayerSettings.getOpenDay().ToString() + quest4[1]; } 
                else if(PlayerSettings.getOpenDay() <= 20) { Questtext.text = "Open Day " +  PlayerSettings.getOpenDay().ToString() + quest4[2]; }  
                else { Questtext.text = "Complete"; }
            }
            else if(Questnumb == 5){
                if(PlayerSettings.getOpenMap() == 1) { Questtext.text = "Open Day " +  PlayerSettings.getOpenDay().ToString() + quest5[0]; }
                else if(PlayerSettings.getOpenDay() == 2) { Questtext.text = "Open Day " +  PlayerSettings.getOpenDay().ToString() + quest5[1]; }                
                else if(PlayerSettings.getOpenDay() >= 3) { Questtext.text = "Open Day " +  PlayerSettings.getOpenDay().ToString() + quest5[2]; } 
            }
            else if(Questnumb == 6){
                if(PlayerSettings.getMainSoul() <=10) { Questtext.text = "Soul CRP " +  PlayerSettings.getMainSoul().ToString() + quest6[0]; }
                else if(PlayerSettings.getMainSoul() <=100) { Questtext.text = "Soul CRP " +  PlayerSettings.getMainSoul().ToString() + quest6[1]; }                
                else if(PlayerSettings.getMainSoul() <=250) { Questtext.text = "Soul CRP " +  PlayerSettings.getMainSoul().ToString() + quest6[2]; }                
                else if(PlayerSettings.getMainSoul() <=500) { Questtext.text = "Soul CRP " +  PlayerSettings.getMainSoul().ToString() + quest6[3]; }                
                else if(PlayerSettings.getMainSoul() <=1000) { Questtext.text = "Soul CRP " +  PlayerSettings.getMainSoul().ToString() + quest6[4]; }               
                else if(PlayerSettings.getMainSoul() <=2500) { Questtext.text = "Soul CRP " +  PlayerSettings.getMainSoul().ToString() + quest6[5]; }                
                else if(PlayerSettings.getMainSoul() <=50000) { Questtext.text = "Soul CRP " +  PlayerSettings.getMainSoul().ToString() + quest6[6]; }                
                else { Questtext.text = "Complete"; }
            }
        }

        else if(Questfunct == 1)
        {
            if(Questnumb == 0){
                if(PlayerSettings.getClickNumb() <=100) { Questtext.text = "+%10 Click Power"; }
                else if(PlayerSettings.getClickNumb() <=1000) { Questtext.text = "+%50 Click Power"; }
                else if(PlayerSettings.getClickNumb() <=5000) { Questtext.text = "+%100 Click Power"; }
                else if(PlayerSettings.getClickNumb() <=10000) { Questtext.text = "+%250 Click Power"; }
                else if(PlayerSettings.getClickNumb() <=50000) { Questtext.text = "+%500 Click Power"; }
                else if(PlayerSettings.getClickNumb() <=10000) { Questtext.text = "+%750 Click Power"; }
                else if(PlayerSettings.getClickNumb() <=250000) { Questtext.text = "+%1000 Click Power"; }
                else { Questtext.text = "+%1000 Click Power"; }
            }
            else if(Questnumb == 1){
                if(PlayerSettings.getGoldQuest() <1) { Questtext.text = "+%10 CRP Gain"; }
                else if(PlayerSettings.getGoldQuest() <2) { Questtext.text = "+%25 CRP Gain"; }
                else if(PlayerSettings.getGoldQuest() <3) { Questtext.text = "+%50 CRP Gain"; }
                else if(PlayerSettings.getGoldQuest() <4) { Questtext.text = "+%100 CRP Gain"; }
                else if(PlayerSettings.getGoldQuest() <5) { Questtext.text = "+%150 CRP Gain"; }
                else if(PlayerSettings.getGoldQuest() <6) { Questtext.text = "+%250 CRP Gain"; }
                else if(PlayerSettings.getGoldQuest() <7) { Questtext.text = "+%500 CRP Gain"; }
                else { Questtext.text = "+%500 CRP Gain"; }
            }
            else if(Questnumb == 2){
                if(PlayerSettings.getWatchAdsNumb() <=10) { Questtext.text = "+%10 CRP Gain"; }
                else if(PlayerSettings.getWatchAdsNumb() <=25) { Questtext.text = "+%25 CRP Gain"; }                
                else if(PlayerSettings.getWatchAdsNumb() <=50) { Questtext.text = "+%50 CRP Gain"; }               
                else if(PlayerSettings.getWatchAdsNumb() <=100) { Questtext.text = "+%100 CRP Gain"; }           
                else if(PlayerSettings.getWatchAdsNumb() <=250) { Questtext.text = "+%150 CRP Gain"; }             
                else if(PlayerSettings.getWatchAdsNumb() <=500) { Questtext.text = "+%250 CRP Gain"; }            
                else if(PlayerSettings.getWatchAdsNumb() <=1000) { Questtext.text = "+%500 CRP Gain"; }          
                else { Questtext.text = "+%500 CRP Gain"; }
            }
            else if(Questnumb == 3){
                if(PlayerSettings.getUnitUpgradeNumb() <=10) { Questtext.text = "+%10 Auto Speed"; }
                else if(PlayerSettings.getUnitUpgradeNumb() <=100) { Questtext.text = "+%20 Auto Speed"; }               
                else if(PlayerSettings.getUnitUpgradeNumb() <=250) { Questtext.text = "+%30 Auto Speed"; }               
                else if(PlayerSettings.getUnitUpgradeNumb() <=500) { Questtext.text = "+%40 Auto Speed"; }          
                else if(PlayerSettings.getUnitUpgradeNumb() <=1000) { Questtext.text = "+%50 Auto Speed"; }             
                else if(PlayerSettings.getUnitUpgradeNumb() <=2500) { Questtext.text = "+%75 Auto Speed"; }               
                else if(PlayerSettings.getUnitUpgradeNumb() <=5000) { Questtext.text = "+%100 Auto Speed"; }                
                else { Questtext.text = "+%100 Auto Speed"; }
            }
            else if(Questnumb == 4){
                if(PlayerSettings.getOpenDay() <= 2) { Questtext.text = "Play Game"; }
                else if(PlayerSettings.getOpenDay() <= 10) { Questtext.text = "%100 CRP Gain"; } 
                else if(PlayerSettings.getOpenDay() <= 20) { Questtext.text = "%500 CRP Gain"; }  
                else { Questtext.text = "%500 CRP Gain"; }
            }
            else if(Questnumb == 5){
                if(PlayerSettings.getOpenMap() == 1) { Questtext.text = "+%100 Power Click"; }
                else if(PlayerSettings.getOpenMap() == 2) { Questtext.text = "+%500 Power Click"; }             
                else if(PlayerSettings.getOpenMap() >= 3) { Questtext.text = "+%1000 Power Click"; }
            }
            else if(Questnumb == 6){
                if(PlayerSettings.getMainSoul() <=10) { Questtext.text = "+%10 Soul Gain"; }
                else if(PlayerSettings.getMainSoul() <=100) { Questtext.text = "+%25 Soul Gain"; }                
                else if(PlayerSettings.getMainSoul() <=250) { Questtext.text = "+%100 Soul Gain"; }                
                else if(PlayerSettings.getMainSoul() <=500) { Questtext.text = "+%250 Soul Gain"; }                
                else if(PlayerSettings.getMainSoul() <=1000) { Questtext.text = "+%500 Soul Gain"; }               
                else if(PlayerSettings.getMainSoul() <=2500) { Questtext.text = "+%750 Soul Gain"; }                
                else if(PlayerSettings.getMainSoul() <=50000) { Questtext.text = "+%1000 Soul Gain"; }                
                else { Questtext.text = "+%1000 Soul Gain"; }
            }
        }
    }
}

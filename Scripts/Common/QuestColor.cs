using UnityEngine;
using UnityEngine.UI;

public class QuestColor : MonoBehaviour
{

    private Image sprite;
    private QuestNumb questNumb;
    private ScrollBarLimit questcolor;
    // Start is called before the first frame update
    void Start()
    {
        sprite = this.GetComponent<Image>();
        questNumb = this.GetComponentInParent<QuestNumb>();
        questcolor = this.GetComponentInParent<ScrollBarLimit>();
    }

    // Update is called once per frame
    void Update()
    {
            if(questNumb.Questnumb == 0){
                if(PlayerSettings.getClickNumb() <=100) { sprite.color = questcolor.Questcolors[0]; }
                else if(PlayerSettings.getClickNumb() <=1000) { sprite.color = questcolor.Questcolors[1]; }
                else if(PlayerSettings.getClickNumb() <=5000) { sprite.color = questcolor.Questcolors[2]; }
                else if(PlayerSettings.getClickNumb() <=10000) { sprite.color = questcolor.Questcolors[3]; }
                else if(PlayerSettings.getClickNumb() <=50000) { sprite.color = questcolor.Questcolors[4]; }
                else if(PlayerSettings.getClickNumb() <=10000) { sprite.color = questcolor.Questcolors[5]; }
                else if(PlayerSettings.getClickNumb() <=250000) { sprite.color = questcolor.Questcolors[6]; }
                else {sprite.color = questcolor.Questcolors[6]; }
            }
            else if(questNumb.Questnumb == 1){
                if(PlayerSettings.getGoldQuest() <=1) { sprite.color = questcolor.Questcolors[0]; }
                else if(PlayerSettings.getGoldQuest() <=2) { sprite.color = questcolor.Questcolors[1]; }
                else if(PlayerSettings.getGoldQuest() <=3) { sprite.color = questcolor.Questcolors[2]; }
                else if(PlayerSettings.getGoldQuest() <=4) { sprite.color = questcolor.Questcolors[3]; }
                else if(PlayerSettings.getGoldQuest() <=5) { sprite.color = questcolor.Questcolors[4]; }
                else if(PlayerSettings.getGoldQuest() <=6) { sprite.color = questcolor.Questcolors[5]; }
                else if(PlayerSettings.getGoldQuest() <=7) { sprite.color = questcolor.Questcolors[6]; }
                else { sprite.color = questcolor.Questcolors[6]; }
            }
            else if(questNumb.Questnumb == 2){
                if(PlayerSettings.getWatchAdsNumb() <=10) { sprite.color = questcolor.Questcolors[0]; }
                else if(PlayerSettings.getWatchAdsNumb() <=25) { sprite.color = questcolor.Questcolors[1]; }                
                else if(PlayerSettings.getWatchAdsNumb() <=50) { sprite.color = questcolor.Questcolors[2]; }                
                else if(PlayerSettings.getWatchAdsNumb() <=100) { sprite.color = questcolor.Questcolors[3]; }                
                else if(PlayerSettings.getWatchAdsNumb() <=250) { sprite.color = questcolor.Questcolors[4]; }               
                else if(PlayerSettings.getWatchAdsNumb() <=500) { sprite.color = questcolor.Questcolors[5]; }                
                else if(PlayerSettings.getWatchAdsNumb() <=1000) { sprite.color = questcolor.Questcolors[6]; }                
                else { sprite.color = questcolor.Questcolors[6]; }
            }
            else if(questNumb.Questnumb == 3){
                if(PlayerSettings.getUnitUpgradeNumb() <=10) { sprite.color = questcolor.Questcolors[0]; }
                else if(PlayerSettings.getUnitUpgradeNumb() <=100) { sprite.color = questcolor.Questcolors[1]; }                
                else if(PlayerSettings.getUnitUpgradeNumb() <=250) { sprite.color = questcolor.Questcolors[2]; }                
                else if(PlayerSettings.getUnitUpgradeNumb() <=500) { sprite.color = questcolor.Questcolors[3]; }                
                else if(PlayerSettings.getUnitUpgradeNumb() <=1000) { sprite.color = questcolor.Questcolors[4]; }               
                else if(PlayerSettings.getUnitUpgradeNumb() <=2500) { sprite.color = questcolor.Questcolors[5]; }                
                else if(PlayerSettings.getUnitUpgradeNumb() <=5000) { sprite.color = questcolor.Questcolors[6]; }                
                else { sprite.color = questcolor.Questcolors[6]; }
            }
            else if(questNumb.Questnumb == 4){
                if(PlayerSettings.getOpenDay() <= 2) { sprite.color = questcolor.Questcolors[0]; }
                else if(PlayerSettings.getOpenDay() <= 10) { sprite.color = questcolor.Questcolors[3]; } 
                else if(PlayerSettings.getOpenDay() <= 20) { sprite.color = questcolor.Questcolors[6]; }  
                else { sprite.color = questcolor.Questcolors[6]; }
            }
            else if(questNumb.Questnumb == 5){
                if(PlayerSettings.getOpenMap() == 1) { sprite.color = questcolor.Questcolors[0]; }
                else if(PlayerSettings.getOpenDay() == 2) { sprite.color = questcolor.Questcolors[3]; }                
                else if(PlayerSettings.getOpenDay() >= 3) { sprite.color = questcolor.Questcolors[6]; } 
            }
            else if(questNumb.Questnumb == 6){
                if(PlayerSettings.getMainSoul() <=10) { sprite.color = questcolor.Questcolors[0]; }
                else if(PlayerSettings.getMainSoul() <=100) { sprite.color = questcolor.Questcolors[1]; }                
                else if(PlayerSettings.getMainSoul() <=250) { sprite.color = questcolor.Questcolors[2]; }                
                else if(PlayerSettings.getMainSoul() <=500) { sprite.color = questcolor.Questcolors[3]; }                
                else if(PlayerSettings.getMainSoul() <=1000) { sprite.color = questcolor.Questcolors[4]; }               
                else if(PlayerSettings.getMainSoul() <=2500) { sprite.color = questcolor.Questcolors[5]; }                
                else if(PlayerSettings.getMainSoul() <=50000) { sprite.color = questcolor.Questcolors[6]; }                
                else { sprite.color = questcolor.Questcolors[6]; }
            }
    }
}

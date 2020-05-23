using UnityEngine;


public class BottomButton : MonoBehaviour
{
    //public static GameObject mapBar;
    public static GameObject unitBar;
    public static GameObject questBar;
    public static GameObject settingBar;

    public int function;
    void Start()
    {
        //mapBar = GameObject.FindGameObjectWithTag("");
        unitBar = GameObject.FindGameObjectWithTag("Unit Bar");
        questBar = GameObject.FindGameObjectWithTag("Quest");
        settingBar = GameObject.FindGameObjectWithTag("Settings");
    }



    void MapBarOpen(){
        //mapBar.SetActive(true);
        unitBar.SetActive(false);
        questBar.SetActive(false);
        settingBar.SetActive(false);
    }
    void UnitBarOpen(){
        //mapBar.SetActive(false);
        unitBar.SetActive(true);
        questBar.SetActive(false);
        settingBar.SetActive(false);
    }
    void QuestBarOpen(){
        //mapBar.SetActive(false);
        unitBar.SetActive(false);
        questBar.SetActive(true);
        settingBar.SetActive(false);
    }
    void SettingBarOpen(){
        //mapBar.SetActive(false);
        unitBar.SetActive(false);
        questBar.SetActive(false);
        settingBar.SetActive(true);
    }


    void OnMouseDown()
    {
        if (function == 0){ MapBarOpen(); }
        else if (function == 1){ UnitBarOpen(); }
        else if (function == 2){ QuestBarOpen(); }
        else if (function == 3){ SettingBarOpen(); }
    }

}

using UnityEngine;
using UnityEngine.UI;

public class UnitAutoClick : MonoBehaviour
{
    
    private Animator animautoclick;
    private int unitnumber;
    private int unitlevel;
    private float autospeed;
    private float unitpower;
    private float tempspeed;

    public float [] AutoPower = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

    public Color [] color;
    private Image img;

    private UnitsPower unitsPower;
    // Start is called before the first frame update
    void Start()
    {
        unitnumber = this.GetComponentInParent<UnitProperty>().unitnumber;
        animautoclick = this.GetComponent<Animator>();
        unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);
        autospeed = 1f/unitnumber;
        tempspeed = autospeed;
        img = this.GetComponent<Image>() ;
        unitsPower = this.GetComponentInParent<UnitsPower>();

        UnitColorUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        unitlevel = PlayerSettings.getMap1UnitLevel(unitnumber);

        UnitColorUpdate();

        animautoclick.speed = autospeed;
    }

    
    void AutoClick(){
        for (int i = 0; i < 30; i++)
        {
            AutoPower [i] = unitsPower.power[i];
            PlayerSettings.setMainGold1(i,PlayerSettings.getMainGold1(i) + AutoPower[i]);
            Battary.nowBattaryValue[i] +=  AutoPower[i];
        }
    }

    void UnitColorUpdate(){

        if(unitlevel == 0)          {img.color = color[0];}
        else if(unitlevel < 25)     {img.color = color[0];animautoclick.SetInteger("Loop",1);}
        else if (unitlevel < 50)    {img.color = color[1];}
        else if (unitlevel < 75)    {img.color = color[2];autospeed = tempspeed*2f;}
        else if (unitlevel < 100)   {img.color = color[3];}
        else if (unitlevel < 125)   {img.color = color[4];autospeed = tempspeed*3f;}
        else if (unitlevel < 150)   {img.color = color[5];}
        else if (unitlevel < 200)   {img.color = color[6];}
        else {img.color = color[7];autospeed = tempspeed*4f;}
        
    }
}

using UnityEngine;

public class UnitInfoBarCreate : MonoBehaviour
{
   public GameObject unitInfoBarObject;

    
    void OnMouseDown()
    {
        this.GetComponent<UnitsPower>().UnitLevelUp();

        if(GameObject.FindGameObjectWithTag("Battary Info Bar") == null && GameObject.FindGameObjectWithTag("Game Reset Bar") == null && GameObject.FindGameObjectWithTag("Map Object Info Bar") == null && GameObject.FindGameObjectWithTag("Unit Info Bar") == null){
            Instantiate(unitInfoBarObject,GameObject.FindGameObjectWithTag("Unit Info Bar Create").transform.position,Quaternion.identity);
        }
        
    }
}

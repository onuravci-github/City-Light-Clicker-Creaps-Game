using UnityEngine;

public class BattaryInfoBarCreate : MonoBehaviour
{
    public GameObject battaryInfoBarCreate;

    
    void OnMouseDown()
    {
        if(GameObject.FindGameObjectWithTag("Battary Info Bar") == null && GameObject.FindGameObjectWithTag("Game Reset Bar") == null && GameObject.FindGameObjectWithTag("Map Object Info Bar") == null && GameObject.FindGameObjectWithTag("Unit Info Bar") == null){
            Instantiate(battaryInfoBarCreate,GameObject.FindGameObjectWithTag("Battary Info Bar Create").transform.position,Quaternion.identity);
        }
    }
}

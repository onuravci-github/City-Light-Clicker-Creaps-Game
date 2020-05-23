using UnityEngine;

public class GameResetBarCreate : MonoBehaviour
{
    public GameObject GameResetBarObject;

    
    void OnMouseDown()
    {
        if(GameObject.FindGameObjectWithTag("Battary Info Bar") == null && GameObject.FindGameObjectWithTag("Game Reset Bar") == null && GameObject.FindGameObjectWithTag("Map Object Info Bar") == null && GameObject.FindGameObjectWithTag("Unit Info Bar") == null){
            Instantiate(GameResetBarObject,GameObject.FindGameObjectWithTag("Game Reset Bar Create").transform.position,Quaternion.identity);
        }
    }
}

using UnityEngine;

public class MapObjectInfoBarCreate : MonoBehaviour
{
    public GameObject mapObjectInfoBarCreate;

    
    void OnMouseDown()
    {
        if(GameObject.FindGameObjectWithTag("Battary Info Bar") == null && GameObject.FindGameObjectWithTag("Game Reset Bar") == null && GameObject.FindGameObjectWithTag("Map Object Info Bar") == null && GameObject.FindGameObjectWithTag("Unit Info Bar") == null){
            Instantiate(mapObjectInfoBarCreate,GameObject.FindGameObjectWithTag("Map Object Info Bar Create").transform.position,Quaternion.identity);
        }
    }
}

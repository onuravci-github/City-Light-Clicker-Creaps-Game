using UnityEngine;

public class GameResetBarDestroy : MonoBehaviour
{
    void Destroy(){
        Destroy(this.gameObject);
    }


    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}

using UnityEngine;

public class IntroStarCreate : MonoBehaviour
{
    public GameObject starobject;
    // Start is called before the first frame update
    void Start(){
        InvokeRepeating("Create",0f,1f);
    }

    void Create(){
        var star = Instantiate(starobject,this.transform.position,Quaternion.identity);
        star.transform.parent = transform;
    }
    
    void OnMouseDown()
    {
        Create();
    }
}

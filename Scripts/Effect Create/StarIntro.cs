using UnityEngine;

public class StarIntro : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
	this.GetComponent<Animator>().SetInteger("Star",Random.Range(1,7));
    }

}
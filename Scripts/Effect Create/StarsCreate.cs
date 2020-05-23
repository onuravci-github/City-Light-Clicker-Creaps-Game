using UnityEngine;

public class StarsCreate : MonoBehaviour
{
    public GameObject stars;
    public static int [] createnumb = new int[] {0,0,0,0,0,0,0};
    public int create;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    void Update()
    {
         Create();
    }

    
    public void Create(){
        if (createnumb[create] != 0 )
        {
            GameObject star = Instantiate(stars,this.transform.position,Quaternion.identity);
            star.transform.parent = transform;
            createnumb[create]--;
        }
    }
}

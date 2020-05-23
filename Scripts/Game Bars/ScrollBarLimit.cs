using UnityEngine;

public class ScrollBarLimit : MonoBehaviour
{
    private RectTransform rect;
    Vector3 startvector;
    Vector3 addvector;

    public Color [] Questcolors;
    // Start is called before the first frame update
    void Start()
    {
        rect = this.GetComponent<RectTransform>();
          
        startvector = rect.transform.position;
        addvector = new Vector3(0f,4.2f,0f);
    }

    // Update is called once per frame
    void Update()
    {
       if (rect.transform.position.y < startvector.y) {
           rect.transform.position = startvector;
       }
       if (rect.transform.position.y > startvector.y + addvector.y + addvector.y)
       {
           Debug.Log(rect.transform.position);
           rect.transform.position = startvector + addvector + addvector;
           Debug.Log(rect.transform.position);
       }
    }
}

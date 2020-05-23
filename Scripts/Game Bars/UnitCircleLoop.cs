using UnityEngine;

public class UnitCircleLoop : MonoBehaviour
{
    private Animator animloop;
    // Start is called before the first frame update
    void Start()
    {
        animloop = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<Unit>().unitlevel != 0)
        {
            animloop.SetInteger("Loop",1);
        }
    }
}

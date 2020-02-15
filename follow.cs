using UnityEngine;

public class follow : MonoBehaviour {

    [SerializeField]
    private float yMax;
    [SerializeField]
    private float xMax;
    [SerializeField]
    private float yMin;
    [SerializeField]
    private float xMin;

    private Transform mTarget;

    Transform target
    {
        get
        {
            if(mTarget == null)
            {
                mTarget = GameObject.FindGameObjectWithTag("Player").transform;
            }
            return mTarget;
        }
    }

    private void Start()
    {
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), Mathf.Clamp(target.position.y, yMin, yMax), transform.position.z);

    }
}

using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour {

    private Transform _transform;
    private Vector2 _currentPosition;
    public float speed = 5;

	// Use this for initialization
	void Start ()
    {
        //make refrence to transform componnt in unity
        this._transform = gameObject.GetComponent<Transform>();

        // this._transform.position = new Vector2(0, 480f); // to create the position and always use vector to assign 

        this.Reset();
	}
	
	// Update is called once per frame
	void Update ()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(0, this.speed);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.y <= -480)
        {
            this.Reset();
        }
	}

    public void Reset()
    {
        this._transform.position = new Vector2(0, 480f);
    }
}

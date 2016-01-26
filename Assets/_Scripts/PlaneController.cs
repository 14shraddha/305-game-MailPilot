using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
   
    //Private
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    //public
    public float speed = 5;

    // Use this for initialization
    void Start ()
    {
        //small gameobject refers to the componennt attached to
        this._transform = gameObject.GetComponent<Transform>();
	}

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;

        this._playerInput = Input.GetAxis("Horizontal");
        //Positive movement move right
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);

        }
        //Positive movement move right
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }
        this._checkBounds();
    }
    //***************PRIVATE METHODS******************************************************************
    private void _checkBounds()
    {
        //checked if the plane goes out of boundary and keep it inside
        if (this._currentPosition.x < -290)
        {
            this._currentPosition.x = -290;
        }
        if (this._currentPosition.x > 290)
        {
            this._currentPosition.x = 290;
        }

        this._transform.position = this._currentPosition;
    }

    
}

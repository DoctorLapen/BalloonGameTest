using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BalloonGameTest
{
    public class Balloon : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D _rb;
        [SerializeField]
        private float _minXForce;
        [SerializeField]
        private float _maxXForce;
        [SerializeField]
        private float _minYForce;
        [SerializeField]
        private float _maxYForce;


        private void Start()
        {

            Vector2 force = new Vector2(Random.Range(_minXForce, _maxXForce), Random.Range(_minYForce, _maxYForce));
            _rb.AddForce(force);
        }

        private void OnMouseDown()
        {
            Destroy(gameObject);
        }
    }
}

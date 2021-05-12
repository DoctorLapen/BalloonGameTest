using UnityEngine;

namespace BalloonGameTest
{
    public class BalloonExplosion : MonoBehaviour
    {
        [SerializeField]
        private BalloonClickHandler _balloonClickHandler;
        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        [SerializeField]
        private GameObject _explosion;
        [SerializeField]
        private float _explosionTime;

        private void Start()
        {
            _balloonClickHandler.BalloonDestroyed += Explode;
        }

        private void Explode()
        {
            _spriteRenderer.enabled = false;
            _explosion.SetActive(true);
            Destroy(gameObject, _explosionTime);
        }

    }

}

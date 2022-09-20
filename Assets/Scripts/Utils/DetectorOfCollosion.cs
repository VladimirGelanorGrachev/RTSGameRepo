using System;
using UniRx;
using UnityEngine;

namespace Utils
{
    public class DetectorOfCollosion : MonoBehaviour
    {
        public IObservable<Collision> Collisions => _collisions;
        private Subject<Collision> _collisions = new Subject<Collision>();

        private void OnCollisionStay(Collision collision)
        {
            _collisions.OnNext(collision);
        }
    }
}

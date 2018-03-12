using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.scripts._Attributes
{
    public delegate void UpdateTransform(Transform _target);
    [ExecuteInEditMode]
    public class Patrol: Trait
    {
        [SerializeField]
        protected Vector3[] _targetPositions;
        public float _speed;
        Vector3 _currentPosition;

        [SerializeField]
        GameObject[] _targetIndicators;
        protected override bool HasTarget()
        {
            return true;
        }

        public void init(float speed,int numberOfIndicators)
        {
            _speed = speed;
            upDateTransform = upDateCurrentPosition;

        }

        void upDateCurrentPosition(Transform  _target)
        {

        }

        private void Update()
        {
            for(int x=0; x< _targetIndicators.Length;x++)
            {
                if (_targetPositions.Length != _targetIndicators.Length)
                    SetPositions(_targetIndicators.Length);
                _targetPositions[x] = _targetIndicators[x].transform.position;
            }
        }

        void SetPositions(int length,params GameObject[] positions)
        {
            _targetPositions = new Vector3[length];

        }

        protected override MeshFilter GetMesh(int index)
        {
            return _meshCollection[index];
        }
        
    }
}

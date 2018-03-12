using UnityEngine;
using System.Collections;


namespace Assets.scripts._Attributes
{
public abstract class Trait : MonoBehaviour //,moods
{
    [SerializeField]
    protected MeshFilter[] _meshCollection;
    protected UpdateTransform upDateTransform;
    protected abstract bool HasTarget();
    protected abstract  MeshFilter GetMesh(int index);



}
}
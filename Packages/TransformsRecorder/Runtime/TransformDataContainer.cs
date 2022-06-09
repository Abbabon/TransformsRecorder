using UnityEngine;

[CreateAssetMenu(fileName = "TransformDataContainer", menuName = "ScriptableObjects/TransformDataContainer")]
public class TransformDataContainer : ScriptableObject
{
    public TransformNode parentNode;
}
using System.Collections.Generic;
using UnityEngine;

public class TransformRecorder : MonoBehaviour
{
    [SerializeField] private Transform _transformsParent;
    [SerializeField] private TransformDataContainer _transformDataContainer;
        
    public void RecordTransforms()
    {
        if (_transformDataContainer != null)
        {
            _transformDataContainer.parentNode = RecordTransformsRecursively(_transformsParent);    
        }
    }

    public void LoadTransforms()
    {
        if (_transformDataContainer != null)
        {
            LoadTransformsRecursively(_transformsParent, _transformDataContainer.parentNode);
        }
    }
        
    private TransformNode RecordTransformsRecursively(Transform parent)
    {
        var directChildren = GetDirectChildrenOfTransform(parent);

        var nodeData = new TransformNode
        {
            NodeTransformData = new TransformData
            {
                Position = parent.localPosition,
                Rotation = parent.localRotation,
                Scale = parent.localScale
            }
        };

        if (directChildren.Count > 0)
        {
            nodeData.ChildrenTransformsData = new List<TransformNode>();
            foreach (var child in directChildren)
            {
                nodeData.ChildrenTransformsData.Add(RecordTransformsRecursively(child));
            }
        }
        else
        {
            nodeData.ChildrenTransformsData = null;   
        }
            
        return nodeData;
    }
        
    private void LoadTransformsRecursively(Transform parent, TransformNode nodeNode)
    {
        var directChildren = GetDirectChildrenOfTransform(parent);

        if (directChildren.Count > 0)
        {
            for (var nodeIndex = 0; nodeIndex < nodeNode.ChildrenTransformsData.Count; nodeIndex++)
            {
                LoadTransformsRecursively(directChildren[nodeIndex], nodeNode.ChildrenTransformsData[nodeIndex]);
            }    
        }
            
        parent.localPosition = nodeNode.NodeTransformData.Position;
        parent.localRotation = nodeNode.NodeTransformData.Rotation;
        parent.localScale = nodeNode.NodeTransformData.Scale;
    }

    private List<Transform> GetDirectChildrenOfTransform(Transform parent)
    {
        var directChildren = new List<Transform>();
        foreach (Transform directChild in parent)
        {
            directChildren.Add(directChild);
        }
        return directChildren;
    }
}
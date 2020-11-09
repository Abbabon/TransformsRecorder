using System;
using System.Collections.Generic;

[Serializable]
public class TransformNode
{
    public TransformData NodeTransformData;
    public List<TransformNode> ChildrenTransformsData;
}
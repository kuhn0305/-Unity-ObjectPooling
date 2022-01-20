using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildExample : ClassExample
{

    private void Update()
    {
        SampleMethod();
    }

    public override void SampleMethod()
    {
        base.SampleMethod();
    }
}

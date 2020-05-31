using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

[Serializable]
public class jsonDataClass
{
    public List<infoList> info;
}

[Serializable]
public class infoList
{
    public string data;
}
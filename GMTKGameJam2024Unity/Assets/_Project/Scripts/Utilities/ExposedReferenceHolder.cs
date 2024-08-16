using System;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable] public class ExposedReferenceHolder<T> where T : Object{[SerializeField] public ExposedReference<T> ExposedReference;}

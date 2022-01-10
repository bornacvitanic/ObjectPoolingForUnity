# ObjectPoolingForUnity

[![Twitter: @BCvitanic](https://img.shields.io/badge/contact-@BCvitanic-blue.svg?style=flat)](https://twitter.com/BCvitanic)

 A object pooling system for Unity using Scriptabe objects to automatically keep track of max instance counts per prefab each session.
 
 Add a object pooler script to an object in the scene and provide it a transform as a parent for all pooled object and an instance of a ObjectPoolPrefabList SO to keep track of max instance counts over sessions.
 
 To pool an instance use:
```
 var instance = ObjectPooler.SharedInstance.Instantiate(prefab);
```
 
 And to return it to the pool use:
```
 ObjectPooler.SharedInstance.ReturnToPool(instance);
```

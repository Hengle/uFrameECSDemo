// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSDemo {
    using Invert.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(10)]
    [uFrame.Attributes.uFrameIdentifier("8f20ac10-5695-40e2-8ea5-8c3ec4716133")]
    public partial class SpawnMultipleAtInterval : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Transform _Parent;
        
        [UnityEngine.SerializeField()]
        private Single _SpawnSpeed;
        
        [UnityEngine.SerializeField()]
        private GameObject[] _Items;
        
        private ReactiveCollection<GameObject> _ItemsReactive;
        
        private Subject<PropertyChangedEvent<Transform>> _ParentObservable;
        
        private PropertyChangedEvent<Transform> _ParentEvent;
        
        private Subject<PropertyChangedEvent<Single>> _SpawnSpeedObservable;
        
        private PropertyChangedEvent<Single> _SpawnSpeedEvent;
        
        public override int ComponentId {
            get {
                return 10;
            }
        }
        
        public IObservable<PropertyChangedEvent<Transform>> ParentObservable {
            get {
                return _ParentObservable ?? (_ParentObservable = new Subject<PropertyChangedEvent<Transform>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> SpawnSpeedObservable {
            get {
                return _SpawnSpeedObservable ?? (_SpawnSpeedObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public Transform Parent {
            get {
                return _Parent;
            }
            set {
                SetParent(value);
            }
        }
        
        public Single SpawnSpeed {
            get {
                return _SpawnSpeed;
            }
            set {
                SetSpawnSpeed(value);
            }
        }
        
        public ReactiveCollection<GameObject> Items {
            get {
                if (_ItemsReactive == null) {
                    _ItemsReactive = new ReactiveCollection<GameObject>(_Items ?? new GameObject[] { });
                }
                return _ItemsReactive;
            }
        }
        
        public virtual void SetParent(Transform value) {
            SetProperty(ref _Parent, value, ref _ParentEvent, _ParentObservable);
        }
        
        public virtual void SetSpawnSpeed(Single value) {
            SetProperty(ref _SpawnSpeed, value, ref _SpawnSpeedEvent, _SpawnSpeedObservable);
        }
    }
}

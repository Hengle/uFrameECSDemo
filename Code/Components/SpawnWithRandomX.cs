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
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UniRx;
    using uFrame.ECS;
    
    
    [uFrame.Attributes.uFrameIdentifier("ddaee2ad-fc4e-438f-bdae-f8a9929e693a")]
    public partial class SpawnWithRandomX : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Single _Z;
        
        [UnityEngine.SerializeField()]
        private Single _Y;
        
        [UnityEngine.SerializeField()]
        private Vector2 _XRange;
        
        private Subject<PropertyChangedEvent<Single>> _ZObservable;
        
        private PropertyChangedEvent<Single> _ZEvent;
        
        private Subject<PropertyChangedEvent<Single>> _YObservable;
        
        private PropertyChangedEvent<Single> _YEvent;
        
        private Subject<PropertyChangedEvent<Vector2>> _XRangeObservable;
        
        private PropertyChangedEvent<Vector2> _XRangeEvent;
        
        public int ComponentID {
            get {
                return 18;
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> ZObservable {
            get {
                return _ZObservable ?? (_ZObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> YObservable {
            get {
                return _YObservable ?? (_YObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Vector2>> XRangeObservable {
            get {
                return _XRangeObservable ?? (_XRangeObservable = new Subject<PropertyChangedEvent<Vector2>>());
            }
        }
        
        public Single Z {
            get {
                return _Z;
            }
            set {
                SetZ(value);
            }
        }
        
        public Single Y {
            get {
                return _Y;
            }
            set {
                SetY(value);
            }
        }
        
        public Vector2 XRange {
            get {
                return _XRange;
            }
            set {
                SetXRange(value);
            }
        }
        
        public virtual void SetZ(Single value) {
            SetProperty(ref _Z, value, ref _ZEvent, _ZObservable);
        }
        
        public virtual void SetY(Single value) {
            SetProperty(ref _Y, value, ref _YEvent, _YObservable);
        }
        
        public virtual void SetXRange(Vector2 value) {
            SetProperty(ref _XRange, value, ref _XRangeEvent, _XRangeObservable);
        }
    }
}

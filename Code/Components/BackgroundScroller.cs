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
    
    
    [uFrame.Attributes.ComponentId(5)]
    [uFrame.Attributes.uFrameIdentifier("542b1cb0-35cb-469d-ba53-6a430a33c2f6")]
    public partial class BackgroundScroller : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Single _TileSizeZ;
        
        [UnityEngine.SerializeField()]
        private Single _ScrollSpeed;
        
        [UnityEngine.SerializeField()]
        private Vector3 _StartPosition;
        
        private Subject<PropertyChangedEvent<Single>> _TileSizeZObservable;
        
        private PropertyChangedEvent<Single> _TileSizeZEvent;
        
        private Subject<PropertyChangedEvent<Single>> _ScrollSpeedObservable;
        
        private PropertyChangedEvent<Single> _ScrollSpeedEvent;
        
        private Subject<PropertyChangedEvent<Vector3>> _StartPositionObservable;
        
        private PropertyChangedEvent<Vector3> _StartPositionEvent;
        
        public override int ComponentId {
            get {
                return 5;
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> TileSizeZObservable {
            get {
                return _TileSizeZObservable ?? (_TileSizeZObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> ScrollSpeedObservable {
            get {
                return _ScrollSpeedObservable ?? (_ScrollSpeedObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Vector3>> StartPositionObservable {
            get {
                return _StartPositionObservable ?? (_StartPositionObservable = new Subject<PropertyChangedEvent<Vector3>>());
            }
        }
        
        public Single TileSizeZ {
            get {
                return _TileSizeZ;
            }
            set {
                SetTileSizeZ(value);
            }
        }
        
        public Single ScrollSpeed {
            get {
                return _ScrollSpeed;
            }
            set {
                SetScrollSpeed(value);
            }
        }
        
        public Vector3 StartPosition {
            get {
                return _StartPosition;
            }
            set {
                SetStartPosition(value);
            }
        }
        
        public virtual void SetTileSizeZ(Single value) {
            SetProperty(ref _TileSizeZ, value, ref _TileSizeZEvent, _TileSizeZObservable);
        }
        
        public virtual void SetScrollSpeed(Single value) {
            SetProperty(ref _ScrollSpeed, value, ref _ScrollSpeedEvent, _ScrollSpeedObservable);
        }
        
        public virtual void SetStartPosition(Vector3 value) {
            SetProperty(ref _StartPosition, value, ref _StartPositionEvent, _StartPositionObservable);
        }
    }
}

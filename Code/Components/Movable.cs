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
    using UniRx;
    using uFrame.ECS;
    using UnityEngine;
    
    
    [uFrame.Attributes.uFrameIdentifier("5be3719a-5806-47ba-83d8-4e43f44ec0c5")]
    public partial class Movable : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Single _Vertical;
        
        [UnityEngine.SerializeField()]
        private Single _Horizontal;
        
        [UnityEngine.SerializeField()]
        private Single _Tilt;
        
        [UnityEngine.SerializeField()]
        private Single _Speed;
        
        private Subject<PropertyChangedEvent<Single>> _VerticalObservable;
        
        private PropertyChangedEvent<Single> _VerticalEvent;
        
        private Subject<PropertyChangedEvent<Single>> _HorizontalObservable;
        
        private PropertyChangedEvent<Single> _HorizontalEvent;
        
        private Subject<PropertyChangedEvent<Single>> _TiltObservable;
        
        private PropertyChangedEvent<Single> _TiltEvent;
        
        private Subject<PropertyChangedEvent<Single>> _SpeedObservable;
        
        private PropertyChangedEvent<Single> _SpeedEvent;
        
        public int ComponentID {
            get {
                return 8;
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> VerticalObservable {
            get {
                return _VerticalObservable ?? (_VerticalObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> HorizontalObservable {
            get {
                return _HorizontalObservable ?? (_HorizontalObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> TiltObservable {
            get {
                return _TiltObservable ?? (_TiltObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> SpeedObservable {
            get {
                return _SpeedObservable ?? (_SpeedObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public Single Vertical {
            get {
                return _Vertical;
            }
            set {
                SetVertical(value);
            }
        }
        
        public Single Horizontal {
            get {
                return _Horizontal;
            }
            set {
                SetHorizontal(value);
            }
        }
        
        public Single Tilt {
            get {
                return _Tilt;
            }
            set {
                SetTilt(value);
            }
        }
        
        public Single Speed {
            get {
                return _Speed;
            }
            set {
                SetSpeed(value);
            }
        }
        
        public virtual void SetVertical(Single value) {
            SetProperty(ref _Vertical, value, ref _VerticalEvent, _VerticalObservable);
        }
        
        public virtual void SetHorizontal(Single value) {
            SetProperty(ref _Horizontal, value, ref _HorizontalEvent, _HorizontalObservable);
        }
        
        public virtual void SetTilt(Single value) {
            SetProperty(ref _Tilt, value, ref _TiltEvent, _TiltObservable);
        }
        
        public virtual void SetSpeed(Single value) {
            SetProperty(ref _Speed, value, ref _SpeedEvent, _SpeedObservable);
        }
    }
}

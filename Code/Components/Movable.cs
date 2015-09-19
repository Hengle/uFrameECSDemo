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
        
        private Subject<Single> _VerticalObservable;
        
        private Subject<Single> _HorizontalObservable;
        
        private Subject<Single> _TiltObservable;
        
        private Subject<Single> _SpeedObservable;
        
        [UnityEngine.SerializeField()]
        private Single _Vertical;
        
        [UnityEngine.SerializeField()]
        private Single _Horizontal;
        
        [UnityEngine.SerializeField()]
        private Single _Tilt;
        
        [UnityEngine.SerializeField()]
        private Single _Speed;
        
        public int ComponentID {
            get {
                return 8;
            }
        }
        
        public IObservable<Single> VerticalObservable {
            get {
                if (_VerticalObservable == null) {
                    _VerticalObservable = new Subject<Single>();
                }
                return _VerticalObservable;
            }
        }
        
        public IObservable<Single> HorizontalObservable {
            get {
                if (_HorizontalObservable == null) {
                    _HorizontalObservable = new Subject<Single>();
                }
                return _HorizontalObservable;
            }
        }
        
        public IObservable<Single> TiltObservable {
            get {
                if (_TiltObservable == null) {
                    _TiltObservable = new Subject<Single>();
                }
                return _TiltObservable;
            }
        }
        
        public IObservable<Single> SpeedObservable {
            get {
                if (_SpeedObservable == null) {
                    _SpeedObservable = new Subject<Single>();
                }
                return _SpeedObservable;
            }
        }
        
        public Single Vertical {
            get {
                return _Vertical;
            }
            set {
                _Vertical = value;
                if (_VerticalObservable != null) {
                    _VerticalObservable.OnNext(value);
                }
            }
        }
        
        public Single Horizontal {
            get {
                return _Horizontal;
            }
            set {
                _Horizontal = value;
                if (_HorizontalObservable != null) {
                    _HorizontalObservable.OnNext(value);
                }
            }
        }
        
        public Single Tilt {
            get {
                return _Tilt;
            }
            set {
                _Tilt = value;
                if (_TiltObservable != null) {
                    _TiltObservable.OnNext(value);
                }
            }
        }
        
        public Single Speed {
            get {
                return _Speed;
            }
            set {
                _Speed = value;
                if (_SpeedObservable != null) {
                    _SpeedObservable.OnNext(value);
                }
            }
        }
    }
}

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
    
    
    [uFrame.Attributes.uFrameIdentifier("462fb967-cd5a-4f3e-b352-a0a155131f91")]
    public partial class EnemyAI : uFrame.ECS.EcsComponent {
        
        private Subject<Single> _SmoothingObservable;
        
        private Subject<Vector2> _ManeuverWaitObservable;
        
        private Subject<Vector2> _StartWaitObservable;
        
        private Subject<Vector2> _ManeuverTimeObservable;
        
        private Subject<Single> _DodgeObservable;
        
        private Subject<Single> _CurrentSpeedObservable;
        
        private Subject<Single> _TiltObservable;
        
        private Subject<Single> _TargetManeuverObservable;
        
        [UnityEngine.SerializeField()]
        private Single _Smoothing;
        
        [UnityEngine.SerializeField()]
        private Vector2 _ManeuverWait;
        
        [UnityEngine.SerializeField()]
        private Vector2 _StartWait;
        
        [UnityEngine.SerializeField()]
        private Vector2 _ManeuverTime;
        
        [UnityEngine.SerializeField()]
        private Single _Dodge;
        
        [UnityEngine.SerializeField()]
        private Single _CurrentSpeed;
        
        [UnityEngine.SerializeField()]
        private Single _Tilt;
        
        [UnityEngine.SerializeField()]
        private Single _TargetManeuver;
        
        public int ComponentID {
            get {
                return 6;
            }
        }
        
        public IObservable<Single> SmoothingObservable {
            get {
                if (_SmoothingObservable == null) {
                    _SmoothingObservable = new Subject<Single>();
                }
                return _SmoothingObservable;
            }
        }
        
        public IObservable<Vector2> ManeuverWaitObservable {
            get {
                if (_ManeuverWaitObservable == null) {
                    _ManeuverWaitObservable = new Subject<Vector2>();
                }
                return _ManeuverWaitObservable;
            }
        }
        
        public IObservable<Vector2> StartWaitObservable {
            get {
                if (_StartWaitObservable == null) {
                    _StartWaitObservable = new Subject<Vector2>();
                }
                return _StartWaitObservable;
            }
        }
        
        public IObservable<Vector2> ManeuverTimeObservable {
            get {
                if (_ManeuverTimeObservable == null) {
                    _ManeuverTimeObservable = new Subject<Vector2>();
                }
                return _ManeuverTimeObservable;
            }
        }
        
        public IObservable<Single> DodgeObservable {
            get {
                if (_DodgeObservable == null) {
                    _DodgeObservable = new Subject<Single>();
                }
                return _DodgeObservable;
            }
        }
        
        public IObservable<Single> CurrentSpeedObservable {
            get {
                if (_CurrentSpeedObservable == null) {
                    _CurrentSpeedObservable = new Subject<Single>();
                }
                return _CurrentSpeedObservable;
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
        
        public IObservable<Single> TargetManeuverObservable {
            get {
                if (_TargetManeuverObservable == null) {
                    _TargetManeuverObservable = new Subject<Single>();
                }
                return _TargetManeuverObservable;
            }
        }
        
        public Single Smoothing {
            get {
                return _Smoothing;
            }
            set {
                _Smoothing = value;
                if (_SmoothingObservable != null) {
                    _SmoothingObservable.OnNext(value);
                }
            }
        }
        
        public Vector2 ManeuverWait {
            get {
                return _ManeuverWait;
            }
            set {
                _ManeuverWait = value;
                if (_ManeuverWaitObservable != null) {
                    _ManeuverWaitObservable.OnNext(value);
                }
            }
        }
        
        public Vector2 StartWait {
            get {
                return _StartWait;
            }
            set {
                _StartWait = value;
                if (_StartWaitObservable != null) {
                    _StartWaitObservable.OnNext(value);
                }
            }
        }
        
        public Vector2 ManeuverTime {
            get {
                return _ManeuverTime;
            }
            set {
                _ManeuverTime = value;
                if (_ManeuverTimeObservable != null) {
                    _ManeuverTimeObservable.OnNext(value);
                }
            }
        }
        
        public Single Dodge {
            get {
                return _Dodge;
            }
            set {
                _Dodge = value;
                if (_DodgeObservable != null) {
                    _DodgeObservable.OnNext(value);
                }
            }
        }
        
        public Single CurrentSpeed {
            get {
                return _CurrentSpeed;
            }
            set {
                _CurrentSpeed = value;
                if (_CurrentSpeedObservable != null) {
                    _CurrentSpeedObservable.OnNext(value);
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
        
        public Single TargetManeuver {
            get {
                return _TargetManeuver;
            }
            set {
                _TargetManeuver = value;
                if (_TargetManeuverObservable != null) {
                    _TargetManeuverObservable.OnNext(value);
                }
            }
        }
    }
}

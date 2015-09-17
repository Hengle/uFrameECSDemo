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
    using uFrame.ECS;
    using UnityEngine;
    using UniRx;
    
    
    [uFrame.Attributes.uFrameIdentifier("eb461b84-87e2-4630-b721-4705c72ae4d6")]
    public partial class Gun : uFrame.ECS.EcsComponent {
        
        private Subject<Single> _FireRateObservable;
        
        private Subject<Single> _NextFireObservable;
        
        private Subject<String> _ProjectilePrefabObservable;
        
        private Subject<GunState> _StateObservable;
        
        [UnityEngine.SerializeField()]
        private Single _FireRate;
        
        [UnityEngine.SerializeField()]
        private Single _NextFire;
        
        [UnityEngine.SerializeField()]
        private String _ProjectilePrefab;
        
        [UnityEngine.SerializeField()]
        private GunState _State;
        
        public int ComponentID {
            get {
                return 22;
            }
        }
        
        public IObservable<Single> FireRateObservable {
            get {
                if (_FireRateObservable == null) {
                    _FireRateObservable = new Subject<Single>();
                }
                return _FireRateObservable;
            }
        }
        
        public IObservable<Single> NextFireObservable {
            get {
                if (_NextFireObservable == null) {
                    _NextFireObservable = new Subject<Single>();
                }
                return _NextFireObservable;
            }
        }
        
        public IObservable<String> ProjectilePrefabObservable {
            get {
                if (_ProjectilePrefabObservable == null) {
                    _ProjectilePrefabObservable = new Subject<String>();
                }
                return _ProjectilePrefabObservable;
            }
        }
        
        public IObservable<GunState> StateObservable {
            get {
                if (_StateObservable == null) {
                    _StateObservable = new Subject<GunState>();
                }
                return _StateObservable;
            }
        }
        
        public Single FireRate {
            get {
                return _FireRate;
            }
            set {
                _FireRate = value;
                if (_FireRateObservable != null) {
                    _FireRateObservable.OnNext(value);
                }
            }
        }
        
        public Single NextFire {
            get {
                return _NextFire;
            }
            set {
                _NextFire = value;
                if (_NextFireObservable != null) {
                    _NextFireObservable.OnNext(value);
                }
            }
        }
        
        public String ProjectilePrefab {
            get {
                return _ProjectilePrefab;
            }
            set {
                _ProjectilePrefab = value;
                if (_ProjectilePrefabObservable != null) {
                    _ProjectilePrefabObservable.OnNext(value);
                }
            }
        }
        
        public GunState State {
            get {
                return _State;
            }
            set {
                _State = value;
                if (_StateObservable != null) {
                    _StateObservable.OnNext(value);
                }
            }
        }
    }
}

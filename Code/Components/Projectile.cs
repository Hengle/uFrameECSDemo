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
    
    
    public partial class Projectile : uFrame.ECS.EcsComponent {
        
        private Subject<Single> _SpeedObservable;
        
        [UnityEngine.SerializeField()]
        private Single _Speed;
        
        public int ComponentID {
            get {
                return 9;
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
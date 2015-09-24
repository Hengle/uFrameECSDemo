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
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.uFrameIdentifier("2a307e59-d342-4b51-98dc-3fe3c252eabc")]
    public partial class PointsOnDestroy : uFrame.ECS.EcsComponent {
        
        private Subject<Int32> _PointsObservable;
        
        [UnityEngine.SerializeField()]
        private Int32 _Points;
        
        public int ComponentID {
            get {
                return 6;
            }
        }
        
        public IObservable<Int32> PointsObservable {
            get {
                if (_PointsObservable == null) {
                    _PointsObservable = new Subject<Int32>();
                }
                return _PointsObservable;
            }
        }
        
        public Int32 Points {
            get {
                return _Points;
            }
            set {
                _Points = value;
                if (_PointsObservable != null) {
                    _PointsObservable.OnNext(value);
                }
            }
        }
    }
}

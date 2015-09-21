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
    using uFrame.ECS;
    using UniRx;
    
    
    [uFrame.Attributes.uFrameIdentifier("aff8180a-e6ff-465a-8980-7cb6e596e8d3")]
    public partial class WavesGame : uFrame.ECS.EcsComponent {
        
        private Subject<Vector3> _SpawnValuesObservable;
        
        private Subject<String> _EnemyPoolNameObservable;
        
        private Subject<Int32> _ScoreObservable;
        
        private Subject<Single> _SpawnWaitObservable;
        
        private Subject<Int32> _HazardCountObservable;
        
        [UnityEngine.SerializeField()]
        private Vector3 _SpawnValues;
        
        [UnityEngine.SerializeField()]
        private String _EnemyPoolName;
        
        [UnityEngine.SerializeField()]
        private Int32 _Score;
        
        [UnityEngine.SerializeField()]
        private Single _SpawnWait;
        
        [UnityEngine.SerializeField()]
        private Int32 _HazardCount;
        
        public int ComponentID {
            get {
                return 18;
            }
        }
        
        public IObservable<Vector3> SpawnValuesObservable {
            get {
                if (_SpawnValuesObservable == null) {
                    _SpawnValuesObservable = new Subject<Vector3>();
                }
                return _SpawnValuesObservable;
            }
        }
        
        public IObservable<String> EnemyPoolNameObservable {
            get {
                if (_EnemyPoolNameObservable == null) {
                    _EnemyPoolNameObservable = new Subject<String>();
                }
                return _EnemyPoolNameObservable;
            }
        }
        
        public IObservable<Int32> ScoreObservable {
            get {
                if (_ScoreObservable == null) {
                    _ScoreObservable = new Subject<Int32>();
                }
                return _ScoreObservable;
            }
        }
        
        public IObservable<Single> SpawnWaitObservable {
            get {
                if (_SpawnWaitObservable == null) {
                    _SpawnWaitObservable = new Subject<Single>();
                }
                return _SpawnWaitObservable;
            }
        }
        
        public IObservable<Int32> HazardCountObservable {
            get {
                if (_HazardCountObservable == null) {
                    _HazardCountObservable = new Subject<Int32>();
                }
                return _HazardCountObservable;
            }
        }
        
        public Vector3 SpawnValues {
            get {
                return _SpawnValues;
            }
            set {
                _SpawnValues = value;
                if (_SpawnValuesObservable != null) {
                    _SpawnValuesObservable.OnNext(value);
                }
            }
        }
        
        public String EnemyPoolName {
            get {
                return _EnemyPoolName;
            }
            set {
                _EnemyPoolName = value;
                if (_EnemyPoolNameObservable != null) {
                    _EnemyPoolNameObservable.OnNext(value);
                }
            }
        }
        
        public Int32 Score {
            get {
                return _Score;
            }
            set {
                _Score = value;
                if (_ScoreObservable != null) {
                    _ScoreObservable.OnNext(value);
                }
            }
        }
        
        public Single SpawnWait {
            get {
                return _SpawnWait;
            }
            set {
                _SpawnWait = value;
                if (_SpawnWaitObservable != null) {
                    _SpawnWaitObservable.OnNext(value);
                }
            }
        }
        
        public Int32 HazardCount {
            get {
                return _HazardCount;
            }
            set {
                _HazardCount = value;
                if (_HazardCountObservable != null) {
                    _HazardCountObservable.OnNext(value);
                }
            }
        }
    }
}

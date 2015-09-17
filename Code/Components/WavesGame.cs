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
        
        private Subject<UnityEngine.Vector3> _SpawnValuesObservable;
        
        private Subject<System.String> _EnemyPoolNameObservable;
        
        private Subject<System.Int32> _ScoreObservable;
        
        private Subject<System.Single> _SpawnWaitObservable;
        
        private Subject<System.Int32> _HazardCountObservable;
        
        [UnityEngine.SerializeField()]
        private UnityEngine.Vector3 _SpawnValues;
        
        [UnityEngine.SerializeField()]
        private string _EnemyPoolName;
        
        [UnityEngine.SerializeField()]
        private int _Score;
        
        [UnityEngine.SerializeField()]
        private float _SpawnWait;
        
        [UnityEngine.SerializeField()]
        private int _HazardCount;
        
        public int ComponentID {
            get {
                return 16;
            }
        }
        
        public IObservable<UnityEngine.Vector3> SpawnValuesObservable {
            get {
                if (_SpawnValuesObservable == null) {
                    _SpawnValuesObservable = new Subject<UnityEngine.Vector3>();
                }
                return _SpawnValuesObservable;
            }
        }
        
        public IObservable<System.String> EnemyPoolNameObservable {
            get {
                if (_EnemyPoolNameObservable == null) {
                    _EnemyPoolNameObservable = new Subject<System.String>();
                }
                return _EnemyPoolNameObservable;
            }
        }
        
        public IObservable<System.Int32> ScoreObservable {
            get {
                if (_ScoreObservable == null) {
                    _ScoreObservable = new Subject<System.Int32>();
                }
                return _ScoreObservable;
            }
        }
        
        public IObservable<System.Single> SpawnWaitObservable {
            get {
                if (_SpawnWaitObservable == null) {
                    _SpawnWaitObservable = new Subject<System.Single>();
                }
                return _SpawnWaitObservable;
            }
        }
        
        public IObservable<System.Int32> HazardCountObservable {
            get {
                if (_HazardCountObservable == null) {
                    _HazardCountObservable = new Subject<System.Int32>();
                }
                return _HazardCountObservable;
            }
        }
        
        public UnityEngine.Vector3 SpawnValues {
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
        
        public string EnemyPoolName {
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
        
        public int Score {
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
        
        public float SpawnWait {
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
        
        public int HazardCount {
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

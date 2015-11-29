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
    using uFrame.Kernel;
    using uFrameECSDemo;
    using UniRx;
    using UnityEngine;
    
    
    public partial class WavesGameSystemBase : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<SpawnAtInterval> _SpawnAtIntervalManager;
        
        private IEcsComponentManagerOf<WavesGame> _WavesGameManager;
        
        private IEcsComponentManagerOf<SpawnMultipleAtInterval> _SpawnMultipleAtIntervalManager;
        
        private IEcsComponentManagerOf<PointsOnDestroy> _PointsOnDestroyManager;
        
        private IEcsComponentManagerOf<PlayGameButton> _PlayGameButtonManager;
        
        private IEcsComponentManagerOf<GameOverOnCollision> _GameOverOnCollisionManager;
        
        private IEcsComponentManagerOf<ScoreText> _ScoreTextManager;
        
        private IEcsComponentManagerOf<MenuUI> _MenuUIManager;
        
        public IEcsComponentManagerOf<SpawnAtInterval> SpawnAtIntervalManager {
            get {
                return _SpawnAtIntervalManager;
            }
            set {
                _SpawnAtIntervalManager = value;
            }
        }
        
        public IEcsComponentManagerOf<WavesGame> WavesGameManager {
            get {
                return _WavesGameManager;
            }
            set {
                _WavesGameManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SpawnMultipleAtInterval> SpawnMultipleAtIntervalManager {
            get {
                return _SpawnMultipleAtIntervalManager;
            }
            set {
                _SpawnMultipleAtIntervalManager = value;
            }
        }
        
        public IEcsComponentManagerOf<PointsOnDestroy> PointsOnDestroyManager {
            get {
                return _PointsOnDestroyManager;
            }
            set {
                _PointsOnDestroyManager = value;
            }
        }
        
        public IEcsComponentManagerOf<PlayGameButton> PlayGameButtonManager {
            get {
                return _PlayGameButtonManager;
            }
            set {
                _PlayGameButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<GameOverOnCollision> GameOverOnCollisionManager {
            get {
                return _GameOverOnCollisionManager;
            }
            set {
                _GameOverOnCollisionManager = value;
            }
        }
        
        public IEcsComponentManagerOf<ScoreText> ScoreTextManager {
            get {
                return _ScoreTextManager;
            }
            set {
                _ScoreTextManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MenuUI> MenuUIManager {
            get {
                return _MenuUIManager;
            }
            set {
                _MenuUIManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            SpawnAtIntervalManager = ComponentSystem.RegisterComponent<SpawnAtInterval>(9);
            WavesGameManager = ComponentSystem.RegisterComponent<WavesGame>(8);
            SpawnMultipleAtIntervalManager = ComponentSystem.RegisterComponent<SpawnMultipleAtInterval>(10);
            PointsOnDestroyManager = ComponentSystem.RegisterComponent<PointsOnDestroy>(12);
            PlayGameButtonManager = ComponentSystem.RegisterComponent<PlayGameButton>(13);
            GameOverOnCollisionManager = ComponentSystem.RegisterComponent<GameOverOnCollision>(11);
            ScoreTextManager = ComponentSystem.RegisterComponent<ScoreText>(7);
            MenuUIManager = ComponentSystem.RegisterComponent<MenuUI>(14);
            SpawnMultipleAtIntervalManager.CreatedObservable.Subscribe(BeginMultipleIntervalSpawnFilter).DisposeWith(this);
            WavesGameManager.CreatedObservable.Subscribe(WavesGameCreatedFilter).DisposeWith(this);
            PointsOnDestroyManager.RemovedObservable.Subscribe(_=>PointsOnDestroyComponentDestroyed(_,_)).DisposeWith(this);
            this.OnEvent<uFrameECSDemo.GameOver>().Subscribe(_=>{ WavesGameSystemGameOverFilter(_); }).DisposeWith(this);
            SpawnAtIntervalManager.CreatedObservable.Subscribe(BeginIntervalSpawnFilter).DisposeWith(this);
        }
        
        protected virtual void BeginMultipleIntervalSpawn(SpawnMultipleAtInterval data, SpawnMultipleAtInterval group) {
            var handler = new BeginMultipleIntervalSpawn();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void BeginMultipleIntervalSpawnFilter(SpawnMultipleAtInterval data) {
            var GroupSpawnMultipleAtInterval = SpawnMultipleAtIntervalManager[data.EntityId];
            if (GroupSpawnMultipleAtInterval == null) {
                return;
            }
            if (!GroupSpawnMultipleAtInterval.Enabled) {
                return;
            }
            this.BeginMultipleIntervalSpawn(data, GroupSpawnMultipleAtInterval);
        }
        
        protected virtual void WavesGameCreated(WavesGame data, WavesGame group) {
            var handler = new WavesGameCreated();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void WavesGameCreatedFilter(WavesGame data) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            if (!GroupWavesGame.Enabled) {
                return;
            }
            this.WavesGameCreated(data, GroupWavesGame);
        }
        
        protected virtual void PointsOnDestroyComponentDestroyed(PointsOnDestroy data, PointsOnDestroy group) {
            var handler = new PointsOnDestroyComponentDestroyed();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void PointsOnDestroyComponentDestroyedFilter(PointsOnDestroy data) {
            var GroupPointsOnDestroy = PointsOnDestroyManager[data.EntityId];
            if (GroupPointsOnDestroy == null) {
                return;
            }
            if (!GroupPointsOnDestroy.Enabled) {
                return;
            }
            this.PointsOnDestroyComponentDestroyed(data, GroupPointsOnDestroy);
        }
        
        protected virtual void WavesGameSystemGameOverHandler(uFrameECSDemo.GameOver data, WavesGame group) {
            var handler = new WavesGameSystemGameOverHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void WavesGameSystemGameOverFilter(uFrameECSDemo.GameOver data) {
            var WavesGameItems = WavesGameManager.Components;
            for (var WavesGameIndex = 0
            ; WavesGameIndex < WavesGameItems.Count; WavesGameIndex++
            ) {
                if (!WavesGameItems[WavesGameIndex].Enabled) {
                    continue;
                }
                this.WavesGameSystemGameOverHandler(data, WavesGameItems[WavesGameIndex]);
            }
        }
        
        protected virtual void BeginIntervalSpawn(SpawnAtInterval data, SpawnAtInterval group) {
            var handler = new BeginIntervalSpawn();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void BeginIntervalSpawnFilter(SpawnAtInterval data) {
            var GroupSpawnAtInterval = SpawnAtIntervalManager[data.EntityId];
            if (GroupSpawnAtInterval == null) {
                return;
            }
            if (!GroupSpawnAtInterval.Enabled) {
                return;
            }
            this.BeginIntervalSpawn(data, GroupSpawnAtInterval);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("9784e33b-b2d5-4aeb-ac8b-9273187d7c8b")]
    public partial class WavesGameSystem : WavesGameSystemBase {
        
        private static WavesGameSystem _Instance;
        
        public WavesGameSystem() {
            Instance = this;
        }
        
        public static WavesGameSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}

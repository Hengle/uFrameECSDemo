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
    using uFrame.Kernel;
    
    
    [uFrame.Attributes.uFrameIdentifier("3a1a8f1b-60bd-42a5-953c-9a3a75b184d5")]
    public partial class HazardSystem : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<RandomRotation> _RandomRotationManager;
        
        private IEcsComponentManagerOf<Projectile> _ProjectileManager;
        
        private IEcsComponentManagerOf<SpawnWithRandomX> _SpawnWithRandomXManager;
        
        private IEcsComponentManagerOf<DestroyOnCollision> _DestroyOnCollisionManager;
        
        private DestroyOnCollisionHandler DestroyOnCollisionHandlerInstance = new DestroyOnCollisionHandler();
        
        private RandomRotationComponentCreated RandomRotationComponentCreatedInstance = new RandomRotationComponentCreated();
        
        private ProjectileComponentCreated ProjectileComponentCreatedInstance = new ProjectileComponentCreated();
        
        private SpawnWithRandomXComponentCreated SpawnWithRandomXComponentCreatedInstance = new SpawnWithRandomXComponentCreated();
        
        public IEcsComponentManagerOf<RandomRotation> RandomRotationManager {
            get {
                return _RandomRotationManager;
            }
            set {
                _RandomRotationManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Projectile> ProjectileManager {
            get {
                return _ProjectileManager;
            }
            set {
                _ProjectileManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SpawnWithRandomX> SpawnWithRandomXManager {
            get {
                return _SpawnWithRandomXManager;
            }
            set {
                _SpawnWithRandomXManager = value;
            }
        }
        
        public IEcsComponentManagerOf<DestroyOnCollision> DestroyOnCollisionManager {
            get {
                return _DestroyOnCollisionManager;
            }
            set {
                _DestroyOnCollisionManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            RandomRotationManager = ComponentSystem.RegisterComponent<RandomRotation>();
            ProjectileManager = ComponentSystem.RegisterComponent<Projectile>();
            SpawnWithRandomXManager = ComponentSystem.RegisterComponent<SpawnWithRandomX>();
            DestroyOnCollisionManager = ComponentSystem.RegisterComponent<DestroyOnCollision>();
            this.OnEvent<uFrame.ECS.OnTriggerEnterDispatcher>().Subscribe(_=>{ DestroyOnCollisionFilter(_); }).DisposeWith(this);
            RandomRotationManager.CreatedObservable.Subscribe(RandomRotationComponentCreatedFilter).DisposeWith(this);
            ProjectileManager.CreatedObservable.Subscribe(ProjectileComponentCreatedFilter).DisposeWith(this);
            SpawnWithRandomXManager.CreatedObservable.Subscribe(SpawnWithRandomXComponentCreatedFilter).DisposeWith(this);
        }
        
        protected void DestroyOnCollisionHandler(uFrame.ECS.OnTriggerEnterDispatcher data, DestroyOnCollision entityid) {
            var handler = DestroyOnCollisionHandlerInstance;;
            handler.System = this;
            handler.Event = data;
            handler.EntityId = entityid;
            handler.Execute();
        }
        
        protected void DestroyOnCollisionFilter(uFrame.ECS.OnTriggerEnterDispatcher data) {
            var EntityIdDestroyOnCollision = DestroyOnCollisionManager[data.EntityId];
            if (EntityIdDestroyOnCollision == null) {
                return;
            }
            this.DestroyOnCollisionHandler(data, EntityIdDestroyOnCollision);
        }
        
        protected void RandomRotationComponentCreated(RandomRotation data, RandomRotation group) {
            var handler = RandomRotationComponentCreatedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void RandomRotationComponentCreatedFilter(RandomRotation data) {
            var GroupRandomRotation = RandomRotationManager[data.EntityId];
            if (GroupRandomRotation == null) {
                return;
            }
            this.RandomRotationComponentCreated(data, GroupRandomRotation);
        }
        
        protected void ProjectileComponentCreated(Projectile data, Projectile group) {
            var handler = ProjectileComponentCreatedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void ProjectileComponentCreatedFilter(Projectile data) {
            var GroupProjectile = ProjectileManager[data.EntityId];
            if (GroupProjectile == null) {
                return;
            }
            this.ProjectileComponentCreated(data, GroupProjectile);
        }
        
        protected void SpawnWithRandomXComponentCreated(SpawnWithRandomX data, SpawnWithRandomX group) {
            var handler = SpawnWithRandomXComponentCreatedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void SpawnWithRandomXComponentCreatedFilter(SpawnWithRandomX data) {
            var GroupSpawnWithRandomX = SpawnWithRandomXManager[data.EntityId];
            if (GroupSpawnWithRandomX == null) {
                return;
            }
            this.SpawnWithRandomXComponentCreated(data, GroupSpawnWithRandomX);
        }
    }
}

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
    using uFrame.Kernel;
    using uFrame.ECS;
    
    
    [uFrame.Attributes.uFrameIdentifier("539cad18-5a60-40ba-b2c3-51f2d670f0e5")]
    public partial class PlayerMovementSystem : uFrame.ECS.EcsSystem, uFrame.ECS.ISystemFixedUpdate {
        
        private IEcsComponentManagerOf<Movable> _MovableManager;
        
        private IEcsComponentManagerOf<Hazard> _HazardManager;
        
        private IEcsComponentManagerOf<PlayerGunner> _PlayerGunnerManager;
        
        private ShooterFixedUpdateHandler ShooterFixedUpdateHandlerInstance = new ShooterFixedUpdateHandler();
        
        public IEcsComponentManagerOf<Movable> MovableManager {
            get {
                return _MovableManager;
            }
            set {
                _MovableManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Hazard> HazardManager {
            get {
                return _HazardManager;
            }
            set {
                _HazardManager = value;
            }
        }
        
        public IEcsComponentManagerOf<PlayerGunner> PlayerGunnerManager {
            get {
                return _PlayerGunnerManager;
            }
            set {
                _PlayerGunnerManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            PlayerGunnerManager = ComponentSystem.RegisterGroup<PlayerGunnerGroup,PlayerGunner>();
            MovableManager = ComponentSystem.RegisterComponent<Movable>();
            HazardManager = ComponentSystem.RegisterComponent<Hazard>();
        }
        
        protected void ShooterFixedUpdateHandler(Movable group) {
            var handler = ShooterFixedUpdateHandlerInstance;;
            handler.System = this;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void ShooterFixedUpdateFilter() {
            var MovableItems = MovableManager.Components;
            for (var MovableIndex = 0
            ; MovableIndex < MovableItems.Count; MovableIndex++
            ) {
                this.ShooterFixedUpdateHandler(MovableItems[MovableIndex]);
            }
        }
        
        public virtual void SystemFixedUpdate() {
            ShooterFixedUpdateFilter();
        }
    }
}
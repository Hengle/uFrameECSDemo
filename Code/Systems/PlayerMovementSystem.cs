namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrameECSDemo;
    using UnityEngine;
    using uFrame.Kernel;
    using uFrame.ECS;
    using UniRx;
    
    
    public partial class PlayerMovementSystem : PlayerMovementSystemBase, uFrame.ECS.ISystemFixedUpdate {
        
        public virtual void SystemFixedUpdate() {
            ShooterFixedUpdateFilter();
        }
    }
}

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrameECSDemo;
    using uFrame.Kernel;
    using uFrame.ECS;
    using UniRx;
    
    
    public partial class WeaponInputSystem : WeaponInputSystemBase, uFrame.ECS.ISystemUpdate {
        
        public virtual void SystemUpdate() {
            GunnerInputUpdateFilter();
        }
    }
}

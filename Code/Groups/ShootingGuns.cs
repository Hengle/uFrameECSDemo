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
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    public partial class ShootingGuns : uFrame.ECS.GroupItem {
        
        private Gun _Gun;
        
        public Gun Gun {
            get {
                return _Gun;
            }
            set {
                _Gun = value;
            }
        }
        
        public int ComponentID {
            get {
                return 27;
            }
        }
    }
}

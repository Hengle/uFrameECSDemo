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
    
    
    public partial class LocalGunner : uFrame.ECS.GroupItem {
        
        private Gunner _Gunner;
        
        private GunnerInput _GunnerInput;
        
        public Gunner Gunner {
            get {
                return _Gunner;
            }
            set {
                _Gunner = value;
            }
        }
        
        public GunnerInput GunnerInput {
            get {
                return _GunnerInput;
            }
            set {
                _GunnerInput = value;
            }
        }
        
        public int ComponentID {
            get {
                return 28;
            }
        }
    }
}

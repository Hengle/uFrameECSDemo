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
    
    
    public partial class PlayerShip : uFrame.ECS.GroupItem {
        
        private Ship _Ship;
        
        private Health _Health;
        
        private Player _Player;
        
        public Ship Ship {
            get {
                return _Ship;
            }
            set {
                _Ship = value;
            }
        }
        
        public Health Health {
            get {
                return _Health;
            }
            set {
                _Health = value;
            }
        }
        
        public Player Player {
            get {
                return _Player;
            }
            set {
                _Player = value;
            }
        }
        
        public int ComponentID {
            get {
                return 24;
            }
        }
    }
}

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
    using uFrame.Kernel;
    
    
    public class HandleDestroyOnCollisionHandler {
        
        public DestroyOnCollision Source;
        
        private uFrame.ECS.OnTriggerEnterDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private int ActionNode2_entityId = default( System.Int32 );
        
        private float ActionNode2_time = default( System.Single );
        
        public uFrame.ECS.OnTriggerEnterDispatcher Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode2_entityId = Source.EntityId;
            // ActionNode
            while (this.DebugInfo("0e52fecd-92b1-4be7-bfb6-9a010273790b","89a77718-1334-464d-85ee-efbc32047645", this) == 1) yield return null;
            // Visit uFrame.Actions.DestroyLibrary.DestroyEntity
            uFrame.Actions.DestroyLibrary.DestroyEntity(ActionNode2_entityId, ActionNode2_time);
            yield break;
        }
    }
}

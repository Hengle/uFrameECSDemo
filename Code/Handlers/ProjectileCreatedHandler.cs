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
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class ProjectileCreatedComponentCreated {
        
        public Projectile Group;
        
        private Projectile _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode3_go = default( UnityEngine.GameObject );
        
        private UnityEngine.MonoBehaviour ActionNode3_component = default( UnityEngine.MonoBehaviour );
        
        private UnityEngine.Rigidbody ActionNode3_Result = default( UnityEngine.Rigidbody );
        
        private UnityEngine.Vector3 ActionNode1_a = default( UnityEngine.Vector3 );
        
        private float ActionNode1_b = default( System.Single );
        
        private UnityEngine.Vector3 ActionNode1_Result = default( UnityEngine.Vector3 );
        
        public Projectile Event {
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
            ActionNode3_go = Group.Entity.gameObject;
            // ActionNode
            while (this.DebugInfo("fd87d60b-7ed8-4917-af15-d43272ae48ed","b79c1b46-db65-4d07-b68a-edb7a9660a30", this) == 1) yield return null;
            // Visit uFrame.Actions.UnityLibrary.GetRigidbody
            ActionNode3_Result = uFrame.Actions.UnityLibrary.GetRigidbody(ActionNode3_go, ActionNode3_component);
            ActionNode1_a = Group.Direction;
            ActionNode1_b = Group.Speed;
            // ActionNode
            while (this.DebugInfo("b79c1b46-db65-4d07-b68a-edb7a9660a30","538ddc66-8110-45f1-b450-bc8c12dc63f3", this) == 1) yield return null;
            // Visit uFrame.Actions.Vector3Library.Multiply
            ActionNode1_Result = uFrame.Actions.Vector3Library.Multiply(ActionNode1_a, ActionNode1_b);
            // SetVariableNode
            while (this.DebugInfo("538ddc66-8110-45f1-b450-bc8c12dc63f3","f78d3844-550f-4931-95da-ce9c8a5c5a1d", this) == 1) yield return null;
            ActionNode3_Result.velocity = (UnityEngine.Vector3)ActionNode1_Result;
            yield break;
        }
    }
}

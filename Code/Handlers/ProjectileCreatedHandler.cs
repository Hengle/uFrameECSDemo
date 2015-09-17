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
    
    
    public class ProjectileComponentCreated {
        
        public Projectile Group;
        
        private Projectile _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode1_go = default( UnityEngine.GameObject );
        
        private UnityEngine.MonoBehaviour ActionNode1_component = default( UnityEngine.MonoBehaviour );
        
        private UnityEngine.Rigidbody ActionNode1_Result = default( UnityEngine.Rigidbody );
        
        private UnityEngine.Vector3 ActionNode2_a = default( UnityEngine.Vector3 );
        
        private float ActionNode2_b = default( System.Single );
        
        private UnityEngine.Vector3 ActionNode2_Result = default( UnityEngine.Vector3 );
        
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
        
        public virtual void Execute() {
            ActionNode1_go = Group.Entity.gameObject;
            // ActionNode
            // Visit uFrame.Actions.UnityLibrary.GetRigidbody
            ActionNode1_Result = uFrame.Actions.UnityLibrary.GetRigidbody(ActionNode1_go, ActionNode1_component);
            ActionNode2_a = Group.Direction;
            ActionNode2_b = Group.Speed;
            // ActionNode
            // Visit uFrame.Actions.Vector3Library.Multiply
            ActionNode2_Result = uFrame.Actions.Vector3Library.Multiply(ActionNode2_a, ActionNode2_b);
            // SetVariableNode
            ActionNode1_Result.velocity = (UnityEngine.Vector3)ActionNode2_Result;
        }
    }
}

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
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class EffectOnDestroyComponentDestroyed {
        
        public EffectOnDestroy Group;
        
        private EffectOnDestroy _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private bool ActionNode5_value = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode6_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.Vector3 ActionNode6_position = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode6_rotation = default( UnityEngine.Vector3 );
        
        private UnityEngine.GameObject ActionNode6_Result = default( UnityEngine.GameObject );
        
        public EffectOnDestroy Event {
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
            ActionNode5_value = Group.IsQuiting;
            // ActionNode
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode5_value, ActionNode5_yes, ActionNode5_no);
        }
        
        private void ActionNode5_yes() {
        }
        
        private void ActionNode5_no() {
            ActionNode6_gameObject = Group.Prefab;
            ActionNode6_position = Group.transform.position;
            // ActionNode
            // Visit uFrame.Actions.GameObjects.Instantiate
            ActionNode6_Result = uFrame.Actions.GameObjects.Instantiate(ActionNode6_gameObject, ActionNode6_position, ActionNode6_rotation);
        }
    }
}

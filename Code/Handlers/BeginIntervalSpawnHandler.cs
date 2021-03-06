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
    
    
    public class BeginIntervalSpawn {
        
        public SpawnAtInterval Group;
        
        private SpawnAtInterval _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private float ActionNode3_Seconds = default( System.Single );
        
        private uFrame.ECS.IEcsComponent ActionNode3_DisposeWith = default( uFrame.ECS.IEcsComponent );
        
        private uFrame.Actions.IntervalBySeconds ActionNode3 = new uFrame.Actions.IntervalBySeconds();
        
        private System.IDisposable ActionNode3_Result = default( System.IDisposable );
        
        private UnityEngine.GameObject ActionNode1_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.Vector3 ActionNode1_position = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode1_rotation = default( UnityEngine.Vector3 );
        
        private UnityEngine.GameObject ActionNode1_Result = default( UnityEngine.GameObject );
        
        public SpawnAtInterval Event {
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
            ActionNode3_Seconds = Group.Speed;
            // ActionNode
            // Visit uFrame.Actions.IntervalBySeconds
            ActionNode3.Seconds = ActionNode3_Seconds;
            ActionNode3.System = System;
            ActionNode3.Tick = ActionNode3_Tick;
            ActionNode3.Execute();
            ActionNode3_Result = ActionNode3.Result;
        }
        
        private void ActionNode3_Tick() {
            ActionNode3_Result = ActionNode3.Result;
            ActionNode1_gameObject = Group.Prefab;
            // ActionNode
            // Visit uFrame.Actions.GameObjects.Instantiate
            ActionNode1_Result = uFrame.Actions.GameObjects.Instantiate(ActionNode1_gameObject, ActionNode1_position, ActionNode1_rotation);
            // SetVariableNode
            ActionNode1_Result.transform.parent = (UnityEngine.Transform)Group.Parent;
        }
    }
}

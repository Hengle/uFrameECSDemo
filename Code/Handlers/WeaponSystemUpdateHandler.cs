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
    
    
    public class WeaponSystemUpdateHandler {
        
        public ShootingGuns Group;
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private float ActionNode4_Result = default( System.Single );
        
        private float ActionNode6_a = default( System.Single );
        
        private float ActionNode6_b = default( System.Single );
        
        private bool ActionNode6_Result = default( System.Boolean );
        
        private float ActionNode2_a = default( System.Single );
        
        private float ActionNode2_b = default( System.Single );
        
        private float ActionNode2_Result = default( System.Single );
        
        private UnityEngine.GameObject ActionNode15_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.Vector3 ActionNode15_position = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode15_rotation = default( UnityEngine.Vector3 );
        
        private UnityEngine.GameObject ActionNode15_Result = default( UnityEngine.GameObject );
        
        private UnityEngine.GameObject ActionNode1_gameObject = default( UnityEngine.GameObject );
        
        private float ActionNode1_time = default( System.Single );
        
        private float FloatNode27 = 3F;
        
        public uFrame.ECS.ISystemUpdate Event {
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
            // ActionNode
            while (this.DebugInfo("1599be78-af9c-4b2f-8109-6914c0ad665e","a87839a8-50e9-4ddc-af31-c79cbc5bd2e9", this) == 1) yield return null;
            // Visit uFrame.Actions.TimeLibrary.GetTime
            ActionNode4_Result = uFrame.Actions.TimeLibrary.GetTime();
            ActionNode6_a = ActionNode4_Result;
            ActionNode6_b = Group.Gun.NextFire;
            // ActionNode
            while (this.DebugInfo("a87839a8-50e9-4ddc-af31-c79cbc5bd2e9","f3a81b87-3370-47f9-a4b1-bde0b43274f6", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.GreaterThan
            ActionNode6_Result = uFrame.Actions.Comparisons.GreaterThan(ActionNode6_a, ActionNode6_b, ()=> { System.StartCoroutine(ActionNode6_yes()); }, ()=> { System.StartCoroutine(ActionNode6_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode6_yes() {
            ActionNode2_a = ActionNode4_Result;
            ActionNode2_b = Group.Gun.FireRate;
            // ActionNode
            while (this.DebugInfo("f3a81b87-3370-47f9-a4b1-bde0b43274f6","1d23ddfa-6b42-4aa3-8b95-52ee6a77032f", this) == 1) yield return null;
            // Visit uFrame.Actions.FloatLibrary.Add
            ActionNode2_Result = uFrame.Actions.FloatLibrary.Add(ActionNode2_a, ActionNode2_b);
            // SetVariableNode
            while (this.DebugInfo("1d23ddfa-6b42-4aa3-8b95-52ee6a77032f","166b2534-d9a8-4da8-a7ac-82ceb974d8af", this) == 1) yield return null;
            Group.Gun.NextFire = (System.Single)ActionNode2_Result;
            ActionNode15_gameObject = Group.Gun.ProjectilePrefab;
            ActionNode15_position = Group.Entity.transform.position;
            // ActionNode
            while (this.DebugInfo("166b2534-d9a8-4da8-a7ac-82ceb974d8af","a7d7f4d0-e6e2-443d-bc47-4244290065cc", this) == 1) yield return null;
            // Visit uFrame.Actions.GameObjects.Instantiate
            ActionNode15_Result = uFrame.Actions.GameObjects.Instantiate(ActionNode15_gameObject, ActionNode15_position, ActionNode15_rotation);
            ActionNode1_gameObject = ActionNode15_Result.gameObject;
            ActionNode1_time = FloatNode27;
            // ActionNode
            while (this.DebugInfo("a7d7f4d0-e6e2-443d-bc47-4244290065cc","1221df01-fe08-4b24-969b-757ac2504a9e", this) == 1) yield return null;
            // Visit uFrame.Actions.DestroyLibrary.DestroyGameObject
            uFrame.Actions.DestroyLibrary.DestroyGameObject(ActionNode1_gameObject, ActionNode1_time);
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode6_no() {
            yield break;
        }
    }
}

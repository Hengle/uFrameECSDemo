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
    using uFrame.Kernel;
    
    
    public class GunnerInputUpdateHandler {
        
        public PlayerGunner Group;
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.KeyCode ActionNode3_key = default( UnityEngine.KeyCode );
        
        private UnityEngine.KeyCode EnumValueNode1 = KeyCode.Space;
        
        private bool ActionNode3_Result = default( System.Boolean );
        
        private uFrameECSDemo.Gun LoopCollectionNode11_Item = default( uFrameECSDemo.Gun );
        
        private uFrameECSDemo.GunState EnumValueNode10 = GunState.Shooting;
        
        private uFrameECSDemo.Gun LoopCollectionNode10_Item = default( uFrameECSDemo.Gun );
        
        private uFrameECSDemo.GunState EnumValueNode9 = GunState.Idle;
        
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
            ActionNode3_key = EnumValueNode1;
            // ActionNode
            while (this.DebugInfo("5d9e6255-926d-40e7-b316-d63686ca222f","34e53f1a-79a2-4a0a-a8e3-d70477e3f946", this) == 1) yield return null;
            // Visit uFrame.Actions.InputLibrary.IsKeyDown
            ActionNode3_Result = uFrame.Actions.InputLibrary.IsKeyDown(ActionNode3_key, ()=> { System.StartCoroutine(ActionNode3_yes()); }, ()=> { System.StartCoroutine(ActionNode3_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator LoopCollectionNode11_Next() {
            // SetVariableNode
            while (this.DebugInfo("d765f854-8f4a-4507-a885-a0b610fd1fee","04621456-8687-41df-9c99-8d9b925a468b", this) == 1) yield return null;
            LoopCollectionNode11_Item.State = (uFrameECSDemo.GunState)EnumValueNode10;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode3_yes() {
            // LoopCollectionNode
            while (this.DebugInfo("34e53f1a-79a2-4a0a-a8e3-d70477e3f946","d765f854-8f4a-4507-a885-a0b610fd1fee", this) == 1) yield return null;
            for (var LoopCollectionNode11_ItemIndex = 0
            ; LoopCollectionNode11_ItemIndex < Group.Gunner.Guns.Count; LoopCollectionNode11_ItemIndex++
            ) {
                LoopCollectionNode11_Item = Group.Gunner.Guns[LoopCollectionNode11_ItemIndex];
                System.StartCoroutine(LoopCollectionNode11_Next());
            }
            yield break;
        }
        
        private System.Collections.IEnumerator LoopCollectionNode10_Next() {
            // SetVariableNode
            while (this.DebugInfo("c584d406-a9f3-4fff-b402-3df2d4cb2129","130ab2bc-a8a4-4292-a1e9-67e427002a4a", this) == 1) yield return null;
            LoopCollectionNode10_Item.State = (uFrameECSDemo.GunState)EnumValueNode9;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode3_no() {
            // LoopCollectionNode
            while (this.DebugInfo("04621456-8687-41df-9c99-8d9b925a468b","c584d406-a9f3-4fff-b402-3df2d4cb2129", this) == 1) yield return null;
            for (var LoopCollectionNode10_ItemIndex = 0
            ; LoopCollectionNode10_ItemIndex < Group.Gunner.Guns.Count; LoopCollectionNode10_ItemIndex++
            ) {
                LoopCollectionNode10_Item = Group.Gunner.Guns[LoopCollectionNode10_ItemIndex];
                System.StartCoroutine(LoopCollectionNode10_Next());
            }
            yield break;
        }
    }
}
